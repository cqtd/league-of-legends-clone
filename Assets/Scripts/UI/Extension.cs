using System;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public static class Extension
{
	[NotNull]
	public static RectTransform rectTransform(this Component comp)
	{
#if UNITY_EDITOR
		if (comp == null)
		{
			throw new Exception($"{comp} is null");
		}
#endif
		if (comp.transform is RectTransform rect)
		{
			return rect;
		}
#if UNITY_EDITOR
		else
		{
			throw new Exception($"{comp} doesn't have RectTransform");
		} 
#else
		return null;
#endif
	}

	public static void SetText(this Text text, string str)
	{
		if (text == null) return;
		text.text = str.Replace("\\n", "\n");
	}

	public static void SetText(this Text text, string format, params object[] args)
	{
		if (text == null) return;
		if (string.IsNullOrEmpty(format))
		{
			text.text = string.Empty;
			return;
		}

		string str = string.Format(format, args);
		text.text = str.Replace("\\n", "\n");
	}

	public static bool IsDestroyed(this GameObject gameObject)
	{
		// UnityEngine overloads the == operator for the GameObject type
		// and returns null when the object has been destroyed, but 
		// actually the object is still there but has not been cleaned up yet
		// if we test both we can determine if the object has been destroyed.
		return gameObject == null && !ReferenceEquals(gameObject, null);
	}

	public static Color32 HexToColor(this string hex)
	{
		hex = hex.Replace("#", "");
		byte a = 255;
		byte r = byte.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
		byte g = byte.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
		byte b = byte.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

		if (hex.Length == 8)
			a = byte.Parse(hex.Substring(6, 2), System.Globalization.NumberStyles.HexNumber);

		return new Color32(r, g, b, a);
	}

	public static string ColorToHex(this Color32 color)
	{
		string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
		return hex;
	}

	public static string ColorToHex(this Color color)
	{
		string hex = color.r.ToString("X2") + color.g.ToString("X2") + color.b.ToString("X2");
		return hex;
	}

	public static void SetLayer(this GameObject go, int layer)
	{
		go.layer = layer;
	}

	public static void SetLayerRecursive(this GameObject go, int layer)
	{
		go.SetLayer(layer);

		foreach (Transform child in go.transform)
		{
			SetLayerRecursive(child.gameObject, layer);
		}
	}
}

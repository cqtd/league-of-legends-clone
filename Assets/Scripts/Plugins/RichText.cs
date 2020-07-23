namespace CQ
{
    public static class RichText
    {
        #region Modifications
        public static string Bold(this object obj) { return $"<b>{obj}</b>"; }
        public static string Italic(this object obj) { return $"<i>{obj}</i>"; }
        public static string Size(this object obj, int size) { return $"<size={size}>{obj}</size>"; }
        #endregion
        
        #region Colors

        public static string Aqua(this object obj) { return Make(obj, "aqua"); }
        public static string Black(this object obj) { return Make(obj, "black");}
        public static string Blue(this object obj) { return Make(obj, "blue"); }
        public static string Brown(this object obj) { return Make(obj, "brown"); }
        public static string Cyan(this object obj) { return Make(obj, "cyan"); }
        public static string DarkBlue(this object obj) { return Make(obj, "darkblue"); }
        public static string Fuchsia(this object obj) { return Make(obj, "fuchsia"); }
        public static string Green(this object obj) { return Make(obj, "green"); }
        public static string Grey(this object obj) { return Make(obj, "grey"); }
        public static string Gray(this object obj) { return Make(obj, "grey"); }
        public static string LightBlue(this object obj) { return Make(obj, "lightblue"); }
        public static string Lime(this object obj) { return Make(obj, "lime"); }
        public static string Magenta(this object obj) { return Make(obj, "magenta"); }
        public static string Maroon(this object obj) { return Make(obj, "maroon"); }
        public static string Navy(this object obj) { return Make(obj, "navy"); }
        public static string Olive(this object obj) { return Make(obj, "olive"); }
        public static string Orange(this object obj) { return Make(obj, "orange"); }
        public static string Purple(this object obj) { return Make(obj, "purple"); }
        public static string Red(this object obj) { return Make(obj, "red"); }
        public static string Silver(this object obj) { return Make(obj, "silver"); }
        public static string Teal(this object obj) { return Make(obj, "teal"); }
        public static string White(this object obj) { return Make(obj, "white"); }
        public static string Yellow(this object obj) { return Make(obj, "yellow"); }
        
        static string Make(object obj, string color)
        {
            return $"<color={color}>{obj}</color>";
        }
        
        #endregion
    }
}
using StandardAssets.Characters.Common;
using UnityEngine;

namespace CQ.LeagueOfLegends
{
	public class UnitBrain : CharacterBrain
	{
		public enum AnimatorState
		{
			Locomotion,
			Attack,
			Spell,
		}
		
		[Header("Unit Brain")]
		[SerializeField, Tooltip("Character's max movement speed")]
		float m_MaxSpeed = 5f;

		[SerializeField, Tooltip("Time take to accelerate from rest to max speed")]
		float m_TimeToMaxSpeed = 0.5f;
		
		[SerializeField, Tooltip("Character's rotational speed")] 
		float m_TurnSpeed = 300f;

		[SerializeField, Tooltip("Initial upward velocity applied on jumping")]
		float m_JumpSpeed = 5f;
	   
		// The current movement properties
		float m_CurrentSpeed;

		public override float normalizedForwardSpeed
		{
			get
			{
				return m_CurrentSpeed / m_MaxSpeed;
			}
		}

		public override float targetYRotation { get; set; }
		public override bool MovingPlatformCanRotateCamera()
		{
			return false;
		}
	}
}
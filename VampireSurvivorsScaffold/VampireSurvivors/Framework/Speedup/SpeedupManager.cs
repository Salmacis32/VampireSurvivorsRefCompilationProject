/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Speedup
{
	public class SpeedupManager // TypeDefIndex: 18159
	{
		// Fields
		private static SpeedupManager m_Instance; // 0x00
		private float m_CurrentSpeedMultiplier; // 0x10
		private float m_DefaultSpeedMultiplier; // 0x14
		private float m_MaxSpeed; // 0x18
		private float m_MinimumSpeed; // 0x1C
		private bool m_isSpeedupBlocked; // 0x20
		private const float c_SpeedMultiplierSpeedupStep = 0.5f; // Metadata: 0x01978757
		private Player m_Player; // 0x28
	
		// Properties
		public static SpeedupManager Instance { get => default; } // 0x00000001866DEB20-0x00000001866DEC00 
		public float CurrentSpeedMultiplier { get => default; } // 0x0000000182740170-0x0000000182740180 
		public bool IsSpeedupBlocked { get => default; } // 0x0000000181E0A560-0x0000000181E0A570 
	
		// Constructors
		public SpeedupManager() {} // 0x00000001866DF940-0x00000001866DF960
	
		// Methods
		public void Setup() {} // 0x00000001866DEC00-0x00000001866DEDB0
		private void SetupInputDelegates() {} // 0x00000001866DEDB0-0x00000001866DEE60
		private void RemoveInputDelegates() {} // 0x00000001866DEE60-0x00000001866DEF10
		public float GetCurrentSpeedUpMultiplier() => default; // 0x0000000182740170-0x0000000182740180
		public void ToggleSpeedup(InputActionEventData _) {} // 0x00000001866DEF10-0x00000001866DF0D0
		public void IncreaseSpeedup() {} // 0x00000001866DF0D0-0x00000001866DF150
		public void IncreaseSpeedup(float increaseBy = 0.5f /* Metadata: 0x0197874F */) {} // 0x00000001866DF150-0x00000001866DF1E0
		public void ReduceSpeedup() {} // 0x00000001866DF1E0-0x00000001866DF260
		public void ReduceSpeedup(float reduceBy = 0.5f /* Metadata: 0x01978753 */) {} // 0x00000001866DF260-0x00000001866DF2F0
		public void SetSpeedup(float speed) {} // 0x00000001866DF2F0-0x00000001866DF570
		public void SetSpeedupDebug(float speed) {} // 0x00000001866DF570-0x00000001866DF650
		public void SetSpeedupBlocked(bool isBlocked) {} // 0x00000001866DF650-0x00000001866DF7A0
		public static void ClearSpeedupManager() {} // 0x00000001866DF7A0-0x00000001866DF940
	}
}

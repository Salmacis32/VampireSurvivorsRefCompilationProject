/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class TP_Blackmore_Character : TP_Character // TypeDefIndex: 17036
	{
		// Fields
		private SpriteRenderer _back2Sprite; // 0x3F0
		private SpriteAnimation _back2Anim; // 0x3F8
		private int _morphedTimes; // 0x400
		private int _finalMorphedTimes; // 0x404
		private int _finalThreshold; // 0x408
		private int _enemiesTs; // 0x40C
		private bool _back2SpriteInitialized; // 0x410
		private int[] _thresholds; // 0x418
	
		// Constructors
		public TP_Blackmore_Character() {} // 0x0000000187152990-0x0000000187152A70
	
		// Methods
		private void CalculateTreshold() {} // 0x0000000187151F30-0x0000000187151FA0
		public override void AfterFullInitialization() {} // 0x0000000187151FA0-0x0000000187152690
		protected override void OnUpdate() {} // 0x0000000187152690-0x00000001871528A0
		[Command]
		public void EnterSkillSelection() {} // 0x00000001871528A0-0x0000000187152900
		private void LateUpdate() {} // 0x0000000187152900-0x0000000187152990
	}
}

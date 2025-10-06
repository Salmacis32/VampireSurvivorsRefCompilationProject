/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class CharacterControllerBatsBatsBats : CharacterController // TypeDefIndex: 16933
	{
		// Fields
		private Battilia2Weapon Battilia2Weapon; // 0x3F0
		private float _baseWeaponPower; // 0x3F8
		private SpriteRenderer _back2Sprite; // 0x400
		private SpriteRenderer _front2Sprite; // 0x408
		private SpriteRenderer _back3Sprite; // 0x410
		private SpriteRenderer _front3Sprite; // 0x418
		private SpriteAnimation _back2Anim; // 0x420
		private SpriteAnimation _front2Anim; // 0x428
		private SpriteAnimation _back3Anim; // 0x430
		private SpriteAnimation _front3Anim; // 0x438
		private int _followers; // 0x440
	
		// Properties
		public override bool NeedsCart { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	
		// Constructors
		public CharacterControllerBatsBatsBats() {} // 0x000000018710B900-0x000000018710B920
	
		// Methods
		public override float PAmount() => default; // 0x0000000187109DB0-0x0000000187109E70
		protected override void OnStop() {} // 0x0000000180B15170-0x0000000180B15180
		public override void AfterFullInitialization() {} // 0x0000000187109E70-0x000000018710AFD0
		protected override void OnUpdate() {} // 0x000000018710AFD0-0x000000018710B4F0
		public override void LevelUp() {} // 0x000000018710B4F0-0x000000018710B680
		public override void Revive(float percentage = 1f /* Metadata: 0x01977F1D */, bool instantRevival = false /* Metadata: 0x01977F21 */) {} // 0x000000018710B680-0x000000018710B900
		public override void DoPostRevivalActions(CharacterController revived, bool instantRevival = false /* Metadata: 0x01977F22 */) {} // 0x0000000180B15170-0x0000000180B15180
	}
}

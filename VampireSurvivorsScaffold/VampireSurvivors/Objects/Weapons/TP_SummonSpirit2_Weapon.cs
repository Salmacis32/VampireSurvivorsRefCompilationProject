/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_SummonSpirit2_Weapon : TP_SummonSpirit_Weapon // TypeDefIndex: 16500
	{
		// Fields
		private float _deltaTime; // 0x190
		private const float Percentage = 0.0625f; // Metadata: 0x01977CF3
		private const float Radius = 1f; // Metadata: 0x01977CF7
		private const float SpeedModifier = 25f; // Metadata: 0x01977CFB
	
		// Properties
		protected override float2 BulletSpawnPos { get => default; } // 0x0000000186FF7F00-0x0000000186FF7F20 
		protected override SpriteTextureData PortalSprite { get => default; } // 0x0000000186FF7F20-0x0000000186FF8090 
	
		// Constructors
		public TP_SummonSpirit2_Weapon() {} // 0x0000000186FF86C0-0x0000000186FF8730
	
		// Methods
		public override void InitWeapon(CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FF8090-0x0000000186FF80B0
		public override void InternalUpdate() {} // 0x0000000186FF80B0-0x0000000186FF81C0
		private void DoTweens() {} // 0x0000000186FF81C0-0x0000000186FF8420
		private void UpdatePortalPosition() {} // 0x0000000186FF8420-0x0000000186FF84D0
		private void UpdatePortalRotation() {} // 0x0000000186FF84D0-0x0000000186FF8540
		protected override void SetPortalPosition() {} // 0x0000000180B15170-0x0000000180B15180
		protected override void DoPortalTween() {} // 0x0000000180B15170-0x0000000180B15180
		public override void CheckArcanas() {} // 0x0000000186FF8540-0x0000000186FF86C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class Unused_TP_Savrog2_Projectile : TP_Savrog_Projectile // TypeDefIndex: 15736
	{
		// Fields
		[SerializeField]
		private TrailRenderer _Trail; // 0x100
		[SerializeField]
		private TrailRenderer _Trail2; // 0x108
		private Unused_TP_Savrog2_Weapon _trueWeapon; // 0x110
		private bool _isYeeted; // 0x118
		private MultiTargetTween _tintTween; // 0x120
		private int _tintCounter; // 0x128
	
		// Constructors
		public Unused_TP_Savrog2_Projectile() {} // 0x0000000186D0AB80-0x0000000186D0ABE0
	
		// Methods
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D5EEC0-0x0000000186D5F010
		private void InitTrails() {} // 0x0000000186D5F010-0x0000000186D5F2C0
		private void UpdateTrailTints() {} // 0x0000000186D5F2C0-0x0000000186D5F440
		private void DoTintTween() {} // 0x0000000186D5F440-0x0000000186D5F7F0
		public void Yeet(Vector2 vector) {} // 0x0000000186D5F7F0-0x0000000186D5FD70
		public override void Despawn() {} // 0x0000000186D5FD70-0x0000000186D5FE20
	}
}

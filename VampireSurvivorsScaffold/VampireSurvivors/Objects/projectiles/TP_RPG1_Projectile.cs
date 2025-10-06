/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class TP_RPG1_Projectile : Projectile // TypeDefIndex: 15640
	{
		// Fields
		private Tween _angleTween; // 0xD0
		private MultiTargetTween _moveXTween; // 0xD8
		private MultiTargetTween _moveYTween; // 0xE0
		private MultiTargetTween _moveYTween2; // 0xE8
		private MultiTargetTween _scaleGrenadeTween; // 0xF0
		private TP_RPG1_Weapon _rpgWeapon; // 0xF8
		private VampireSurvivors.Framework.TimerSystem.Timer _tintTimer; // 0x100
		private const uint Red = 16711680; // Metadata: 0x01977797
		private const uint White = 16777215; // Metadata: 0x0197779B
		private float _explosionDelay; // 0x108
		private VampireSurvivors.Framework.TimerSystem.Timer _explosionTimer; // 0x110
		private float _throwSpeed; // 0x118
		private float _rollSpeed; // 0x11C
		private float _landToTargetPosRatio; // 0x120
	
		// Constructors
		public TP_RPG1_Projectile() {} // 0x0000000186D01C10-0x0000000186D01C90
	
		// Methods
		protected override void Awake() {} // 0x0000000186D004B0-0x0000000186D00550
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D00550-0x0000000186D01810
		private void DoTintCycle() {} // 0x0000000186D01810-0x0000000186D01A00
		protected void Explode() {} // 0x0000000186D01A00-0x0000000186D01B70
		public override void Despawn() {} // 0x0000000186D01B70-0x0000000186D01C10
	}
}

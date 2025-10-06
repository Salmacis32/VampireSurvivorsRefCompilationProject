/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyRotating : EnemyController // TypeDefIndex: 17377
	{
		// Fields
		private float _previousDistance; // 0x270
		private bool _isRotating; // 0x274
		private Tween _onEnterTween; // 0x278
		private Tween _onFireTimer; // 0x280
		private Tween _rotateTween; // 0x288
	
		// Constructors
		public EnemyRotating() {} // 0x0000000187297A60-0x0000000187297AB0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187297350-0x00000001872976E0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784DB */, float damageKb = 1f /* Metadata: 0x019784DC */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784E0 */, bool hasKb = true /* Metadata: 0x019784E1 */) {} // 0x00000001872976E0-0x00000001872977B0
		protected override void OnUpdate() {} // 0x00000001872977B0-0x00000001872979D0
		protected override void ProcessWiggle() {} // 0x00000001872979D0-0x00000001872979F0
		private void StartRotate() {} // 0x00000001872979F0-0x0000000187297A60
	}
}

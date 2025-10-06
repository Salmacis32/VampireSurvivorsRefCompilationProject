/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Unity.Mathematics;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class Enemy_TP_DeathScytheBig : EnemyController // TypeDefIndex: 17254
	{
		// Fields
		private float _chaseTimer; // 0x270
		private bool _hasHit; // 0x274
		private bool _startedSwing; // 0x275
		private MultiTargetTween _warningTween; // 0x278
		private MultiTargetTween _swingTween; // 0x280
		private MultiTargetTween _swingFadeATween; // 0x288
		private MultiTargetTween _swingFadeBTween; // 0x290
	
		// Constructors
		public Enemy_TP_DeathScytheBig() {} // 0x000000018721BD60-0x000000018721BDB0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187218EF0-0x00000001872192A0
		private CharacterController FindBestPlayerTarget() => default; // 0x00000001872192A0-0x0000000187219440
		protected override void Die() {} // 0x0000000180B15170-0x0000000180B15180
		public override void Disappear() {} // 0x00000001872182C0-0x00000001872182D0
		public void Cleanup() {} // 0x0000000187219440-0x00000001872194A0
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978317 */, float damageKb = 1f /* Metadata: 0x01978318 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197831C */, bool hasKb = true /* Metadata: 0x0197831D */) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void OnUpdate() {} // 0x00000001872194A0-0x0000000187219A40
		private float2 SwingTargetPos() => default; // 0x0000000187219A40-0x0000000187219B50
		private void DoSwing() {} // 0x0000000187219B50-0x0000000187219EC0
		private void SingleWarning(float2 position) {} // 0x0000000187219EC0-0x000000018721A3F0
		private bool DoHit(CharacterController player) => default; // 0x000000018721A3F0-0x000000018721A720
		public override void OnPlayerOverlap(CharacterController player) {} // 0x0000000180B15170-0x0000000180B15180
		private void SummonDirecter() {} // 0x000000018721A720-0x000000018721A7D0
		private void RemoveAllWeaponsFromEachPlayer() {} // 0x000000018721A7D0-0x000000018721B0A0
		private void GiveEveryoneWhipsBecauseWhyNot() {} // 0x000000018721B0A0-0x000000018721B250
		private void RemoveAllFollowers() {} // 0x000000018721B250-0x000000018721B430
		private void KillAndUseUpRevivals() {} // 0x000000018721B430-0x000000018721B930
		private void KillAndDirecterRevives() {} // 0x000000018721B930-0x000000018721BC60
		private void BlockByDirecter() {} // 0x000000018721BC60-0x000000018721BD60
	}
}

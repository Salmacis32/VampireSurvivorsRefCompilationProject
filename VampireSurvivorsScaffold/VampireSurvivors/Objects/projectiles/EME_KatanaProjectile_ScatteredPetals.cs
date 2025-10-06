/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class EME_KatanaProjectile_ScatteredPetals : Projectile // TypeDefIndex: 15783
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _MoonVFX; // 0xD0
		[SerializeField]
		private ParticleSystem _SlashVFX1; // 0xD8
		[SerializeField]
		private ParticleSystem _SlashVFX2; // 0xE0
		[SerializeField]
		private ParticleSystem _SlashVFX3; // 0xE8
		[SerializeField]
		private ParticleSystem _PetalsSlashVFX1; // 0xF0
		[SerializeField]
		private ParticleSystem _PetalsSlashVFX2; // 0xF8
		[SerializeField]
		private ParticleSystem _PetalsSlashVFX3a; // 0x100
		[SerializeField]
		private ParticleSystem _PetalsSlashVFX3b; // 0x108
		[SerializeField]
		private ParticleSystem _KanjiVFX1; // 0x110
		[SerializeField]
		private ParticleSystem _KanjiVFX2; // 0x118
		[SerializeField]
		private ParticleSystem _KanjiVFX3; // 0x120
		[SerializeField]
		private MeshRenderer _SlashLine1; // 0x128
		[SerializeField]
		private MeshRenderer _SlashLightBeamLine1; // 0x130
		[SerializeField]
		private MeshRenderer _SlashLine2; // 0x138
		[SerializeField]
		private MeshRenderer _SlashLightBeamLine2; // 0x140
		[SerializeField]
		private MeshRenderer _SlashLine3; // 0x148
		[SerializeField]
		private MeshRenderer _SlashLightBeamLine3; // 0x150
		[SerializeField]
		private ParticleSystem _EndSlashesVFX; // 0x158
		[SerializeField]
		private float LineSlashSpeed; // 0x160
		private const float MoonVFXScale = 0.75f; // Metadata: 0x01977858
		private MaterialPropertyBlock _slashLine1PropBlock; // 0x168
		private MaterialPropertyBlock _slashLightBeam1PropBlock; // 0x170
		private MaterialPropertyBlock _slashLine2PropBlock; // 0x178
		private MaterialPropertyBlock _slashLightBeam2PropBlock; // 0x180
		private MaterialPropertyBlock _slashLine3PropBlock; // 0x188
		private MaterialPropertyBlock _slashLightBeam3PropBlock; // 0x190
		private VampireSurvivors.Framework.TimerSystem.Timer _miniSlashTimer; // 0x198
		private VampireSurvivors.Framework.TimerSystem.Timer _slashTimer; // 0x1A0
		private VampireSurvivors.Framework.TimerSystem.Timer _bodyTimer; // 0x1A8
		private VampireSurvivors.Framework.TimerSystem.Timer _sfxTimer; // 0x1B0
		private MultiTargetTween _fadeTween; // 0x1B8
		private MultiTargetTween _scaleTween; // 0x1C0
		private MultiTargetTween _miniSlashTween; // 0x1C8
		private EME_Katana2Weapon _trueWeapon; // 0x1D0
		private static readonly int StepOverrideAmount; // 0x00
	
		// Constructors
		public EME_KatanaProjectile_ScatteredPetals() {} // 0x0000000186D8DEE0-0x0000000186D8DF40
		static EME_KatanaProjectile_ScatteredPetals() {} // 0x0000000186D8DF40-0x0000000186D8DFA0
	
		// Methods
		protected override void Awake() {} // 0x0000000186D8B6F0-0x0000000186D8BB40
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186D8BB40-0x0000000186D8C110
		public override void InternalUpdate() {} // 0x0000000186D8C110-0x0000000186D8C120
		private void UpdatePosition() {} // 0x0000000186D8C120-0x0000000186D8C190
		private void Sequence_FadeInMoon() {} // 0x0000000186D8C190-0x0000000186D8C440
		private void Sequence_UpwardsSlash() {} // 0x0000000186D8C440-0x0000000186D8C600
		private void Sequence_DownwardsSlash() {} // 0x0000000186D8C600-0x0000000186D8C7B0
		private void Sequence_MiniSlashes() {} // 0x0000000186D8C7B0-0x0000000186D8C8F0
		private void Sequence_HorizontalSlash() {} // 0x0000000186D8C8F0-0x0000000186D8CAC0
		private void Sequence_ThrowMoon() {} // 0x0000000186D8CAC0-0x0000000186D8CD60
		private void DoSlash(ParticleSystem slash, MeshRenderer meshRen, MaterialPropertyBlock block, MeshRenderer lightBeamMeshRen, MaterialPropertyBlock lightBeamBlock, bool finalSlash = false /* Metadata: 0x01977852 */) {} // 0x0000000186D8CD60-0x0000000186D8CEB0
		private void SetSlashPropBlock(MeshRenderer mesh, MaterialPropertyBlock block, float amount) {} // 0x0000000186D8CEB0-0x0000000186D8D040
		[IteratorStateMachine(typeof(_DoSlash_d__47))]
		private IEnumerator<YieldInstruction> DoSlash(MeshRenderer meshRen, MaterialPropertyBlock block, MeshRenderer lightBeamMeshRen, MaterialPropertyBlock lightBeamBlock) => default; // 0x0000000186D8D040-0x0000000186D8D250
		private void SpawnMoonProjectile() {} // 0x0000000186D8D250-0x0000000186D8D410
		private void UpwardsSlashHitBox() {} // 0x0000000186D8D410-0x0000000186D8D610
		private void DownwardsSlashHitBox() {} // 0x0000000186D8D610-0x0000000186D8D810
		private void HorizontalSlashHitBox() {} // 0x0000000186D8D810-0x0000000186D8DA10
		private void ScaleMoonWhenSlashed(float duration, float scaleModifier = 1.1f /* Metadata: 0x01977853 */, bool yoyo = true /* Metadata: 0x01977857 */) {} // 0x0000000186D8DA10-0x0000000186D8DC60
		private void PlaySfxSequence() {} // 0x0000000186D8DC60-0x0000000186D8DD70
		private void PlaySfx(SfxType sfxType) {} // 0x0000000186D8DD70-0x0000000186D8DE40
		public override void Despawn() {} // 0x0000000186D8DE40-0x0000000186D8DEE0
	}
}

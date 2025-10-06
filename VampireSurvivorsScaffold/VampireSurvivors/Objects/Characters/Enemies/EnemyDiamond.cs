/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDiamond : EnemyController // TypeDefIndex: 17292
	{
		// Fields
		public float selfDuration; // 0x270
		public int gridX; // 0x274
		public int gridY; // 0x278
		protected int _hitsTaken; // 0x27C
		protected bool _isInvul; // 0x280
		protected bool _canBreak; // 0x281
		protected MultiTargetTween _onEnterTween; // 0x288
		protected float _selfTime; // 0x290
		protected string _defaultFrame; // 0x298
		protected string[] _availableFrames; // 0x2A0
	
		// Properties
		protected virtual bool UseStandardLootTable { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual float InvulDelay { get => default; } // 0x0000000186D7E010-0x0000000186D7E020 
		protected virtual float ItemChance { get => default; } // 0x00000001872415B0-0x00000001872415C0 
		protected virtual float Volume_breaking { get => default; } // 0x00000001872415C0-0x00000001872415D0 
		protected virtual float Volume_gotHit { get => default; } // 0x00000001865DB540-0x00000001865DB550 
		protected virtual SfxType Sfx_breaking { get => default; } // 0x0000000181B99450-0x0000000181B99460 
		protected virtual SfxType Sfx_gotHit { get => default; } // 0x0000000181BE95A0-0x0000000181BE95B0 
		protected virtual bool IsImmovable { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual bool ChangeFramesOnHit { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual bool DoBaseUpdate { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual string _textureName { get => default; } // 0x00000001872415D0-0x0000000187241610 
		protected virtual string DefaultFrame { get => default; set {} } // 0x0000000186A13420-0x0000000186A13430 0x0000000186A13430-0x0000000186A13490
		protected virtual string[] AvailableFrames { get => default; set {} } // 0x0000000185EAA030-0x0000000185EAA040 0x0000000186AB2660-0x0000000186AB26C0
	
		// Constructors
		public EnemyDiamond() {} // 0x00000001872427E0-0x00000001872429F0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187241610-0x00000001872419C0
		public virtual void OnSpawnDone() {} // 0x0000000180B15170-0x0000000180B15180
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019783F0 */, float damageKb = 1f /* Metadata: 0x019783F1 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019783F5 */, bool hasKb = true /* Metadata: 0x019783F6 */) {} // 0x00000001872419C0-0x0000000187241AF0
		public override void GetDamagedSpecial(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019783F7 */, float damageKb = 1f /* Metadata: 0x019783F8 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019783FC */, bool hasKb = true /* Metadata: 0x019783FD */, Vector3? damagePosition = default) {} // 0x0000000187241AF0-0x0000000187241C20
		protected virtual void ChangeFrame() {} // 0x0000000187241C20-0x0000000187241F60
		protected override void OnUpdate() {} // 0x0000000187241F60-0x0000000187242010
		protected override void Die() {} // 0x0000000187242010-0x0000000187242140
		private void StandardLoot() {} // 0x0000000187242140-0x00000001872424A0
		protected virtual void CustomLoot() {} // 0x00000001872424A0-0x00000001872427C0
		public override void Disappear() {} // 0x00000001872427C0-0x00000001872427E0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Loot;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyGemstone : EnemyDiamond // TypeDefIndex: 17324
	{
		// Fields
		[SerializeField]
		private GameObject _MeshContainer; // 0x2A8
		[SerializeField]
		private List<MeshRenderer> _GemMeshes; // 0x2B0
		[SerializeField]
		protected Transform gemTransform; // 0x2B8
		[SerializeField]
		protected MeshRenderer gemMesh; // 0x2C0
		private static WeightedStore WEIGHTEDSTORE; // 0x00
		private Tween _angleTween; // 0x2C8
		private uint[] _initialTints; // 0x2D0
		private TweenerCore<Vector3, Vector3, VectorOptions> _scaleTween; // 0x2D8
		private const float MinRotateDuration = 2f; // Metadata: 0x01978444
		private const float MaxRotateDuration = 3f; // Metadata: 0x01978448
	
		// Properties
		protected override bool UseStandardLootTable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override float InvulDelay { get => default; } // 0x000000018726B6C0-0x000000018726B6D0 
		protected override float ItemChance { get => default; } // 0x00000001872415B0-0x00000001872415C0 
		protected override float Volume_breaking { get => default; } // 0x00000001872437B0-0x00000001872437C0 
		protected override float Volume_gotHit { get => default; } // 0x00000001872437C0-0x00000001872437D0 
		protected override SfxType Sfx_breaking { get => default; } // 0x0000000181B99450-0x0000000181B99460 
		protected override SfxType Sfx_gotHit { get => default; } // 0x0000000181BE95A0-0x0000000181BE95B0 
		protected override bool ChangeFramesOnHit { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool DoBaseUpdate { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool IsImmovable { get => default; } // 0x0000000181958370-0x0000000181958380 
		protected virtual bool IsAxe { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual bool IsSnake { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected virtual uint[] TintProgression { get => default; } // 0x000000018726B6D0-0x000000018726B740 
	
		// Constructors
		public EnemyGemstone() {} // 0x000000018726D6E0-0x000000018726D7B0
	
		// Methods
		public void InitRotation() {} // 0x000000018726B740-0x000000018726BB30
		public void RandomColor() {} // 0x000000018726BB30-0x000000018726BCD0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018726BCD0-0x000000018726C8A0
		public override void OnSpawnDone() {} // 0x0000000187243BC0-0x0000000187243C20
		public override void Disappear() {} // 0x000000018726C8A0-0x000000018726C9C0
		protected override void ChangeFrame() {} // 0x000000018726C9C0-0x000000018726D290
		protected override void OnUpdate() {} // 0x000000018726D290-0x000000018726D2C0
		protected override void CustomLoot() {} // 0x000000018726D2C0-0x000000018726D6E0
	}
}

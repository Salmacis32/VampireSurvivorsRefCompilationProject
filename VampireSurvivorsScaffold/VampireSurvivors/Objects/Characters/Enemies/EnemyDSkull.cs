/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDSkull : EnemyDMask // TypeDefIndex: 17313
	{
		// Fields
		[SerializeField]
		private PhaserSprite _EyesSprite; // 0x280
		private MultiTargetTween _eyesFadeTween; // 0x288
		private MultiTargetTween _onEnterTween; // 0x290
	
		// Properties
		[Sync]
		public string EyesSprite { get => default; set {} } // 0x00000001872601C0-0x0000000187260200 0x0000000187260200-0x0000000187260280
		[Sync]
		public bool FlipX { get => default; set {} } // 0x0000000187260280-0x0000000187260320 0x000000018718CC20-0x000000018718CC40
	
		// Constructors
		public EnemyDSkull() {} // 0x000000018725A5D0-0x000000018725A620
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000187260320-0x0000000187260570
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187260570-0x0000000187260990
		public override void Despawn() {} // 0x0000000187260990-0x00000001872609E0
		public void SetEyes(string frameName = null) {} // 0x0000000187260200-0x0000000187260280
		protected override void UpdateDepth() {} // 0x00000001872609E0-0x0000000187260AA0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Graphics;
using VampireSurvivors.Graphics.RenderPass;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class BackgroundWater : BackgroundManager // TypeDefIndex: 15315
	{
		// Fields
		private bool _canTriggerEclipse; // 0x80
		private SpriteRenderer _water; // 0x88
		private TileSprite _bgTile; // 0x90
		private SpriteRenderer _moonPresence; // 0x98
		private SpriteRenderer _fader; // 0xA0
		private SpriteRenderer _sDarkness; // 0xA8
		private FishEyeRenderFeature _fishEyeRenderFeature; // 0xB0
		private VampireSurvivors.Framework.TimerSystem.Timer _destructibleTimer; // 0xB8
		private DG.Tweening.Sequence _waterBgmTween; // 0xC0
		private static readonly int Intensity; // 0x00
		private static readonly int Radius; // 0x04
		private static readonly int Mode; // 0x08
		private static readonly int TexSize; // 0x0C
		private static readonly int Center; // 0x10
	
		// Constructors
		public BackgroundWater() {} // 0x0000000186A94680-0x0000000186A94690
		static BackgroundWater() {} // 0x0000000186B690F0-0x0000000186B69210
	
		// Methods
		protected override void OnUpdate() {} // 0x0000000186B64180-0x0000000186B643B0
		protected override void OnDestroy() {} // 0x0000000186B643B0-0x0000000186B64750
		public override void Create() {} // 0x0000000186B64750-0x0000000186B65D80
		private void OnRemoteEnemySpawned(EnemyController enemy) {} // 0x0000000186B65D80-0x0000000186B65F40
		[IteratorStateMachine(typeof(_InitFishEye_d__18))]
		private IEnumerator InitFishEye() => default; // 0x0000000186B65F40-0x0000000186B65FE0
		private void CharacterDied() {} // 0x0000000186B65FE0-0x0000000186B66000
		private void RestoreEclipse() {} // 0x0000000186B66000-0x0000000186B66630
		private void RemoveEclipse() {} // 0x0000000186B66630-0x0000000186B66C20
		private void SpawnHealer() {} // 0x0000000186B66C20-0x0000000186B66F10
		private void SpawnEggman() {} // 0x0000000186B66F10-0x0000000186B671A0
		private void StartEclipse() {} // 0x0000000186B671A0-0x0000000186B67880
		private void Cry() {} // 0x0000000186B67880-0x0000000186B67DB0
		private void SendToHiddenGround() {} // 0x0000000186B67DB0-0x0000000186B68850
		public void TransitionToHolyForbidden() {} // 0x0000000186B68850-0x0000000186B68AE0
		private void SpawnAnforaCluster() {} // 0x0000000186B68AE0-0x0000000186B68C10
		private Vector2 GetPositionOutOfSight(float inPlayerDirectionAngle) => default; // 0x0000000186B68C10-0x0000000186B68F10
		public override void DisableMovingBackground() {} // 0x0000000186B68F10-0x0000000186B69000
		public override void EnableMovingBackground() {} // 0x0000000186B69000-0x0000000186B690F0
	}
}

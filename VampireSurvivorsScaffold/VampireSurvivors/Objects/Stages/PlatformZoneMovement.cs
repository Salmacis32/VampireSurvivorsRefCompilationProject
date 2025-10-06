/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Framework.Geom;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[DefaultExecutionOrder(899)]
	public class PlatformZoneMovement : GameMonoBehaviour // TypeDefIndex: 15349
	{
		// Fields
		private List<StageEdge> _stageEdges; // 0x28
		private ParticleEmitterManager _pfxEmitterManager; // 0x30
		private ParticleSystem _smokeEmitter; // 0x38
		private List<JumpInfo> _characterInfo; // 0x40
		private bool _limitCameraPosition; // 0x48
		private bool _blendAfterCameraLimitsDisabled; // 0x49
		private Vector2 _cameraBlendVelocity; // 0x4C
		private float _cameraXVelocity; // 0x54
		private float _cameraYVelocity; // 0x58
		private CoherenceSync _sync; // 0x60
		public float? MinCameraX; // 0x6C
		public float? MinCameraY; // 0x74
		public float? MaxCameraX; // 0x7C
		public float? MaxCameraY; // 0x84
	
		// Properties
		public List<StageEdge> StageEdges { get => default; } // 0x0000000180B15540-0x0000000180B15550 
		public static PlatformZoneMovement Instance { get; private set; } // 0x0000000186B8E140-0x0000000186B8E180 0x0000000186B8E180-0x0000000186B8E220
		public bool MoveCameraInsideLimitsOnLimitsEnabled { get; set; } // 0x0000000183D894D0-0x0000000183D894E0 0x0000000183D894E0-0x0000000183D894F0
		public bool LimitCameraPosition { get => default; set {} } // 0x00000001826F3EE0-0x00000001826F3EF0 0x0000000186B91990-0x0000000186B919C0
	
		// Nested types
		public class JumpInfo // TypeDefIndex: 15346
		{
			// Fields
			public float _fallingTimer; // 0x10
			public bool _hasJumped; // 0x14
	
			// Constructors
			public JumpInfo() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		public struct ClosestEdge // TypeDefIndex: 15347
		{
			// Fields
			public StageEdge _edge; // 0x00
			public float2 _point; // 0x08
			public float _distSqrd; // 0x10
			public float _yDistance; // 0x14
		}
	
		// Constructors
		public PlatformZoneMovement() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		public void SetCameraLimits(Rectangle cameraLimitsRectangle) {} // 0x0000000186B8E220-0x0000000186B8E400
		private new void Awake() {} // 0x0000000186B8E400-0x0000000186B8E5A0
		protected override void OnDestroy() {} // 0x0000000186B8E5A0-0x0000000186B8E8C0
		protected override void OnUpdate() {} // 0x0000000180B15170-0x0000000180B15180
		private void LateUpdate() {} // 0x0000000186B8E8C0-0x0000000186B8E8D0
		public void LoadStageEdges(PolygonGroupComponent polygonGroup) {} // 0x0000000186B8E8D0-0x0000000186B8F070
		private ClosestEdge FindClosestEdge(float2 position, float rangeSqrd = 3.4028235E+38f /* Metadata: 0x01977599 */, bool includeFalling = false /* Metadata: 0x0197759D */) => default; // 0x0000000186B8F070-0x0000000186B8F3F0
		public ClosestEdge FindClosestWalkableEdgeBelow(float2 position) => default; // 0x0000000186B8F3F0-0x0000000186B8F7C0
		private void RunEdgeLogic() {} // 0x0000000186B8F7C0-0x0000000186B8FC30
		public bool IsInFallZone(float2 position) => default; // 0x0000000186B8FC30-0x0000000186B8FDC0
		public float2 ApplyMovement(ArcadeSprite character, JumpInfo info, float2 lastFacingDirection, bool tryingToJump) => default; // 0x0000000186B8FDC0-0x0000000186B90BD0
		private void TriggerSmokeEmitter(Vector2 position, int count) {} // 0x0000000186B90BD0-0x0000000186B90D80
		[Command]
		public void ActivateSmokeEmitter(Vector2 position, int count) {} // 0x0000000186B90D80-0x0000000186B90E00
		private void LockToEdge(ArcadeSprite character, JumpInfo info, StageEdge edge, float2 lastFacingDirection) {} // 0x0000000186B90E00-0x0000000186B90F70
		private void InitJumpParticles() {} // 0x0000000186B90F70-0x0000000186B91980
		private void UpdateCameraTarget() {} // 0x0000000186B91980-0x0000000186B91990
		private void ActualUpdateCameraTarget() {} // 0x0000000186B919C0-0x0000000186B92B40
	}
}

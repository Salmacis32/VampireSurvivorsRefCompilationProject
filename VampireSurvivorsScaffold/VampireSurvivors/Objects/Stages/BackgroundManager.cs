/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundManager : GameMonoBehaviour // TypeDefIndex: 15295
	{
		// Fields
		protected Camera _mainCamera; // 0x28
		public Bounds _camBounds; // 0x30
		protected SignalBus _signalBus; // 0x48
		protected float _pickupLimitX; // 0x54
		protected float _pickupRecycleOffset; // 0x58
		public float RacingBoundsMinY; // 0x5C
		public float RacingBoundsMaxY; // 0x60
		public float RacingBoundsFlyingEnemiesY; // 0x64
		public float CharmMod; // 0x68
		public float CurseMod; // 0x6C
		public Stack<SuperTile> dynamicWallTiles; // 0x78
	
		// Properties
		private bool IsBackgroundActive { get; set; } // 0x000000018264AE80-0x000000018264AE90 0x00000001841A6E80-0x00000001841A6E90
		public bool Alias { get; protected set; } // 0x00000001848FA660-0x00000001848FA670 0x0000000185E0DBC0-0x0000000185E0DBD0
		public bool HasMovingBg { get; protected set; } // 0x0000000185479BF0-0x0000000185479C00 0x0000000185E0DBD0-0x0000000185E0DBE0
		public bool DisableMovingBg { get; set; } // 0x0000000185E0DBE0-0x0000000185E0DBF0 0x0000000185E0DBF0-0x0000000185E0DC00
		public PhaserScene scene { get => default; } // 0x0000000186B4CEA0-0x0000000186B4CF20 
		public virtual bool SpawnEnemiesOnStart { get => default; } // 0x0000000181958370-0x0000000181958380 
		public int xxlBatsDefeated { get; set; } // 0x00000001819A0220-0x00000001819A0230 0x0000000181B5A2A0-0x0000000181B5A2B0
	
		// Constructors
		public BackgroundManager() {} // 0x0000000186B4EDE0-0x0000000186B4EF00
	
		// Methods
		public virtual new void Awake() {} // 0x0000000186B4CF20-0x0000000186B4CFF0
		protected override void OnDestroy() {} // 0x0000000186B4CFF0-0x0000000186B4D090
		protected override void OnUpdate() {} // 0x0000000186B4D090-0x0000000186B4D110
		public virtual void Create() {} // 0x0000000186B4D110-0x0000000186B4D230
		public virtual void OnInitCompleted() {} // 0x0000000186B4D230-0x0000000186B4D310
		public virtual void CustomPreload(Action onComplete) {} // 0x0000000184F92570-0x0000000184F92590
		public virtual void Cleanup() {} // 0x0000000185DED600-0x0000000185DED610
		public virtual void RosaryTriggered() {} // 0x0000000180B15170-0x0000000180B15180
		private void ToggleMovingBackground(UISignals.ToggleMovingBackgroundSignal sig) {} // 0x0000000186B4D310-0x0000000186B4D340
		private void HandleDisableMovingBackground() {} // 0x0000000186B4D340-0x0000000186B4D370
		public virtual void CheckMinute(int minute) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void DisableMovingBackground() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void EnableMovingBackground() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void CheckHalfMinute() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnPropTriggered(PropType propType, PizzaCircle pizzaCircle, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnItemTriggered(VampireSurvivors.Data.ItemType itemType, Pickup pickup, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnPlayerEnteringDifferentTilemap() {} // 0x0000000180B15170-0x0000000180B15180
		public void ResetPickupPositions() {} // 0x0000000186B4D370-0x0000000186B4D790
		public virtual void LoopPickupPositions() {} // 0x0000000186B4D790-0x0000000186B4DBA0
		public virtual void InitPickupForLoopingStage(Pickup pickup) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual string GetDetailedMap(StageData stageData) => default; // 0x0000000186B4DBA0-0x0000000186B4DBC0
		public virtual string GetDetailedMapStaticBackgroundImage(StageData stageData) => default; // 0x0000000186B4DBC0-0x0000000186B4DC00
		public virtual void SetupDarknessFog(ref PhaserSprite fog, ref PhaserSprite fogEdgeA, ref PhaserSprite fogEdgeB) {} // 0x0000000186B4DC00-0x0000000186B4E6C0
		public void ContainWithinRacingBounds(Transform target) {} // 0x0000000186B4E6C0-0x0000000186B4E850
		public virtual bool ShouldPlayNormalMusic() => default; // 0x0000000181958370-0x0000000181958380
		public virtual void OnFollowerAdded(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual float GetKillRatio() => default; // 0x0000000186B4E850-0x0000000186B4E8E0
		public virtual bool ShouldShowCursor(float2 position) => default; // 0x0000000181958370-0x0000000181958380
		public virtual bool HasCustomMapRules() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual bool HasCustomMadGrooveRestriction() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual bool IsPositionPulledByMadGroove(float2 position) => default; // 0x0000000181958370-0x0000000181958380
		public virtual bool HasExtraSafeXYLogic() => default; // 0x0000000180B15290-0x0000000180B152A0
		public virtual float2 ExtraSafeXY(float2 position, float2 playerPosition) => default; // 0x00000001826F2060-0x00000001826F2070
		public virtual float GetMap_SizeX() => default; // 0x0000000186B27130-0x0000000186B27140
		public virtual float GetMap_SizeY() => default; // 0x0000000186B27130-0x0000000186B27140
		public virtual float2 GetMap_PlayerPos() => default; // 0x0000000186B4E8E0-0x0000000186B4EA80
		public virtual int GetMap_SupportHorizontal() => default; // 0x0000000180B15D70-0x0000000180B15D80
		public virtual bool GetMap_DrawGrid() => default; // 0x0000000181958370-0x0000000181958380
		public virtual bool ShouldShowPickupIconOnMap(Vector3 worldPosition) => default; // 0x0000000181958370-0x0000000181958380
		public Vector2 GetPlayerStartingPosition() => default; // 0x0000000186B4EA80-0x0000000186B4EDE0
	}
}

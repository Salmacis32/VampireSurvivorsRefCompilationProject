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
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Items;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Objects.Props;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundLaborratory : BackgroundManager // TypeDefIndex: 15294
	{
		// Fields
		private float2 _TrainCoords; // 0x80
		private List<Vector2> _leverLocations; // 0x88
		private List<Vector2> _leverLocations2; // 0x90
		private List<Vector2> _leverLocations3; // 0x98
		private List<Vector2> _leverLocations4; // 0xA0
		private List<SuperObject> _doorScriptsA; // 0xA8
		private List<SuperObject> _doorScriptsB; // 0xB0
		private List<Vector2> _doorLocationsA; // 0xB8
		private List<Vector2> _doorLocationsB; // 0xC0
		private List<PropLeverTrain> _AllLevers; // 0xC8
		private List<Destructible> _AllDoors; // 0xD0
		private VampireSurvivors.Framework.TimerSystem.Timer _checkLeversTimer; // 0xD8
		private TilingTileset _tilingTileset; // 0xE0
		private List<Destructible> _spawnedLevers; // 0xE8
		private VampireSurvivors.Framework.TimerSystem.Timer _trainLeversTimer; // 0xF8
		private float _trainLeversFrequency; // 0x100
		private float _leverChance; // 0x104
		private VampireSurvivors.Framework.TimerSystem.Timer _itemLeversTimer; // 0x108
		private float _lever2Chance; // 0x110
		private float _lever3Chance; // 0x114
		private float _lever4Chance; // 0x118
		private float _leverMaxSuccessRate; // 0x11C
		private float _leverDefaultSuccessRate; // 0x120
		private int _centralLeverPulledTimes; // 0x124
		private VampireSurvivors.Data.Stage.Event Event_YellowReapers; // 0x128
		private VampireSurvivors.Data.Stage.Event Event_ExplodingAngels; // 0x130
		private VampireSurvivors.Data.Stage.Event Event_Trinacrias; // 0x138
		private VampireSurvivors.Data.Stage.Event Event_EyeSwarm; // 0x140
		private List<EnemyType> MinorEvent_EnemyTypes; // 0x148
		private List<VampireSurvivors.Data.Stage.Event> SpecialEvent_Types; // 0x150
	
		// Properties
		public TrainHazardWeapon TrainWeapon { get; set; } // 0x00000001819716C0-0x00000001819716D0 0x0000000180B3E860-0x0000000180B3E8C0
	
		// Constructors
		public BackgroundLaborratory() {} // 0x0000000186B4C600-0x0000000186B4CD30
	
		// Methods
		public override void Awake() {} // 0x0000000186B474A0-0x0000000186B48230
		public override void Create() {} // 0x0000000186B48230-0x0000000186B48CF0
		public override void OnPropTriggered(PropType propType, PizzaCircle pizzaCircle, VampireSurvivors.Objects.Characters.CharacterController player) {} // 0x0000000186B48CF0-0x0000000186B49C90
		public void ManageSpawning(ref List<WeaponType> weaponChoice, ref List<VampireSurvivors.Data.ItemType> itemChoice, ref List<EnemyType> enemyChoice, ref PizzaCircle pizzaCircle, bool specialEvents = false /* Metadata: 0x019774D7 */) {} // 0x0000000186B49C90-0x0000000186B4B120
		public void ManageGuardians(PickupGuarded pickupGuard, WeaponType wType) {} // 0x0000000186B4B120-0x0000000186B4B1F0
		public override void OnInitCompleted() {} // 0x0000000186B4B1F0-0x0000000186B4B410
		private void TryToSpawnTrainLevers() {} // 0x0000000186B4B410-0x0000000186B4B490
		private void TryToSpawnLabLevers() {} // 0x0000000186B4B490-0x0000000186B4B9A0
		private void SeparateLevers() {} // 0x0000000186B4B9A0-0x0000000186B4BF10
		private void TryToSpawnDoors() {} // 0x0000000186B4BF10-0x0000000186B4C060
		private void SeparateDoors() {} // 0x0000000186B4C060-0x0000000186B4C590
		public override void OnPlayerEnteringDifferentTilemap() {} // 0x0000000186B4C590-0x0000000186B4C5B0
		protected override void OnUpdate() {} // 0x0000000186B4C5B0-0x0000000186B4C5C0
		public override void Cleanup() {} // 0x0000000186B4C5C0-0x0000000186B4C600
	}
}

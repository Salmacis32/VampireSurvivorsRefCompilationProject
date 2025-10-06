/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyCrab : EnemyController // TypeDefIndex: 17287
	{
		// Fields
		[SerializeField]
		private GameObject _RedWarningPrefab; // 0x270
		[SerializeField]
		private GameObject _SingleWarningPrefab; // 0x278
		private VampireSurvivors.Objects.Stage _stage; // 0x280
		protected EnemyPincer _leftPincer; // 0x288
		protected EnemyPincer _rightPincer; // 0x290
		private EnemyDrowner _drowner; // 0x298
		protected VampireSurvivors.Framework.TimerSystem.Timer _leftEvent; // 0x2A0
		protected VampireSurvivors.Framework.TimerSystem.Timer _rightEvent; // 0x2A8
		private bool _isPlayerBelow; // 0x2B0
		private bool _drownerSummoned; // 0x2B1
		private bool _freshlySpawned; // 0x2B2
		private Vector2 _leftPincerPos; // 0x2B4
		private Vector2 _rightPincerPos; // 0x2BC
		private readonly Vector2 _leftOffset; // 0x2C4
		private readonly Vector2 _rightOffset; // 0x2CC
		private const float PincerRespawnDelayLeft = 1500f; // Metadata: 0x019783DD
		private const float PincerRespawnDelayRight = 1500f; // Metadata: 0x019783E1
		private const float SummonDelay = 6000f; // Metadata: 0x019783E5
		private VampireSurvivors.Framework.TimerSystem.Timer _summonDelayTimer; // 0x2D8
		private VampireSurvivors.Framework.TimerSystem.Timer _drownerWarningTimer1; // 0x2E0
		private VampireSurvivors.Framework.TimerSystem.Timer _drownerWarningTimer2; // 0x2E8
		private VampireSurvivors.Framework.TimerSystem.Timer _drownerWarningTimer3; // 0x2F0
	
		// Constructors
		public EnemyCrab() {} // 0x000000018723E2A0-0x000000018723E320
	
		// Methods
		protected override void FakeConstruct() {} // 0x000000018723A320-0x000000018723A3D0
		protected override void Awake() {} // 0x000000018723A3D0-0x000000018723A3E0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018723A3E0-0x000000018723A530
		protected override void OnUpdate() {} // 0x000000018723A530-0x000000018723AFF0
		public override void Despawn() {} // 0x000000018723AFF0-0x000000018723B2F0
		public override bool CanEnemyTeleport() => default; // 0x000000018723B2F0-0x000000018723B8B0
		private async UniTaskVoid SpawnPincers() => default; // 0x000000018723B8B0-0x000000018723B9F0
		private void SpawnLeftPincer() {} // 0x000000018723B9F0-0x000000018723BE20
		private void SpawnRightPincer() {} // 0x000000018723BE20-0x000000018723C250
		protected virtual void RegrowLeftPincer() {} // 0x000000018723C250-0x000000018723C580
		protected virtual void RegrowRightPincer() {} // 0x000000018723C580-0x000000018723C8B0
		protected virtual void SummonDrowner() {} // 0x000000018723C8B0-0x000000018723CA60
		private void DismissDrowner() {} // 0x000000018723CA60-0x000000018723CB60
		private void DrownerWarning() {} // 0x000000018723CB60-0x000000018723CF30
		private void RedWarning() {} // 0x000000018723CF30-0x000000018723DAB0
		private void SingleWarning(float sizeX) {} // 0x000000018723DAB0-0x000000018723E2A0
	}
}

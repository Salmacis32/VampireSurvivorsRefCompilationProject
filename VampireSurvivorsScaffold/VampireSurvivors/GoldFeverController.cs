/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Pickups;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class GoldFeverController : GameTickable, IInitializable, IDisposable // TypeDefIndex: 13930
	{
		// Fields
		[Inject]
		private SignalBus _signalBus; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private GameManager _gameManager; // 0x20
		[Inject]
		private DataManager _dataManager; // 0x28
		[Inject]
		private GameSessionData _session; // 0x30
		[Inject]
		private ArcanaManager _arcanas; // 0x38
		private bool _isActive; // 0x40
		private float _totalTime; // 0x44
		private float _durationInMS; // 0x48
		private float _durationCap; // 0x4C
		private float _defaultCap; // 0x50
		private float _totalDuration; // 0x54
		private List<float> _randoms; // 0x58
		private int _randomIndex; // 0x60
		private float _total; // 0x64
		private float _redu; // 0x68
		private bool _isFake; // 0x6C
	
		// Constructors
		public GoldFeverController() {} // 0x00000001865CEB10-0x00000001865CEBD0
	
		// Methods
		public void Initialize() {} // 0x00000001865CD4C0-0x00000001865CD850
		public void Dispose() {} // 0x00000001865CD850-0x00000001865CDA60
		protected override void OnTick() {} // 0x00000001865CDA60-0x00000001865CDCA0
		public bool IsFake() => default; // 0x0000000185267770-0x0000000185267780
		public float GetScaleFactor() => default; // 0x00000001865CDCA0-0x00000001865CDD00
		public float GetProgress() => default; // 0x00000001865CDD00-0x00000001865CDD10
		public float GetDuration() => default; // 0x0000000184C564B0-0x0000000184C564C0
		public int GetTotalCoins() => default; // 0x00000001865CDD10-0x00000001865CDD60
		public void OnCoinPickup(Pickup c) {} // 0x00000001865CDD60-0x00000001865CE070
		private void CheckResults() {} // 0x00000001865CE070-0x00000001865CE130
		private void OnEnemyDeath(GameplaySignals.EnemyKilledImmediateSignal sig) {} // 0x00000001865CE130-0x00000001865CE5C0
		private float GetHighestFeverBonus() => default; // 0x00000001865CE5C0-0x00000001865CE810
		private void StartGoldFever(UISignals.GoldFeverStartedSignal sig) {} // 0x00000001865CE810-0x00000001865CEA70
		private void EndGoldFever() {} // 0x00000001865CEA70-0x00000001865CEA80
		private float GetRandom() => default; // 0x00000001865CEA80-0x00000001865CEB10
	}
}

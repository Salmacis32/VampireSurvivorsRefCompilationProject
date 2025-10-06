/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	[UsedImplicitly]
	public class PlayerStats : IInitializable, IDisposable // TypeDefIndex: 13910
	{
		// Fields
		[Inject]
		private DataManager _dataManager; // 0x10
		[Inject]
		private PlayerOptions _playerOptions; // 0x18
		[Inject]
		private SignalBus _signalBus; // 0x20
		private int _totalPowerUpCount; // 0x28
		private readonly Dictionary<PowerUpType, PlayerStat> _stats; // 0x30
	
		// Properties
		public double PowerUpMarkUp { get => default; } // 0x00000001865BFCB0-0x00000001865BFED0 
	
		// Constructors
		public PlayerStats() {} // 0x00000001865C1660-0x00000001865C1720
	
		// Methods
		public void Initialize() {} // 0x00000001865BFED0-0x00000001865C0150
		public void Dispose() {} // 0x00000001865C0150-0x00000001865C03D0
		public void InitStats() {} // 0x00000001865C03D0-0x00000001865C06D0
		public float GetRefundAmount() => default; // 0x00000001865C06D0-0x00000001865C0710
		public float GetPrice(PowerUpType t) => default; // 0x00000001865C0710-0x00000001865C0840
		public void Reset() {} // 0x00000001865C0840-0x00000001865C09C0
		public Dictionary<PowerUpType, PlayerStat> GetOwnedPowerUps() => default; // 0x00000001865C09C0-0x00000001865C0C30
		public Dictionary<PowerUpType, PlayerStat> GetAllPowerUps() => default; // 0x0000000180B15550-0x0000000180B15560
		private double ApplyMarkup(float value) => default; // 0x00000001865C0C30-0x00000001865C0CA0
		private float GetTotalMarkup() => default; // 0x00000001865C0CA0-0x00000001865C0FF0
		private float GetTotalPrice() => default; // 0x00000001865C0FF0-0x00000001865C11F0
		private void AddStat(PowerUpType type, int level, List<PowerUpData> data) {} // 0x00000001865C11F0-0x00000001865C1300
		private void Refresh() {} // 0x00000001865C1300-0x00000001865C14D0
		private void ResetPowerUps() {} // 0x00000001865C14D0-0x00000001865C1660
	}
}

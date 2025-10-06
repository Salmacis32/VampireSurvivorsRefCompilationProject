/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using VampireSurvivors.Objects.Pickups;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class Background3 : BackgroundManager // TypeDefIndex: 15209
	{
		// Fields
		private int _bossesDefeated; // 0x80
		private bool _awarded; // 0x84
		private const int BOSSES_TO_DEFEAT = 7; // Metadata: 0x0197745D
	
		// Constructors
		public Background3() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		public override void Awake() {} // 0x0000000186A98A90-0x0000000186A98B10
		public override void Create() {} // 0x0000000186A98B10-0x0000000186A98ED0
		private void OnPickupCallback(Pickup item) {} // 0x0000000186A98ED0-0x0000000186A99020
		private void SpawnWerewolves(Vector2 pos) {} // 0x0000000186A99020-0x0000000186A99350
		private void OnDefeated() {} // 0x0000000186A99350-0x0000000186A994B0
		public void AwardGRAZIELLAUnlock() {} // 0x0000000186A994B0-0x0000000186A99960
	}
}

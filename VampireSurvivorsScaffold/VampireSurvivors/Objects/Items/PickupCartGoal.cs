/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCartGoal : NetworkPickup // TypeDefIndex: 16036
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _selfCleanTimer; // 0x170
		private MultiTargetTween _tween1; // 0x178
		private bool AlreadyTaken; // 0x180
	
		// Constructors
		public PickupCartGoal() {} // 0x0000000186EB9C10-0x0000000186EB9C20
	
		// Methods
		[Inject]
		private void Construct(GameSessionData gameSessionData) {} // 0x0000000181917690-0x00000001819176F0
		protected override void Awake() {} // 0x0000000186EBC1C0-0x0000000186EBC200
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EBC200-0x0000000186EBC220
		public override void UpdateDepth() {} // 0x0000000186EBC1B0-0x0000000186EBC1C0
		public override void InternalUpdate() {} // 0x0000000186EBC220-0x0000000186EBC3E0
		private void OnRecycle() {} // 0x0000000186EBC3E0-0x0000000186EBC630
		private void SelfClean() {} // 0x0000000186EBC630-0x0000000186EBC7C0
		public override void GetTaken() {} // 0x0000000186EBC7C0-0x0000000186EBC980
		private void TakenTween() {} // 0x0000000186EBC980-0x0000000186EBCC30
		private void TryTrigger() {} // 0x0000000186EBCC30-0x0000000186EBCDA0
	}
}

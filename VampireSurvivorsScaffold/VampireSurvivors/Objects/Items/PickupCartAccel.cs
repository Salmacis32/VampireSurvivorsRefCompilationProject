/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class PickupCartAccel : NetworkPickup // TypeDefIndex: 16035
	{
		// Fields
		private VampireSurvivors.Framework.TimerSystem.Timer _selfCleanTimer; // 0x170
	
		// Constructors
		public PickupCartAccel() {} // 0x0000000186EB9C10-0x0000000186EB9C20
	
		// Methods
		[Inject]
		private void Construct(GameSessionData gameSessionData) {} // 0x0000000181917690-0x00000001819176F0
		protected override void Awake() {} // 0x0000000186EBBA20-0x0000000186EBBA60
		public override void SetData(VampireSurvivors.Data.ItemType itemType) {} // 0x0000000186EBBA60-0x0000000186EBBA80
		private void OnRecycle() {} // 0x0000000186EBBA80-0x0000000186EBBD10
		private void SelfClean() {} // 0x0000000186EBBD10-0x0000000186EBBEA0
		public override void GetTaken() {} // 0x0000000186EBBEA0-0x0000000186EBC040
		private void TryAccelerate() {} // 0x0000000186EBC040-0x0000000186EBC1B0
		public override void UpdateDepth() {} // 0x0000000186EBC1B0-0x0000000186EBC1C0
	}
}

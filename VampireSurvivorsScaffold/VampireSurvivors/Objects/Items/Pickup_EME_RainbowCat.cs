/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Items
{
	public class Pickup_EME_RainbowCat : Pickup_EME_Cat // TypeDefIndex: 16072
	{
		// Fields
		private List<Sprite> _idleAnimation; // 0x1D8
		private const string BlackIdle = "eme_cat_black_i04"; // Metadata: 0x01977AFE
		private const string RedIdle = "eme_cat_red_i04"; // Metadata: 0x01977B10
		private const string YellowIdle = "eme_cat_yellow_i04"; // Metadata: 0x01977B20
		private const string BlueIdle = "eme_cat_blue_i04"; // Metadata: 0x01977B33
	
		// Constructors
		public Pickup_EME_RainbowCat() {} // 0x0000000186EE01C0-0x0000000186EE02A0
	
		// Methods
		protected override VampireSurvivors.Data.ItemType GetCatType() => default; // 0x0000000181BC6AB0-0x0000000181BC6AC0
		protected override void GetCatAnimations(out List<Sprite> idle, out List<Sprite> flee, out List<Sprite> dragged) {
			idle = default;
			flee = default;
			dragged = default;
		} // 0x0000000186EE0540-0x0000000186EE08D0
		protected override void OnCatPickedUp() {} // 0x0000000186EE08D0-0x0000000186EE0B10
	}
}

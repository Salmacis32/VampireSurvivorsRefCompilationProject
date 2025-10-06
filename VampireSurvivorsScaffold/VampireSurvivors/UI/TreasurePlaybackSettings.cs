/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	[Serializable]
	public class TreasurePlaybackSettings // TypeDefIndex: 14887
	{
		// Fields
		public List<ParticleSystem> Coins; // 0x10
		public List<UISplineFollower> Paths; // 0x18
		public List<TreasureReelUI> Reels; // 0x20
		public int RibbonAmount; // 0x28
		public int RibbonLoopAmount; // 0x2C
		public float CoinTweenDuration; // 0x30
		public float MultiplayerRandomCycleDuration; // 0x34
		public float SkipTime; // 0x38
		public float AnimationLength; // 0x3C
	
		// Constructors
		public TreasurePlaybackSettings() {} // 0x000000018690A750-0x000000018690A940
	
		// Methods
		public void StartCoins() {} // 0x000000018690A430-0x000000018690A580
		public void StopCoins() {} // 0x000000018690A580-0x000000018690A750
	}
}

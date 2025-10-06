/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Signals;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI.Player
{
	public class WickedSeasonUI : GameMonoBehaviour // TypeDefIndex: 15060
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _SeasonFan; // 0x28
		[SerializeField]
		private SpriteRenderer _SeasonSprite; // 0x30
		[SerializeField]
		private Transform _SeasonSpriteParent; // 0x38
		private SignalBus _signalBus; // 0x40
		private Tween _seasonTween; // 0x48
		private float _tweenValue; // 0x50
		private static readonly int FillAmount; // 0x00
	
		// Constructors
		public WickedSeasonUI() {} // 0x0000000184C44C90-0x0000000184C44CE0
		static WickedSeasonUI() {} // 0x00000001869D24D0-0x00000001869D2530
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x00000001869D1BD0-0x00000001869D1E30
		private new void Awake() {} // 0x00000001869D1E30-0x00000001869D1E90
		protected override void OnDestroy() {} // 0x00000001869D1E90-0x00000001869D1FC0
		private void OpenSeasonFan(GameplaySignals.OpenSeasonFanSignal signal) {} // 0x00000001869D1FC0-0x00000001869D24D0
	}
}

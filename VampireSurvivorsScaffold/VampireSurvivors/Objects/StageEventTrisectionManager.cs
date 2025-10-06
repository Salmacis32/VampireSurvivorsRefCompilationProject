/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	[UsedImplicitly]
	public class StageEventTrisectionManager : StageEventManager // TypeDefIndex: 15159
	{
		// Fields
		public float _tweenCounterTargetValue; // 0xA0
		protected PhaserText _nextEventText; // 0xA8
		protected Vector3 _nextEventTextDefaultLocalPosition; // 0xB0
		protected Vector3 _nextEventTextGoldFeverLocalPosition; // 0xBC
		protected List<TrisectionEvent> _goodEvents; // 0xC8
		protected List<TrisectionEvent> _neutralEvents; // 0xD0
		protected List<TrisectionEvent> _badEvents; // 0xD8
		protected List<TrisectionEvent> _triggeredEvents; // 0xE0
		protected bool _dontRepeatEvents; // 0xE8
		protected MultiTargetTween _tweenHideCircles; // 0xF0
		protected MultiTargetTween _tweenShowCircles; // 0xF8
		protected MultiTargetTween _tweenCounter; // 0x100
		private PhaserSprite _sCenter; // 0x108
		private PhaserSprite _sWorld; // 0x110
		private PhaserSprite _sMoon; // 0x118
		private PhaserSprite _sSun; // 0x120
		private MultiTargetTween _tweenWorld; // 0x128
		private MultiTargetTween _tweenMoon; // 0x130
		private MultiTargetTween _tweenSun; // 0x138
		private MultiTargetTween _tweenRotateName; // 0x140
		private MultiTargetTween _tweenHighlightName; // 0x148
		protected int _totalWeightGood; // 0x150
		protected int _totalWeightNeutral; // 0x154
		protected int _totalWeightBad; // 0x158
		private int _previousPlayerLevel; // 0x15C
		private List<string> _eventNames; // 0x160
		protected List<WeightedTrisectionEventData> _weightedGood; // 0x168
		protected List<WeightedTrisectionEventData> _weightedNeutral; // 0x170
		protected List<WeightedTrisectionEventData> _weightedBad; // 0x178
		private ChoiceType _nextChoice; // 0x180
		protected WeightedTrisectionEventData _nextChosenEvent; // 0x188
		protected Unity.Mathematics.Random _eventsRng; // 0x190
	
		// Nested types
		[Serializable]
		public class WeightedTrisectionEventData // TypeDefIndex: 15152
		{
			// Fields
			public int weight; // 0x10
			public TrisectionEvent ev; // 0x18
	
			// Constructors
			public WeightedTrisectionEventData() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		public enum ChoiceType // TypeDefIndex: 15153
		{
			GOOD = 0,
			NEUTRAL = 1,
			BAD = 2
		}
	
		// Constructors
		public StageEventTrisectionManager() {} // 0x0000000186A5F2A0-0x0000000186A5F590
	
		// Methods
		public override void Init(Stage stage) {} // 0x0000000186A59C30-0x0000000186A5A240
		public void SetSeed(uint seed) {} // 0x0000000186A5A240-0x0000000186A5A270
		public void ShowUI() {} // 0x0000000184311DD0-0x0000000184311DF0
		public void HideUI() {} // 0x0000000186A5A270-0x0000000186A5A2F0
		public virtual void Spinnn(float duration = 10000f /* Metadata: 0x0197741C */, TrisectionEvent forcedEvent = null, Action onEventSelected = null) {} // 0x0000000186A5A2F0-0x0000000186A5B050
		public void TriggerTrisectionEvent() {} // 0x0000000186A5B050-0x0000000186A5B260
		public List<TrisectionEvent> GetAllEvents() => default; // 0x0000000186A5B260-0x0000000186A5B370
		public void TrisectionUpdate() {} // 0x0000000186A5B370-0x0000000186A5B570
		protected virtual void PopulateEvents() {} // 0x0000000186A5B570-0x0000000186A5CF00
		protected virtual void CreateUI() {} // 0x0000000186A5CF00-0x0000000186A5D750
		private void CalculateWeights() {} // 0x0000000186A5D750-0x0000000186A5DBE0
		private List<WeightedTrisectionEventData> BuildWeightedList(List<TrisectionEvent> events, bool dontRepeatEvents) => default; // 0x0000000186A5DBE0-0x0000000186A5DE40
		protected void CalculateMainChances() {} // 0x0000000186A5DE40-0x0000000186A5DFE0
		protected virtual void ChooseEvent() {} // 0x0000000186A5DFE0-0x0000000186A5E370
		protected virtual void ShowCircles() {} // 0x0000000186A5E370-0x0000000186A5E700
		protected virtual void HideCircles() {} // 0x0000000186A5E700-0x0000000186A5EA90
		protected void RotateEventNames() {} // 0x0000000186A5EA90-0x0000000186A5EDA0
		protected void HighlightEventName(Action onTextHighlighted = null) {} // 0x0000000186A5EDA0-0x0000000186A5F1D0
		private string GetEventName(TrisectionEvent trisectionEvent) => default; // 0x0000000186A5F1D0-0x0000000186A5F2A0
	}
}

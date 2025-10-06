/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects
{
	public class WestwoodsTrisectionManager : StageEventTrisectionManager // TypeDefIndex: 15179
	{
		// Fields
		private PhaserSprite _wheelOfFortune; // 0x198
		private PhaserSprite _needleArrow; // 0x1A0
		private MultiTargetTween _tweenWheelOfFortune; // 0x1A8
		private MultiTargetTween _tweenShowNeedle; // 0x1B0
		private const string UITextureName = "UI"; // Metadata: 0x0197743A
		public bool _isSpinning; // 0x1B8
		public bool _isIdle; // 0x1B9
		private float _wheelAngleAtLastTickAudio; // 0x1BC
		private float _minTimeBetweenTicks; // 0x1C0
		private float _tickTimer; // 0x1C4
		private const float AnglePerTick = 30f; // Metadata: 0x0197743D
		private const float TickVolume = 2f; // Metadata: 0x01977441
		private const float FanfareVolume = 0.5f; // Metadata: 0x01977445
		private readonly SoundManager.SoundConfig _fanfareSoundConfig; // 0x1D0
		public int queuedSpins; // 0x1D8
	
		// Events
		public event Action OnUnlockZoneEvent;
	
		// Constructors
		public WestwoodsTrisectionManager() {} // 0x0000000186A7C820-0x0000000186A7C900
	
		// Methods
		public override void Init(Stage stage) {} // 0x0000000186A78EB0-0x0000000186A78ED0
		protected override void CreateUI() {} // 0x0000000186A78ED0-0x0000000186A79790
		protected override void PopulateEvents() {} // 0x0000000186A79790-0x0000000186A7AC70
		protected override void ChooseEvent() {} // 0x0000000186A7AC70-0x0000000186A7AF90
		private ValueTuple<float, float> GetEventAngles(TrisectionEvent trisectionEvent) => default; // 0x0000000186A7AF90-0x0000000186A7B360
		private float EventAngleRange(ValueTuple<float, float> eventAngles) => default; // 0x0000000186A7B360-0x0000000186A7B3D0
		public bool CheckForUnlockZoneEvent() => default; // 0x0000000186A7B3D0-0x0000000186A7B480
		protected override void ShowCircles() {} // 0x0000000186A7B480-0x0000000186A7B970
		protected override void HideCircles() {} // 0x0000000186A7B970-0x0000000186A7BC80
		public void UpdateTrisectionAudio() {} // 0x0000000186A7BC80-0x0000000186A7BFC0
		public override void Spinnn(float duration = 5000f /* Metadata: 0x01977436 */, TrisectionEvent forcedEvent = null, Action onEventSelected = null) {} // 0x0000000186A7BFC0-0x0000000186A7C820
	}
}

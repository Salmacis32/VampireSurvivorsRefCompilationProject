/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Lexone.UnityTwitchChat;
using TMPro;
using VampireSurvivors.App.UI.Twitch;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Stage;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Objects
{
	[UsedImplicitly]
	public class StageEventTwitchManager : StageEventManager // TypeDefIndex: 18657
	{
		// Fields
		private bool _active; // 0xA0
		private float _panelWidth; // 0xA4
		private float _panelHeight; // 0xA8
		private float _panelHideX; // 0xAC
		private float _panelX; // 0xB0
		private float _panelY; // 0xB4
		private int _twitchLimitCount; // 0xB8
		private VampireSurvivors.Framework.TimerSystem.Timer _twitchTimer; // 0xC0
		private List<int> _twitchOptionCounter; // 0xC8
		private List<VampireSurvivors.Data.Stage.Event> _mediaEvents; // 0xD0
		private List<TextMeshProUGUI> _twitchOptions; // 0xD8
		private readonly List<VampireSurvivors.Data.Stage.Event> _goodEvents; // 0xE0
		private readonly List<VampireSurvivors.Data.Stage.Event> _neutralEvents; // 0xE8
		private readonly List<VampireSurvivors.Data.Stage.Event> _badEvents; // 0xF0
	
		// Properties
		private TwitchStageEventsPanel EventsPanel { get => default; } // 0x0000000186810BF0-0x0000000186810C50 
	
		// Constructors
		public StageEventTwitchManager() {} // 0x0000000186813980-0x0000000186815C20
	
		// Methods
		public override void Init(VampireSurvivors.Objects.Stage stage) {} // 0x0000000186810C50-0x0000000186810C60
		public void ShowTwitchUI() {} // 0x0000000186810C60-0x0000000186812140
		public void HideTwitchUI() {} // 0x0000000186812140-0x0000000186812370
		public void QuickShow() {} // 0x0000000186812370-0x0000000186812410
		public void QuickHide() {} // 0x0000000186812410-0x00000001868124A0
		public bool TriggerEvents() => default; // 0x00000001868124A0-0x0000000186813040
		private void EnableTwitch() {} // 0x0000000186813040-0x0000000186813200
		private void DisableTwitch() {} // 0x0000000186813200-0x00000001868132F0
		private void ProcessMessage(Chatter chatter) {} // 0x00000001868132F0-0x0000000186813480
		private void IncreaseTwitchOption(int num, string username) {} // 0x0000000186813480-0x0000000186813710
		private int CalculateChoice() => default; // 0x0000000186813710-0x00000001868138F0
		private string GetEventName(VampireSurvivors.Data.Stage.Event stageEvent) => default; // 0x00000001868138F0-0x0000000186813980
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using VampireSurvivors.Achievements;
using VampireSurvivors.App.Framework.System;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class Preloader : MonoBehaviour // TypeDefIndex: 14924
	{
		// Fields
		[SerializeField]
		private List<GameObject> _Sprites; // 0x20
		[SerializeField]
		private TextMeshProUGUI _StatusInfoText; // 0x28
		[SerializeField]
		private TextMeshProUGUI _ExtraInfoText; // 0x30
		[SerializeField]
		private Canvas _Canvas; // 0x38
		private UnityServicesManager _unityServicesManager; // 0x40
		[Inject]
		private PlayerOptions _playerOptions; // 0x48
		[Inject]
		private AchievementManager _achievementManager; // 0x50
		public static bool HideGraphics; // 0x00
	
		// Constructors
		public Preloader() {} // 0x00000001869318F0-0x00000001869319F0
	
		// Methods
		[Inject]
		private void Construct(UnityServicesManager unityServicesManager) {} // 0x00000001869307B0-0x0000000186930AC0
		private void Awake() {} // 0x0000000186930AC0-0x0000000186930AD0
		private void Start() {} // 0x0000000186930AD0-0x0000000186930DC0
		private async UniTaskVoid InitAsync() => default; // 0x0000000186930DC0-0x0000000186930EF0
		private void InitPlatform() {} // 0x0000000186930EF0-0x0000000186930FF0
		private void UpdateText(string newText) {} // 0x0000000186930FF0-0x0000000186931100
		private void UpdateExtraText(string newText) {} // 0x0000000186931100-0x0000000186931380
		[IteratorStateMachine(typeof(_WaitAFrame_d__15))]
		private IEnumerator WaitAFrame(Action callback) => default; // 0x0000000186931380-0x0000000186931420
		private void LoadNextScene() {} // 0x0000000186931420-0x00000001869317A0
		private static void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {} // 0x00000001869317A0-0x0000000186931850
		[IteratorStateMachine(typeof(_Wait_d__18))]
		private static IEnumerator Wait(AsyncOperation s) => default; // 0x0000000186931850-0x00000001869318F0
	}
}

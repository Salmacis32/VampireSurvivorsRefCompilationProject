/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;
using VampireSurvivors;
using VampireSurvivors.Achievements;
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Loading;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TPCreditsScene : MonoBehaviour // TypeDefIndex: 15025
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _Background; // 0x20
		[SerializeField]
		private SpriteRenderer _Castle; // 0x28
		[SerializeField]
		private Transform _RingContainer; // 0x30
		[SerializeField]
		private GameObject _DoilieSpritePrefab; // 0x38
		[SerializeField]
		private Transform _DoilieOrigin; // 0x40
		private List<string> _DoilieSprites; // 0x48
		[FormerlySerializedAs("_Animation")]
		[SerializeField]
		private AnimationClip _AnimationLandscape; // 0x50
		[SerializeField]
		private AnimationClip _AnimationPortrait; // 0x58
		[SerializeField]
		private Animator _Animator; // 0x60
		[SerializeField]
		private GameObject _AnimCamera; // 0x68
		[SerializeField]
		private List<GameObject> _RingPrefabs; // 0x70
		[SerializeField]
		private AnimationCurve _CameraRotationCurve; // 0x78
		[SerializeField]
		private Transform _Space; // 0x80
		[SerializeField]
		private VideoPlayer _Video; // 0x88
		[SerializeField]
		private TextMeshProUGUI _DebugText; // 0x90
		[SerializeField]
		private Transform _Rotator; // 0x98
		[SerializeField]
		private TextAsset _TimeCodes; // 0xA0
		private AnimationClip _currentAnimationClip; // 0xA8
		private float _normalizedTime; // 0xB0
		private float _animLength; // 0xB4
		private Vector3 _cameraStartPos; // 0xB8
		private Vector3 _cameraEndPos; // 0xC4
		private float _ringDistanceInterval; // 0xD0
		private Vector3 _cameraDirection; // 0xD4
		private float _cameraVelocity; // 0xE0
		private SignalBus _signalBus; // 0xE8
		private MultiplayerManager _multiplayer; // 0xF0
		private PlayerOptions _playerOptions; // 0xF8
		private AchievementManager _achievementManager; // 0x100
		private DataManager _data; // 0x108
		private LobbiesManager _lobbiesManager; // 0x110
		private TPCreditsPage _page; // 0x118
		private bool isPlaying; // 0x120
		private float _currentTime; // 0x124
		private List<KeyValuePair<float, string>> _timeCodesFromAudio; // 0x128
		private List<VampireSurvivors.Data.CharacterType> _charsToUnlock; // 0x130
		private int _charIndex; // 0x138
		public static string CreditsVideo_1080_60; // 0x00
		public static string CreditsVideo_1080_30; // 0x08
	
		// Constructors
		public TPCreditsScene() {} // 0x00000001869B9510-0x00000001869B9BF0
		static TPCreditsScene() {} // 0x00000001869B9BF0-0x00000001869B9D20
	
		// Methods
		public static string GetCreditsVideoForCurrentPlatform() => default; // 0x00000001869B3D50-0x00000001869B3DB0
		public static string GetExcludedCreditsVideo() => default; // 0x00000001869B3DB0-0x00000001869B3E60
		[Inject]
		private void Construct(SignalBus signal, MultiplayerManager _multi, PlayerOptions playerOptions, AchievementManager achievementManager, DataManager data, LobbiesManager lobbiesManager) {} // 0x00000001869B3E60-0x00000001869B40A0
		public void Preload(AsyncLoader loader, string cacheGroupName) {} // 0x00000001869B40A0-0x00000001869B4330
		private void ParseText() {} // 0x00000001869B4330-0x00000001869B47E0
		private List<string> TextAssetToList(TextAsset ta) => default; // 0x00000001869B47E0-0x00000001869B4980
		private void PrepareVideo(VideoClip clip, Action onComplete) {} // 0x00000001869B4980-0x00000001869B49C0
		public void Initialize(TPCreditsPage page) {} // 0x00000001869B49C0-0x00000001869B4DF0
		public void GenerateFramesAndEvents() {} // 0x0000000180B15170-0x0000000180B15180
		public void ActivateCamera() {} // 0x00000001869B4DF0-0x00000001869B4EF0
		private void Update() {} // 0x00000001869B4EF0-0x00000001869B51C0
		public void SkipToTime(float skipTime) {} // 0x00000001869B51C0-0x00000001869B5260
		private void AddAnimationEvents(List<AnimationEvent> existingEvents) {} // 0x00000001869B5260-0x00000001869B5400
		private void StopMusic() {} // 0x00000001869B5400-0x00000001869B56F0
		public AnimationEvent AddEvent(float time, string functionName) => default; // 0x00000001869B56F0-0x00000001869B57B0
		private void SpawnMinorDoilie() {} // 0x00000001869B57B0-0x00000001869B58A0
		private void UnlockNext() {} // 0x00000001869B58A0-0x00000001869B5B20
		private void SpawnRings() {} // 0x00000001869B5B20-0x00000001869B67B0
		private void AddCameraPositionKeyFrames() {} // 0x00000001869B67B0-0x00000001869B6E30
		private void MathsStuff() {} // 0x00000001869B6E30-0x00000001869B7400
		private void AddCameraRotationKeyFrames() {} // 0x00000001869B7400-0x00000001869B7FB0
		public void PlayVideo() {} // 0x00000001869B7FB0-0x00000001869B80A0
		public void SetPlaying(bool v, float startTime) {} // 0x00000001869B80A0-0x00000001869B8190
		public void ReturnToMenu() {} // 0x00000001869B8190-0x00000001869B8490
		public void GoToCharacterSelectScreen() {} // 0x00000001869B8490-0x00000001869B8520
		public void SelectDraculaAndRelease() {} // 0x00000001869B8520-0x00000001869B88D0
		private void RunManualAchievementChecks() {} // 0x00000001869B88D0-0x00000001869B8A70
		public void SetAnimTime(float time) {} // 0x00000001869B8A70-0x00000001869B8B00
		public void SpawnDoilie() {} // 0x00000001869B8B00-0x00000001869B9220
		private void OnDrawGizmos() {} // 0x00000001869B9220-0x00000001869B9510
	}
}

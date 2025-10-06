/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using SuperTiled2Unity;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework;
using VampireSurvivors.Objects;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TreasureReelUI : MonoBehaviour // TypeDefIndex: 15032
	{
		// Fields
		[SerializeField]
		private string _ColorString; // 0x20
		[SerializeField]
		private float _Alpha; // 0x28
		private float Speed; // 0x2C
		[SerializeField]
		private Animator Anim; // 0x30
		[SerializeField]
		private Image RewardBeam; // 0x38
		[SerializeField]
		private GameObject Reward; // 0x40
		[SerializeField]
		private Image RewardIcon; // 0x48
		[SerializeField]
		private Image _FlashBackground; // 0x50
		[SerializeField]
		private RectTransform _Star1; // 0x58
		[SerializeField]
		private RectTransform _Star2; // 0x60
		[SerializeField]
		private GameObject _ReelIcon; // 0x68
		[ReadOnly]
		[SerializeField]
		private Texture2D _GeneratedTexture; // 0x70
		[SerializeField]
		private RawImage _RewardImage; // 0x78
		private int _minAmountOfPowerups; // 0x80
		private float _originalWidth; // 0x84
		private Vector3 _originalPosition; // 0x88
		private RectTransform _rectTrans; // 0x98
		private List<Tuple<string, string>> _weaponNamesNew; // 0xA0
		private bool _isActive; // 0xA8
		private static readonly int Reveal1; // 0x00
		private LevelUpFactory _levelUp; // 0xB0
		private PlayerOptions _playerOptions; // 0xB8
		private Tween _Star1TweenRot; // 0xC0
		private Tween _Star1TweenScale; // 0xC8
		private Tween _Star2TweenRot; // 0xD0
		private Tween _Star2TweenScale; // 0xD8
		private Dictionary<WeaponType, List<WeaponData>> _weapons; // 0xE0
	
		// Constructors
		public TreasureReelUI() {} // 0x00000001869C4520-0x00000001869C4630
		static TreasureReelUI() {} // 0x00000001869C4630-0x00000001869C4690
	
		// Methods
		[Inject]
		private void Constructor(LevelUpFactory level, PlayerOptions playerOptions) {} // 0x00000001869C10F0-0x00000001869C11B0
		private void Start() {} // 0x00000001869C11B0-0x00000001869C13F0
		public void SetRewardIcon(string spriteName, string textureName) {} // 0x00000001869C13F0-0x00000001869C1480
		public void GenerateWeapons(GameSessionData session, Dictionary<WeaponType, List<WeaponData>> weapons, PrizeType prize, VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001869C1480-0x00000001869C1720
		private void MakeTexture_Any(bool shuffle = true /* Metadata: 0x0197727C */) {} // 0x00000001869C1720-0x00000001869C1DA0
		private void MakeTexture_PowerUps(bool shuffle = true /* Metadata: 0x0197727D */) {} // 0x00000001869C1DA0-0x00000001869C2520
		private void MakeTexture_ExistingWeapons(VampireSurvivors.Objects.Characters.CharacterController character) {} // 0x00000001869C2520-0x00000001869C2B20
		public void SetWeapons(List<Tuple<string, string>> weapons) {} // 0x00000001869C2B20-0x00000001869C3980
		public void StartScrolling() {} // 0x000000018626A6C0-0x000000018626A6D0
		public void StopScrolling() {} // 0x00000001869C3980-0x00000001869C39C0
		private void Update() {} // 0x00000001869C39C0-0x00000001869C3AF0
		public void Reveal() {} // 0x00000001869C3AF0-0x00000001869C3BA0
		public void HideBeam() {} // 0x00000001869C3BA0-0x00000001869C3C40
		public void Finish() {} // 0x00000001869C3C40-0x00000001869C3CC0
		public void Reset() {} // 0x00000001869C3CC0-0x00000001869C3E30
		public void FlashOn() {} // 0x00000001869C3E30-0x00000001869C3E60
		public void FlashOff() {} // 0x00000001869C3E60-0x00000001869C3E90
		private void DoStarTweens() {} // 0x00000001869C3E90-0x00000001869C44A0
		private void OnDestroy() {} // 0x00000001869C44A0-0x00000001869C4520
	}
}

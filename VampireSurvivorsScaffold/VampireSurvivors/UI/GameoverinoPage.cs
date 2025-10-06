/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameoverinoPage : BaseUIPage // TypeDefIndex: 14786
	{
		// Fields
		[FormerlySerializedAs("Pixeler")]
		[SerializeField]
		private PixelationTool _Pixeler; // 0xE0
		[SerializeField]
		private UnityEngine.UI.Button _ReviveButton; // 0xE8
		[SerializeField]
		private UISpriteAnimation _ReviveAnimation; // 0xF0
		[SerializeField]
		private Material _GameOverPixelise; // 0xF8
		[SerializeField]
		private Image _WhiteFlash; // 0x100
		[SerializeField]
		private Image _Background; // 0x108
		[SerializeField]
		private Image _Title; // 0x110
		[SerializeField]
		private Image _LeftHand; // 0x118
		[SerializeField]
		private Image _RightHand; // 0x120
		[SerializeField]
		private Material _BackgroundPixelMat; // 0x128
		[SerializeField]
		private Material _TitlePixelMat; // 0x130
		private PlayerOptions _playerOptions; // 0x138
		private static readonly int CellSizeX; // 0x00
		private static readonly int CellSizeY; // 0x04
	
		// Constructors
		public GameoverinoPage() {} // 0x000000018689B390-0x000000018689B3E0
		static GameoverinoPage() {} // 0x000000018689B3E0-0x000000018689B470
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions player) {} // 0x0000000185D80170-0x0000000185D801D0
		protected override void OnShowStart(GameObject g) {} // 0x000000018689A860-0x000000018689B160
		private void OnIntroEnded() {} // 0x000000018689B160-0x000000018689B170
		private void PlayAutoRevive() {} // 0x000000018689B170-0x000000018689B390
	}
}

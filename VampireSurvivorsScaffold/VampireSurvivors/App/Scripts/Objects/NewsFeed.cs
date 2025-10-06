/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Objects
{
	public class NewsFeed : MonoBehaviour // TypeDefIndex: 18655
	{
		// Fields
		private const string BannerSpriteName = "NewsfeedWarning"; // Metadata: 0x0197AF3E
		private const string BannerTextureName = "UI"; // Metadata: 0x0197AF4E
		private const float ScreenPercentY = 0.9f; // Metadata: 0x0197AF51
		private const float ScrollDurationMS = 10000f; // Metadata: 0x0197AF55
		private const float BannerAlphaDefault = 0.25f; // Metadata: 0x0197AF59
		private const float BannerAlphaPulse = 0.35f; // Metadata: 0x0197AF5D
		private const float BannerAlphaPulseDurationMS = 1000f; // Metadata: 0x0197AF61
		private const float BannerFadeInDurationMS = 150f; // Metadata: 0x0197AF65
		private const float BannerFadeOutDurationMS = 150f; // Metadata: 0x0197AF69
		private const float TextFadeInDurationMS = 150f; // Metadata: 0x0197AF6D
		private const float TextFadeOutDurationMS = 150f; // Metadata: 0x0197AF71
		private MultiTargetTween _bannerShowTween; // 0x20
		private MultiTargetTween _bannerScrollTween; // 0x28
		private MultiTargetTween _bannerAlphaTween; // 0x30
		private MultiTargetTween _bannerHideTween; // 0x38
		private MultiTargetTween _textShowTween; // 0x40
		private MultiTargetTween _textScrollTween; // 0x48
		private MultiTargetTween _textHideTween; // 0x50
		private GameObject _banner; // 0x58
		private TileSpriteBuilder _bannerTileSpriteBuilder; // 0x60
		private TileSprite _bannerTileSprite; // 0x68
		private PhaserText _text; // 0x70
		private float _textStartPosX; // 0x78
		private float _bannerScrollStartOffsetX; // 0x7C
		public float _BannerScrollOffsetX; // 0x80
	
		// Properties
		public PhaserText TextObject { get => default; } // 0x00000001826E99F0-0x00000001826E9A00 
	
		// Constructors
		public NewsFeed() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x000000018680EDD0-0x000000018680EDF0
		private void MakeBanner() {} // 0x000000018680EDF0-0x000000018680F320
		private void MakeText() {} // 0x000000018680F320-0x000000018680F6E0
		public void SetText(string text) {} // 0x000000018680F6E0-0x000000018680F700
		public void SetSprite(string _BannerSpriteName, string _BannerTextureName) {} // 0x000000018680F700-0x000000018680F720
		public void SetVisible(bool visible) {} // 0x000000018680F720-0x000000018680F9A0
		public void Show() {} // 0x000000018680F9A0-0x0000000186810360
		public void Hide() {} // 0x0000000186810360-0x0000000186810820
	}
}

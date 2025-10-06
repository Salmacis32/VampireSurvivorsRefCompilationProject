/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class TrackItemUI : SelectableUI // TypeDefIndex: 15030
	{
		// Fields
		[SerializeField]
		private Image _Icon; // 0xA0
		[SerializeField]
		private TextMeshProUGUI _Title; // 0xA8
		[SerializeField]
		private Image _Frame; // 0xB0
		[SerializeField]
		private UnityEngine.UI.Button _Button; // 0xB8
		[FormerlySerializedAs("_cg")]
		[SerializeField]
		private CanvasGroup _CanvasGroup; // 0xC0
		private Canvas _canvas; // 0xC8
		private BgmType _bgmType; // 0xD0
		private MusicData _data; // 0xD8
		private AdvancedMusicSelection _page; // 0xE0
		private Color _deselectColor; // 0xE8
		private float _deselectAlpha; // 0xF8
		private bool _holdSelection; // 0xFC
		private Tween _colorTween; // 0x100
		private Tween _fadeTween; // 0x108
	
		// Constructors
		public TrackItemUI() {} // 0x00000001869C1080-0x00000001869C10F0
	
		// Methods
		protected override void Awake() {} // 0x00000001869C04B0-0x00000001869C04C0
		public void SetData(string name, Sprite icon, BgmType bgmType, MusicData data, AdvancedMusicSelection page) {} // 0x00000001869C04C0-0x00000001869C0720
		protected override void OnDisable() {} // 0x00000001869C0720-0x00000001869C0780
		public void KillTweens() {} // 0x00000001869C0780-0x00000001869C07E0
		public void OnMouseClick() {} // 0x00000001869C07E0-0x00000001869C09A0
		public BgmType GetBgmType() => default; // 0x0000000181BDC430-0x0000000181BDC440
		public MusicData GetMusicData() => default; // 0x0000000182A45A70-0x0000000182A45A80
		public void SetLoading(bool v) {} // 0x00000001869C09A0-0x00000001869C0A60
		public void HoldSelection() {} // 0x00000001869C0A60-0x00000001869C0A70
		public void ReleaseSelection() {} // 0x00000001869C0A70-0x00000001869C0A80
		public void ForceDeselect() {} // 0x00000001869C0A80-0x00000001869C0D60
		protected override void OnSelected() {} // 0x00000001869C0D60-0x00000001869C1080
	}
}

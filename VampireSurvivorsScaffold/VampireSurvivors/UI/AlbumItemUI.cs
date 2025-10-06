/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AlbumItemUI : CarouselItemUI // TypeDefIndex: 14657
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI _Title; // 0x68
		[SerializeField]
		private Image _Icon; // 0x70
		private bool _isSelected; // 0x78
		private bool _previouslyIsSelected; // 0x79
		private Tween _colorTween; // 0x80
		private Tween _fadeTween; // 0x88
		private AlbumType _albumType; // 0x90
		private AlbumData _albumData; // 0x98
	
		// Constructors
		public AlbumItemUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		public void SetData(string name, AlbumType t, AlbumData d) {} // 0x000000018731F0A0-0x000000018731F210
		public override void Initialize(float maxDistance) {} // 0x000000018731F210-0x000000018731F240
		public AlbumType GetAlbumType() => default; // 0x0000000181BA6030-0x0000000181BA6040
		public AlbumData GetAlbumData() => default; // 0x0000000181971630-0x0000000181971640
		private void KillTweens() {} // 0x000000018731F240-0x000000018731F2A0
		private void OnDisable() {} // 0x000000018731F240-0x000000018731F2A0
		protected override void ApplyProgress() {} // 0x000000018731F2A0-0x000000018731F400
		public override void Deselect(bool completeImmediately = false /* Metadata: 0x019771C0 */) {} // 0x000000018731F400-0x000000018731F5C0
		public override void Select(bool completeImmediately = false /* Metadata: 0x019771C1 */) {} // 0x000000018731F5C0-0x000000018731F780
	}
}

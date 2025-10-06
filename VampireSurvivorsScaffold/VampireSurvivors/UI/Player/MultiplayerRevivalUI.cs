/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using VampireSurvivors.App.Graphics;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI.Player
{
	public class MultiplayerRevivalUI : MonoBehaviour // TypeDefIndex: 15059
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _revivalBarFill; // 0x20
		[SerializeField]
		private TextMeshProUGUI _revivalsLeftText; // 0x28
		[SerializeField]
		private SpriteRenderer _coffinRenderer; // 0x30
		[SerializeField]
		private SpriteRenderer _ghostRenderer; // 0x38
		[SerializeField]
		private Sprite[] _revivalBarSprites; // 0x40
		[SerializeField]
		private MeshRenderer _coffinOutline; // 0x48
		[SerializeField]
		private ExplodingCoffin _explodingCoffin; // 0x50
		private VampireSurvivors.Objects.Characters.CharacterController _character; // 0x58
		private MultiTargetTween _shakeTween; // 0x60
	
		// Constructors
		public MultiplayerRevivalUI() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x00000001869D0470-0x00000001869D0500
		private void Update() {} // 0x00000001869D0500-0x00000001869D06C0
		private void SetBarFill(float fillProportion) {} // 0x00000001869D06C0-0x00000001869D0720
		public void DoShake(float strength) {} // 0x00000001869D0720-0x00000001869D0C40
		public void OpenLidAnimation() {} // 0x00000001869D0C40-0x00000001869D0F80
		private void UpdateCoffinVisuals() {} // 0x00000001869D0F80-0x00000001869D1100
		public void ToggleVisible(bool visible) {} // 0x00000001869D1100-0x00000001869D13D0
		public void SetGhost(bool isGhost) {} // 0x00000001869D13D0-0x00000001869D15D0
		public bool IsGhost() => default; // 0x00000001869D15D0-0x00000001869D16B0
		public bool IsVisible() => default; // 0x0000000184C499D0-0x0000000184C49A70
	}
}

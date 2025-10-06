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
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Data;
using VampireSurvivors.Data.Items;
using VampireSurvivors.Data.Weapons;
using VampireSurvivors.Framework.Particles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class GameWindowedUIPage : BaseUIPage // TypeDefIndex: 14791
	{
		// Fields
		[SerializeField]
		protected ParticleEmitterManager _PfxEmitter; // 0xE0
		[SerializeField]
		protected RectTransform _WindowContainer; // 0xE8
		[SerializeField]
		protected string _ParticleTexture; // 0xF0
		[SerializeField]
		protected List<string> _ParticleFrames; // 0xF8
		[SerializeField]
		protected List<string> _WindowFrames; // 0x100
		[SerializeField]
		protected TextMeshProUGUI _Title; // 0x108
		[SerializeField]
		protected RectTransform _TitlePanel; // 0x110
		[SerializeField]
		protected RectTransform _Content; // 0x118
		[SerializeField]
		protected RectTransform _BackButton; // 0x120
		protected List<GameObject> _spawned; // 0x128
		protected ParticleSystem _pfx1; // 0x130
		protected ParticleSystem _pfx2; // 0x138
		protected bool _particlesCreated; // 0x140
		protected List<Image> _windows; // 0x148
		protected bool hideBackgroundParticles; // 0x150
		protected bool hideBackgroundWindows; // 0x151
	
		// Constructors
		public GameWindowedUIPage() {} // 0x00000001868A2240-0x00000001868A2550
	
		// Methods
		public virtual void Purchase(VampireSurvivors.Data.ItemType t, ItemData d, ShopItemUI item, float price, RectTransform sender) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void Purchase(WeaponType t, WeaponData d, float price, ShopItemUI item) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void SetSelected(ShopItemUI item) {} // 0x0000000180B15170-0x0000000180B15180
		public virtual void OnUserConfirmInput() {} // 0x0000000180B15170-0x0000000180B15180
		public virtual float GetCurrency() => default; // 0x00000001826256C0-0x00000001826256D0
		protected override void OnShowStart(GameObject g) {} // 0x00000001868A03A0-0x00000001868A0450
		protected override void OnHideFinish(GameObject g) {} // 0x00000001868A0450-0x00000001868A0600
		protected virtual void CreateParticles() {} // 0x00000001868A0600-0x00000001868A14A0
		protected virtual void CreateWindows() {} // 0x00000001868A14A0-0x00000001868A1CE0
		protected void ClearWindows() {} // 0x00000001868A1CE0-0x00000001868A1FA0
		protected DG.Tweening.Sequence BackButtonInTween() => default; // 0x00000001868A1FA0-0x00000001868A2240
	}
}

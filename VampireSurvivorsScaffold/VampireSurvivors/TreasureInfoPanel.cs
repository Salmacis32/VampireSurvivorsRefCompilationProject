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
using VampireSurvivors.Data;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TreasureInfoPanel : MonoBehaviour // TypeDefIndex: 14249
	{
		// Fields
		[SerializeField]
		private TextMeshProUGUI Name; // 0x20
		[SerializeField]
		private TextMeshProUGUI Description; // 0x28
		[SerializeField]
		private TextMeshProUGUI Page; // 0x30
		[SerializeField]
		private TextMeshProUGUI Level; // 0x38
		[SerializeField]
		private TextMeshProUGUI AdditionalInfo; // 0x40
		[SerializeField]
		private Image Icon; // 0x48
		[SerializeField]
		private Image _Background; // 0x50
		private List<TreasurePrizeTypePair> _rewards; // 0x58
		private int _prizeIndex; // 0x60
		private DataManager _data; // 0x68
		private GameSessionData _session; // 0x70
		private DG.Tweening.Sequence _tween; // 0x78
		private float _baseScale; // 0x80
	
		// Constructors
		public TreasureInfoPanel() {} // 0x0000000186F0BDF0-0x0000000186F0BEE0
	
		// Methods
		[Inject]
		private void Construct(DataManager data, GameSessionData session) {} // 0x00000001865FA5D0-0x00000001865FA680
		private void Start() {} // 0x0000000180B15170-0x0000000180B15180
		public void Initialize(List<TreasurePrizeTypePair> prizes) {} // 0x0000000186F09760-0x0000000186F09A20
		public void Reset() {} // 0x0000000186F09A20-0x0000000186F09AC0
		private void StartCycle() {} // 0x0000000186F09AC0-0x0000000186F0A180
		private void ShowFirst() {} // 0x0000000186F0A180-0x0000000186F0A2F0
		private void SetData() {} // 0x0000000186F0A2F0-0x0000000186F0BDF0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class SpinningRingOfCards : MonoBehaviour // TypeDefIndex: 14981
	{
		// Fields
		[SerializeField]
		private int _Amount; // 0x20
		[SerializeField]
		private float _Radius; // 0x24
		[SerializeField]
		private float _Scale; // 0x28
		[SerializeField]
		private float _Speed; // 0x2C
		[SerializeField]
		private float _Duration; // 0x30
		[SerializeField]
		private GameObject _ArcanaCard; // 0x38
		[SerializeField]
		private int _arcanaIndexMin; // 0x40
		[SerializeField]
		private int _arcanaIndexMax; // 0x44
		[SerializeField]
		private string _backFrameName; // 0x48
		[SerializeField]
		private bool _ignoreDarkana; // 0x50
		public float _X; // 0x54
		public float _Y; // 0x58
		private SignalBus _signalBus; // 0x60
		private DataManager _data; // 0x68
		private Dictionary<ArcanaType, ArcanaData> _arcanaData; // 0x70
		private List<ArcanaType> _arcanaList; // 0x78
		private List<GameObject> _spawned; // 0x80
		private DG.Tweening.Sequence _flushSeq; // 0x88
	
		// Constructors
		public SpinningRingOfCards() {} // 0x000000018698A910-0x000000018698AA90
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus, DataManager data, PlayerOptions player) {} // 0x00000001869896A0-0x0000000186989750
		private void Start() {} // 0x0000000180B15170-0x0000000180B15180
		public void DefaultInit() {} // 0x0000000186989750-0x0000000186989790
		private void Update() {} // 0x0000000186989790-0x0000000186989850
		private void OnDisable() {} // 0x0000000186989850-0x0000000186989870
		private void OnDestroy() {} // 0x0000000186989850-0x0000000186989870
		private void Initialize(int amount, float radius, float speed, float scale, float duration) {} // 0x0000000186989870-0x000000018698A6A0
		private ArcanaType GetRandomArcana() => default; // 0x000000018698A6A0-0x000000018698A770
		private void Flush() {} // 0x000000018698A770-0x000000018698A910
	}
}

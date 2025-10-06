/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TreasureFireworksManager : MonoBehaviour // TypeDefIndex: 14248
	{
		// Fields
		[SerializeField]
		private GameObject _ParticlePrefab; // 0x20
		[SerializeField]
		private Material _BaseParticleMaterial; // 0x28
		[SerializeField]
		private List<Sprite> _Sprites; // 0x30
		[SerializeField]
		private Image _WhiteBackground; // 0x38
		[SerializeField]
		private float _MaxOffsetX; // 0x40
		[SerializeField]
		private float _MaxOffsetY; // 0x44
		[SerializeField]
		private ParticleSystemForceField _ForceField; // 0x48
		[SerializeField]
		private GameObject _FireworksRenderTextureView; // 0x50
		private List<KeyValuePair<ParticleSystem, int>> _fireworks; // 0x58
		private List<Material> _materials; // 0x60
	
		// Constructors
		public TreasureFireworksManager() {} // 0x0000000186F09110-0x0000000186F09330
	
		// Methods
		private void Start() {} // 0x0000000180B15170-0x0000000180B15180
		public void PlayFireWorks() {} // 0x0000000186F07D60-0x0000000186F08EB0
		public int OrderInLayer() => default; // 0x0000000186F08EB0-0x0000000186F08F90
		public void OrderInLayer(int newLayer) {} // 0x0000000186F08F90-0x0000000186F09000
		private void DoFlash() {} // 0x0000000186F09000-0x0000000186F09110
	}
}

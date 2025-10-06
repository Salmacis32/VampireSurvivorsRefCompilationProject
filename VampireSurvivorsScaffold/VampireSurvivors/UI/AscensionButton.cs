/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.App.Scripts.Framework.Adventures;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class AscensionButton : MonoBehaviour // TypeDefIndex: 14688
	{
		// Fields
		[SerializeField]
		private UIParticle _StarsBurstParticles; // 0x20
		[SerializeField]
		private Transform _VFXTransform; // 0x28
		[SerializeField]
		private Image _VFXBeam; // 0x30
		[SerializeField]
		private Image _VFXsPFX_ring_64; // 0x38
		[SerializeField]
		private bool _ForceShowAscensionConfirmation; // 0x40
		private AdventureManager _adventureManager; // 0x48
		private AdventureType _adventure; // 0x50
	
		// Constructors
		public AscensionButton() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		[Inject]
		private void Construct(AdventureManager adventure) {} // 0x000000018268E650-0x000000018268E6B0
		private void Start() {} // 0x00000001865F7BA0-0x00000001865F7C60
		public void SetAdventure(AdventureType t) {} // 0x0000000182621130-0x0000000182621140
		public void TryAscend() {} // 0x00000001865F7C60-0x00000001865F7E20
		private void OnAscend(bool result) {} // 0x00000001865F7E20-0x00000001865F8050
		private void CreateAngelVFX() {} // 0x00000001865F8050-0x00000001865F8CE0
		private void TestPFX() {} // 0x00000001865F8CE0-0x00000001865F8E80
		private void CreateParticles() {} // 0x00000001865F8E80-0x00000001865F9F90
	}
}

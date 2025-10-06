/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using VampireSurvivors.Framework.Phaser;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Objects
{
	public class FakePlayerUILevelUp : GameMonoBehaviour // TypeDefIndex: 18563
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _ProgressBox; // 0x28
		[SerializeField]
		private PhaserSprite _ProgressBar; // 0x30
		[SerializeField]
		private TextMeshPro _PlayerLevelText; // 0x38
		private int _level; // 0x40
		private float _value; // 0x44
		private readonly LocalizedString _playerLevelString; // 0x48
		private Color _defaultBarColor; // 0x60
	
		// Constructors
		public FakePlayerUILevelUp() {} // 0x00000001867E3510-0x00000001867E3650
	
		// Methods
		private new void Awake() {} // 0x00000001867E2720-0x00000001867E2730
		private void Update() {} // 0x00000001867E2730-0x00000001867E2AE0
		public void Init(float xPos, float yPos) {} // 0x00000001867E2AE0-0x00000001867E3470
		private void UpdateLevelDisplay() {} // 0x00000001867E3470-0x00000001867E3510
	}
}

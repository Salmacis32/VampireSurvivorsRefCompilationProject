/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Weapons
{
	public class TP_Elevator_Weapon : TP_Clockwork_Weapon // TypeDefIndex: 16349
	{
		// Fields
		private Transform _cachedCameraTransform; // 0x178
		private Vector2 _leftOffset; // 0x180
		private Vector2 _rightOffset; // 0x188
		private Tween cableTween1; // 0x190
		private Tween cableTween2; // 0x198
	
		// Properties
		public TileSprite ChainSpriteL { get; set; } // 0x0000000181971880-0x0000000181971890 0x0000000185E2C0B0-0x0000000185E2C110
		public TileSprite ChainSpriteR { get; set; } // 0x0000000185FA2680-0x0000000185FA2690 0x0000000186747090-0x00000001867470F0
		public Transform RightTransform { get; set; } // 0x0000000185FA26F0-0x0000000185FA2700 0x00000001867470F0-0x0000000186747150
		public Transform LeftTransform { get; set; } // 0x0000000182766A60-0x0000000182766A70 0x0000000182766A70-0x0000000182766AD0
	
		// Constructors
		public TP_Elevator_Weapon() {} // 0x0000000186FB0D70-0x0000000186FB0D80
	
		// Methods
		public override void InitWeapon(VampireSurvivors.Objects.Characters.CharacterController characterController, WeaponType weaponType) {} // 0x0000000186FAF9C0-0x0000000186FB05B0
		public override void InternalUpdate() {} // 0x0000000186FB05B0-0x0000000186FB08A0
		public override void FireProjectiles(Vector2 pos) {} // 0x0000000186FB08A0-0x0000000186FB0CA0
		public override void Cleanup() {} // 0x0000000186FB0CA0-0x0000000186FB0D10
		public override void SetVisible(bool visible) {} // 0x0000000186FB0D10-0x0000000186FB0D70
	}
}

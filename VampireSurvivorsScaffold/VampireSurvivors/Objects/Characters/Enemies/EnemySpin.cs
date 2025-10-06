/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySpin : EnemyController // TypeDefIndex: 17395
	{
		// Fields
		private float _spinAngle; // 0x270
		private float _radius; // 0x274
		private Tween _radiusTween; // 0x278
		private Tween _scaleTween; // 0x280
		private Bounds _camBounds; // 0x288
	
		// Properties
		public int? DepthOverride { get; set; } // 0x0000000185EAA030-0x0000000185EAA040 0x0000000186A13490-0x0000000186A134A0
	
		// Constructors
		public EnemySpin() {} // 0x00000001872A02A0-0x00000001872A02F0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018729F650-0x000000018729FD50
		protected override void OnUpdate() {} // 0x000000018729FD50-0x00000001872A0150
		protected override void UpdateDepth() {} // 0x00000001872A0150-0x00000001872A02A0
	}
}

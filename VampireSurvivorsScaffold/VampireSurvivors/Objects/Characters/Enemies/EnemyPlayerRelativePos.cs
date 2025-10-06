/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyPlayerRelativePos : EnemyController // TypeDefIndex: 17369
	{
		// Fields
		private PhaserSpline _spline; // 0x270
		private float _curveTime; // 0x278
		private float _maxPathWidth; // 0x27C
		private float _maxPathHeight; // 0x280
		protected Vector2 _positionOffset; // 0x284
		public float CurveSpeed; // 0x28C
		public float PathDuration; // 0x290
		private readonly List<float> CurveData; // 0x298
		private readonly List<float> Curve2Data; // 0x2A0
	
		// Constructors
		public EnemyPlayerRelativePos() {} // 0x000000018728C4F0-0x0000000187290DB0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x000000018728BF80-0x000000018728C060
		protected override void OnRecycleEnemy() {} // 0x000000018728C060-0x000000018728C080
		public void InitPath() {} // 0x000000018728C080-0x000000018728C1B0
		protected override void OnUpdate() {} // 0x000000018728C1B0-0x000000018728C410
		public void PositionRelativeToCenter() {} // 0x000000018728C410-0x000000018728C4F0
	}
}

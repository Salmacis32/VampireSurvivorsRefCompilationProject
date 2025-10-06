/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Tools;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyDiamondTint_Path : EnemyDiamondTint // TypeDefIndex: 17299
	{
		// Fields
		private PhaserSpline _spline; // 0x2B8
		private float _curveTime; // 0x2C0
		private float _maxPathWidth; // 0x2C4
		private float _maxPathHeight; // 0x2C8
		protected Vector2 _positionOffset; // 0x2CC
		private float CurveSpeed; // 0x2D4
		private float PathDuration; // 0x2D8
		private readonly List<float> Curve2Data; // 0x2E0
	
		// Properties
		protected override float ItemChance { get => default; } // 0x0000000187244810-0x0000000187244820 
		protected override bool IsImmovable { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool IsAxe { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool IsSnake { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override bool DoBaseUpdate { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
		protected override uint[] TintProgression { get => default; } // 0x0000000187245080-0x00000001872450F0 
	
		// Constructors
		public EnemyDiamondTint_Path() {} // 0x0000000187245600-0x00000001872493D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872450F0-0x00000001872451D0
		protected override void OnRecycleEnemy() {} // 0x00000001872451D0-0x00000001872451F0
		protected override void OnUpdate() {} // 0x00000001872451F0-0x0000000187245410
		public void InitPath() {} // 0x0000000187245410-0x0000000187245540
		public void PositionRelativeToCenter() {} // 0x0000000187245540-0x0000000187245600
	}
}

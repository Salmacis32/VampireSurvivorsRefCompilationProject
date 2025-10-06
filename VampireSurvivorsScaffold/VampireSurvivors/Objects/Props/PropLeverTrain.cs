/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropLeverTrain : Destructible // TypeDefIndex: 15373
	{
		// Fields
		private VampireSurvivors.Objects.Stage _stage; // 0xF8
		private bool _hasFired; // 0x100
		private GameObject _PizzaCircleObj; // 0x108
		public PizzaCircle PizzaCircle; // 0x110
		private MultiTargetTween _tween1; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _selfCleanTimer; // 0x120
	
		// Constructors
		public PropLeverTrain() {} // 0x00000001869ECEE0-0x00000001869ECF40
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000180B3E800-0x0000000180B3E860
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775E1 */, float damageKb = 1f /* Metadata: 0x019775E2 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019775E6 */, bool hasKb = true /* Metadata: 0x019775E7 */) {} // 0x0000000180B15170-0x0000000180B15180
		public override void Init(PropType destructibleType) {} // 0x0000000186BA4710-0x0000000186BA4D50
		private void SelfClean() {} // 0x0000000186BA4D50-0x0000000186BA4EF0
		public override void Despawn() {} // 0x0000000186BA4EF0-0x0000000186BA4F20
		protected override void OnUpdate() {} // 0x0000000186BA4F20-0x0000000186BA5400
		protected void OnTriggeredByPlayer() {} // 0x0000000186BA5400-0x0000000186BA5760
	}
}

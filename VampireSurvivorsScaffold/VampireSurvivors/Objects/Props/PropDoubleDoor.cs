/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SuperTiled2Unity;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Props
{
	public class PropDoubleDoor : Destructible // TypeDefIndex: 15366
	{
		// Fields
		private VampireSurvivors.Objects.Stage _stage; // 0xF8
		private bool _hasFired; // 0x100
		private GameObject _PizzaCircleObj; // 0x108
		public PizzaCircle PizzaCircle; // 0x110
		private MultiTargetTween _tween1; // 0x118
		private VampireSurvivors.Framework.TimerSystem.Timer _selfCleanTimer; // 0x120
		private bool hasSprites; // 0x128
		private PhaserSprite _leftSprite; // 0x130
		private PhaserSprite _rightSprite; // 0x138
		private SuperObject _SuperObject; // 0x140
		private SuperCustomProperties _SuperCustomProperties; // 0x148
		private int _wallWidth; // 0x150
		private int _wallHeight; // 0x154
	
		// Constructors
		public PropDoubleDoor() {} // 0x0000000186B9D7C0-0x0000000186B9D830
	
		// Methods
		[Inject]
		private void Construct(VampireSurvivors.Objects.Stage stage) {} // 0x0000000180B3E800-0x0000000180B3E860
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019775D4 */, float damageKb = 1f /* Metadata: 0x019775D5 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019775D9 */, bool hasKb = true /* Metadata: 0x019775DA */) {} // 0x0000000180B15170-0x0000000180B15180
		protected override void SetupAnimations() {} // 0x0000000186B9B5A0-0x0000000186B9B5C0
		public override void Init(PropType destructibleType) {} // 0x0000000186B9B5C0-0x0000000186B9C140
		private void SelfClean() {} // 0x0000000186B9C140-0x0000000186B9C2C0
		public override void Despawn() {} // 0x0000000186B9C2C0-0x0000000186B9C320
		protected override void OnUpdate() {} // 0x0000000186B9C320-0x0000000186B9C800
		public override void OnDestructibleSpawned(SuperObject tiledScriptObject) {} // 0x0000000186B9C800-0x0000000186B9C9C0
		protected void OnTriggeredByPlayer() {} // 0x0000000186B9C9C0-0x0000000186B9CD70
		protected void OpenWallTiles() {} // 0x0000000186B9CD70-0x0000000186B9D2A0
		protected void CloseWallTiles() {} // 0x0000000186B9D2A0-0x0000000186B9D7A0
		protected void SpawnEnemyWallColliders() {} // 0x0000000186B9D7A0-0x0000000186B9D7C0
		public override bool DoesAllowVenting() => default; // 0x0000000180B15290-0x0000000180B152A0
	}
}

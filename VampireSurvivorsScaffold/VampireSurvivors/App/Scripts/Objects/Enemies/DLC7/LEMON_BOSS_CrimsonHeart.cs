/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Characters;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Objects.Enemies.DLC7
{
	public class LEMON_BOSS_CrimsonHeart : EnemyControllerBoss // TypeDefIndex: 18660
	{
		// Fields
		private const string VfxTextureName = "vfx"; // Metadata: 0x0197AF75
		private List<VampireSurvivors.Objects.Characters.CharacterController> players; // 0x3F8
		private List<Weapon> disabledWeapons; // 0x400
		private bool abilityWasDisabled; // 0x408
		private SpriteRenderer _disableRingSprite; // 0x410
		private MultiTargetTween _disableRingTween; // 0x418
	
		// Constructors
		public LEMON_BOSS_CrimsonHeart() {} // 0x0000000186818750-0x00000001868188D0
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000186817B90-0x0000000186817DE0
		private void InitDisableVFX() {} // 0x0000000186817DE0-0x0000000186818240
		private void PlayDisableVFX() {} // 0x0000000186818240-0x0000000186818580
		public override void Despawn() {} // 0x0000000186818580-0x0000000186818750
	}
}

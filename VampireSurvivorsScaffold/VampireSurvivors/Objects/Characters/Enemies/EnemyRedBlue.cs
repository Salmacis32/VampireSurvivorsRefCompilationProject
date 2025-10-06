/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyRedBlue : EnemyController // TypeDefIndex: 17374
	{
		// Fields
		protected bool _isBlue; // 0x270
		protected bool _isRed; // 0x271
		protected bool _invertFlip; // 0x272
		protected float _defaultScale; // 0x274
		public static readonly List<WeaponType> BlueWeapons; // 0x00
		public static readonly List<WeaponType> RedWeapons; // 0x08
	
		// Properties
		protected virtual List<uint> Tints { get; } // 0x0000000186753760-0x0000000186753770 
	
		// Constructors
		public EnemyRedBlue() {} // 0x0000000187294360-0x0000000187294580
		static EnemyRedBlue() {} // 0x0000000187294580-0x00000001872962E0
	
		// Methods
		protected override void OnUpdate() {} // 0x00000001872932A0-0x0000000187293B20
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187293B20-0x0000000187293C40
		public override void OnMusicBeat() {} // 0x0000000187293C40-0x0000000187293C70
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x019784C6 */, float damageKb = 1f /* Metadata: 0x019784C7 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x019784CB */, bool hasKb = true /* Metadata: 0x019784CC */) {} // 0x0000000187293C70-0x0000000187294060
		protected override void OnRecycleEnemy() {} // 0x0000000187294060-0x00000001872940E0
		public virtual void TurnBlue() {} // 0x00000001872940E0-0x0000000187294220
		public virtual void TurnRed() {} // 0x0000000187294220-0x0000000187294360
		private static float Approach(float start, float end, float shift) => default; // 0x00000001865D5720-0x00000001865D5740
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Objects.Pools;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GattiScratchProjectile : Projectile // TypeDefIndex: 15884
	{
		// Fields
		[SerializeField]
		private FrameConfig[] _configs; // 0xD0
		private GattiWeapon _trueWeapon; // 0xD8
		private MultiTargetTween _entryTween; // 0xE0
		private MultiTargetTween _exitTween; // 0xE8
		private int _cfgIndex; // 0xF0
	
		// Constructors
		public GattiScratchProjectile() {} // 0x0000000186E234A0-0x0000000186E234F0
	
		// Methods
		protected override void Awake() {} // 0x0000000186BB4A00-0x0000000186BB4A10
		public override void InitProjectile(BulletPool pool, Weapon weapon, int index) {} // 0x0000000186E22CF0-0x0000000186E234A0
	}
}

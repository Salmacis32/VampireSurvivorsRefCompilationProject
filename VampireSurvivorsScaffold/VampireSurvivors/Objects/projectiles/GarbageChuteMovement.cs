/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Weapons;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Projectiles
{
	public class GarbageChuteMovement // TypeDefIndex: 15443
	{
		// Fields
		[NonSerialized]
		public PhaserSprite ChuteSprite; // 0x10
		[NonSerialized]
		public PhaserSprite ChuteSpriteLeft; // 0x18
		[NonSerialized]
		public PhaserSprite ChuteSpriteRight; // 0x20
		[NonSerialized]
		public MultiTargetTween ChuteMoveTweens; // 0x28
		[NonSerialized]
		public bool ChuteActive; // 0x30
		[NonSerialized]
		public bool ChuteFollowingScreen; // 0x31
		[NonSerialized]
		public float ChuteOffsetX; // 0x34
		[NonSerialized]
		public float ChuteOffsetY; // 0x38
		private float _chuteSpeed; // 0x3C
		private GarbageChuteWeapon _trueWeapon; // 0x40
		private int _chuteIndex; // 0x48
		private VampireSurvivors.Framework.TimerSystem.Timer _moveChuteTimer; // 0x50
		private VampireSurvivors.Framework.TimerSystem.Timer _projectileStartTimer; // 0x58
		private VampireSurvivors.Framework.TimerSystem.Timer _projectileEndTimer; // 0x60
		private VampireSurvivors.Framework.TimerSystem.Timer _projectileLeftScreenTimer; // 0x68
	
		// Constructors
		public GarbageChuteMovement() {} // 0x0000000186C01800-0x0000000186C01810
	
		// Methods
		public void createChute(GarbageChuteWeapon weapon, int index) {} // 0x0000000186BFFC20-0x0000000186BFFD20
		public void startChute() {} // 0x0000000186BFFD20-0x0000000186C006C0
		private void moveChuteAcross() {} // 0x0000000186C006C0-0x0000000186C00B80
		private void moveChuteDown() {} // 0x0000000186C00B80-0x0000000186C01050
		private void hideChute() {} // 0x0000000186C01050-0x0000000186C01440
		public void ManuallyHideChute() {} // 0x0000000186C01440-0x0000000186C014D0
		private float calcNewChuteXPos() => default; // 0x0000000186C014D0-0x0000000186C016F0
		public void Cleanup() {} // 0x0000000186C016F0-0x0000000186C01800
	}
}

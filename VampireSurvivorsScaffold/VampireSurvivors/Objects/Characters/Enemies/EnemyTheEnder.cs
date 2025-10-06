/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Characters;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemyTheEnder : EnemyController // TypeDefIndex: 17409
	{
		// Fields
		private SpriteRenderer _ringSprite; // 0x270
		private float _totalTime; // 0x278
		private float _scytheTime; // 0x27C
		private float _shieldDamage; // 0x280
		private int _deathScreamTimerLoopCount; // 0x284
		private bool _hasShield; // 0x288
		private bool _hasRunDeathLogic; // 0x289
		private VampireSurvivors.Framework.TimerSystem.Timer _shieldTimer; // 0x290
		private VampireSurvivors.Framework.TimerSystem.Timer _aiTimer; // 0x298
		private VampireSurvivors.Framework.TimerSystem.Timer _deathScreamTimer; // 0x2A0
		private ObjectPool _explosionPool; // 0x2A8
		private DiContainer _diContainer; // 0x2B0
		protected float _attacksDurationMultiplier; // 0x2B8
		private readonly List<string> _defaultBag1; // 0x2C0
		private readonly List<string> _defaultBag2; // 0x2C8
		private readonly List<string> _defaultBag3; // 0x2D0
		private readonly List<string> _defaultBag4; // 0x2D8
		private readonly List<string> _defaultBag5; // 0x2E0
		private readonly List<string> _defaultBag6; // 0x2E8
		private readonly List<string> _defaultBag7; // 0x2F0
		private readonly List<string> _defaultBag8; // 0x2F8
	
		// Properties
		public Action OnDefeat { get; set; } // 0x000000018726E490-0x000000018726E4A0 0x000000018726E4A0-0x000000018726E500
		public virtual bool DropGospel { get; set; } // 0x00000001872A9C70-0x00000001872A9C80 0x00000001872A9C80-0x00000001872A9C90
		public virtual float ShieldTime { get; set; } // 0x00000001872A9C90-0x00000001872A9CA0 0x00000001872A9CA0-0x00000001872A9CB0
	
		// Constructors
		public EnemyTheEnder() {} // 0x00000001872AD9E0-0x00000001872AE310
	
		// Methods
		protected override void FakeConstruct() {} // 0x00000001872A9CB0-0x00000001872A9D60
		protected override void Awake() {} // 0x000000018723A3D0-0x000000018723A3E0
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x00000001872A9D60-0x00000001872AA420
		public override void GetDamaged(float value, HitVfxType showHitVfx = HitVfxType.Default /* Metadata: 0x01978527 */, float damageKb = 1f /* Metadata: 0x01978528 */, WeaponType damageType = WeaponType.VOID /* Metadata: 0x0197852C */, bool hasKb = true /* Metadata: 0x0197852D */) {} // 0x00000001872AA420-0x00000001872AA830
		protected override void OnUpdate() {} // 0x00000001872AA830-0x00000001872AA9D0
		private void StartVerySmartAI() {} // 0x00000001872AA9D0-0x00000001872AAAE0
		private void ThrowScythe() {} // 0x00000001872AAAE0-0x00000001872AABD0
		private void TriggerExplosion() {} // 0x00000001872AABD0-0x00000001872AADD0
		private void SpawnDamagingZonesOnline(string skinType) {} // 0x00000001872AADD0-0x00000001872AB560
		private void SpawnDamagingZonesLocally(string skinType) {} // 0x00000001872AB560-0x00000001872ABA00
		public override void Disappear() {} // 0x00000001872ABA00-0x00000001872ABA50
		protected override void Die() {} // 0x00000001872ABA00-0x00000001872ABA50
		private bool CanRunDeathLogic() => default; // 0x00000001872ABA50-0x00000001872ABAA0
		[Command]
		public void OnlineDeath(long startingSimFrame) {} // 0x00000001872ABAA0-0x00000001872ABB80
		private void FireCustomDeathLogic() {} // 0x00000001872ABB80-0x00000001872ABCD0
		private void CustomDeathLogic() {} // 0x00000001872ABCD0-0x00000001872AC740
		protected void DeathScream() {} // 0x00000001872AC740-0x00000001872ACB10
		protected virtual void SpecialDeathAnimation() {} // 0x00000001872ACB10-0x00000001872ACCC0
		[Command]
		public void OnlineDamagingZone_Weapons(float xOffset, bool follow, float duration) {} // 0x00000001872ACCC0-0x00000001872ACCD0
		private void DamagingZone_Weapons(float xOffset = 0f /* Metadata: 0x0197852E */, bool follow = false /* Metadata: 0x01978532 */, float duration = 10000f /* Metadata: 0x01978533 */) {} // 0x00000001872ACCD0-0x00000001872AD000
		[Command]
		public void OnlineDamagingZone_Coffins(float xOffset, bool follow, float duration) {} // 0x00000001872AD000-0x00000001872AD010
		private void DamagingZone_Coffins(float xOffset = 0f /* Metadata: 0x01978537 */, bool follow = false /* Metadata: 0x0197853B */, float duration = 10000f /* Metadata: 0x0197853C */) {} // 0x00000001872AD010-0x00000001872AD340
		[Command]
		public void OnlineDamagingZone_Trainees(float yOffset, bool follow, float duration) {} // 0x00000001872AD340-0x00000001872AD350
		private void DamagingZone_Trainees(float yOffset = 0f /* Metadata: 0x01978540 */, bool follow = false /* Metadata: 0x01978544 */, float duration = 5000f /* Metadata: 0x01978545 */) {} // 0x00000001872AD350-0x00000001872AD690
		[Command]
		public void OnlineDamagingZone_Explosions(float yOffset, bool follow, float duration) {} // 0x00000001872AD690-0x00000001872AD6A0
		private void DamagingZone_Explosions(float yOffset = 0f /* Metadata: 0x01978549 */, bool follow = false /* Metadata: 0x0197854D */, float duration = 5000f /* Metadata: 0x0197854E */) {} // 0x00000001872AD6A0-0x00000001872AD9E0
	}
}

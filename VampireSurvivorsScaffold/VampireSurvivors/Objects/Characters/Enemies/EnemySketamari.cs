/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using DarkTonic.MasterAudio;
using UnityEngine;
using VampireSurvivors.App.Objects;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class EnemySketamari : EnemyController // TypeDefIndex: 17384
	{
		// Fields
		private GameObject _container; // 0x270
		private List<SpriteRenderer> _containerChildren; // 0x278
		private List<SpriteAnimation> _containerChildrenAnim; // 0x280
		private float _radius; // 0x288
		private EnemyType[] _enemiesArray; // 0x290
		private PlaySoundResult _noise; // 0x298
		private MultiTargetTween _onSineTween; // 0x2A0
		private float _maxDistance; // 0x2A8
		private MapToken _mapToken; // 0x2B0
		private float _angle; // 0x2B8
		private float _scale; // 0x2BC
		private float _sineF; // 0x2C0
	
		// Properties
		[Sync]
		public Quaternion ContainerRotation { get => default; set {} } // 0x00000001872996A0-0x0000000187299870 0x0000000187299870-0x0000000187299A00
	
		// Constructors
		public EnemySketamari() {} // 0x000000018729CDC0-0x000000018729D010
	
		// Methods
		public override void InitEnemy(EnemyType enemyType, bool asRemote) {} // 0x0000000187299A00-0x000000018729A610
		protected override void OnUpdate() {} // 0x000000018729A610-0x000000018729AF60
		private void MoveSketamari() {} // 0x000000018729AF60-0x000000018729B3C0
		protected override void Die() {} // 0x000000018729B3C0-0x000000018729B660
		public override void Disappear() {} // 0x000000018729B660-0x000000018729B740
		private float GetClosestPlayerDistance() => default; // 0x000000018729B740-0x000000018729BCC0
		private float GetDistanceToMyPlayer() => default; // 0x000000018729BCC0-0x000000018729BE40
		private void MakeSpritesDisappear() {} // 0x000000018729BE40-0x000000018729C320
		private void CheckDirection() {} // 0x000000018729C320-0x000000018729C5D0
		private void AddBones(int amount, float radiusMin, float radiusMax, float scaleMax, bool flipY) {} // 0x000000018729C5D0-0x000000018729CDC0
	}
}

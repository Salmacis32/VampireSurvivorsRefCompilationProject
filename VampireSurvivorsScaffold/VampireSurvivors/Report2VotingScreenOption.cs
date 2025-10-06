/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using VampireSurvivors.Framework.PhaserTweens;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class Report2VotingScreenOption : MonoBehaviour // TypeDefIndex: 13980
	{
		// Fields
		[SerializeField]
		private SpriteRenderer _nineSliceSprite; // 0x20
		[SerializeField]
		private SpriteRenderer _maskSprite; // 0x28
		[SerializeField]
		private SpriteMask _spriteMask; // 0x30
		[SerializeField]
		private SpriteRenderer _enemySprite; // 0x38
		[SerializeField]
		private SpriteRenderer _voteSprite; // 0x40
		private MultiTargetTween _voteTween; // 0x48
		private MultiTargetTween _screenShakeTween; // 0x50
	
		// Constructors
		public Report2VotingScreenOption() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Awake() {} // 0x0000000186981B10-0x0000000186981CD0
		public void SetVoteTargetSprite(Sprite sprite, Color tint) {} // 0x0000000186981CD0-0x0000000186981E80
		public void AddVote() {} // 0x0000000186981E80-0x0000000186982210
		public void ScreenShake(int repeats = 6 /* Metadata: 0x01976CA6 */) {} // 0x0000000186982210-0x00000001869827A0
		public void ClearVotes() {} // 0x00000001869827A0-0x0000000186982880
		public void Cleanup() {} // 0x0000000186982880-0x0000000186982970
	}
}

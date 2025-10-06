/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using VampireSurvivors.Data;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	public class BackgroundGreenAcres : BackgroundManager // TypeDefIndex: 15291
	{
		// Fields
		private bool _checkForEdgeOfTheWorld; // 0x80
		private bool _canFallOffTheEdge; // 0x81
		private float _worldEndX; // 0x84
		private float _worldEndY; // 0x88
		private bool _isOffTheEdge; // 0x8C
		private BgmType _savedBGM; // 0x90
		private BgmModType _savedBgmMod; // 0x94
		private TileSprite _missingBg; // 0x98
	
		// Constructors
		public BackgroundGreenAcres() {} // 0x0000000186A94680-0x0000000186A94690
	
		// Methods
		public override void Create() {} // 0x0000000186B44770-0x0000000186B44A10
		public void FallOffTheEdge() {} // 0x0000000186B44A10-0x0000000186B45900
		public void ResetTilemap() {} // 0x0000000186B45900-0x0000000186B46160
		public override void CheckMinute(int minute) {} // 0x0000000186B46160-0x0000000186B46440
		protected override void OnDestroy() {} // 0x0000000186B46440-0x0000000186B464B0
		protected override void OnUpdate() {} // 0x0000000186B464B0-0x0000000186B46720
		private void LateUpdate() {} // 0x0000000186B46720-0x0000000186B46910
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Toolkit;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters
{
	public class FB_Simondo : CharacterController_FirstBlood // TypeDefIndex: 17028
	{
		// Fields
		private float _spawnPickupsDelay; // 0x410
		private float _spawnPickupsTime; // 0x414
		private VampireSurvivors.Framework.TimerSystem.Timer _activationTimer; // 0x418
		private List<VampireSurvivors.Data.ItemType> _pickupTypes; // 0x420
		private PhaserSprite _highlight; // 0x428
	
		// Constructors
		public FB_Simondo() {} // 0x000000018714D2E0-0x000000018714D4D0
	
		// Methods
		public override void AfterFullInitialization() {} // 0x000000018714C600-0x000000018714C6F0
		public float SpawnPickupsInterval() => default; // 0x000000018714C6F0-0x000000018714C730
		protected override void OnUpdate() {} // 0x000000018714C730-0x000000018714C8D0
		private void CriticalHP() {} // 0x000000018714C8D0-0x000000018714C8E0
		private void SpawnPickups(int extra = 0 /* Metadata: 0x01977FD7 */) {} // 0x000000018714C8E0-0x000000018714CC50
		private void SpawnSingle(float x, float y, VampireSurvivors.Data.ItemType itemType, float delay) {} // 0x000000018714CC50-0x000000018714CDC0
		[Command]
		public void ShowHighlightOnline(float x, float y, float delay) {} // 0x000000018714CDC0-0x000000018714CDD0
		private void ShowHighlight(float x, float y, float detune) {} // 0x000000018714CDD0-0x000000018714D2E0
	}
}

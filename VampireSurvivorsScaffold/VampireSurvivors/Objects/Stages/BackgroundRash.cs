/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Graphics.Blitters;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Stages
{
	[UsedImplicitly]
	public class BackgroundRash : BackgroundManager // TypeDefIndex: 15301
	{
		// Fields
		private bool _canShowPizzas; // 0x80
		private bool _pizzaTriggered; // 0x81
		private bool _arePizzasVisible; // 0x82
		private MultiTargetTween _pizzaTween; // 0x88
		private object[] _pizzaSprites; // 0x90
		private Blitter _blitter; // 0x98
		private bool _spawnAtlasRelic; // 0xA0
	
		// Constructors
		public BackgroundRash() {} // 0x0000000186B56370-0x0000000186B56380
	
		// Methods
		public override void Create() {} // 0x0000000186B538C0-0x0000000186B54020
		public override void CheckMinute(int minute) {} // 0x0000000186B54020-0x0000000186B54120
		protected override void OnDestroy() {} // 0x0000000186B54120-0x0000000186B54190
		protected override void OnUpdate() {} // 0x0000000186B54190-0x0000000186B54770
		private void ShowPizzas() {} // 0x0000000186B54770-0x0000000186B54920
		private void HidePizzas() {} // 0x0000000186B54920-0x0000000186B54AD0
		private void CheckPizzas(CharacterController character) {} // 0x0000000186B54AD0-0x0000000186B54E90
		private void MakeBlitters() {} // 0x0000000186B54E90-0x0000000186B560A0
		private void UpdateBlitter() {} // 0x0000000186B560A0-0x0000000186B56370
	}
}

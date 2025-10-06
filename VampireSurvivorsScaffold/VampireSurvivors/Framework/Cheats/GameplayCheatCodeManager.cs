/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using VampireSurvivors.Framework;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Cheats
{
	public class GameplayCheatCodeManager : CheatCodeManager // TypeDefIndex: 18374
	{
		// Fields
		private GameManager _gameManager; // 0x30
		private bool _hasPetTheGoodDoggy; // 0x38
	
		// Constructors
		public GameplayCheatCodeManager() {} // 0x0000000186741D90-0x0000000186741DA0
	
		// Methods
		[Inject]
		private void Construct(GameManager gameManager) {} // 0x0000000180B1D520-0x0000000180B1D580
		public override void InternalUpdate() {} // 0x00000001867423E0-0x0000000186742500
		private void CheckForControllerPet() {} // 0x0000000186742500-0x0000000186742610
		protected override void AddCheatCodeCombos() {} // 0x0000000186742610-0x0000000186742C50
		private void PraiseTheGoodDoggy() {} // 0x0000000186742C50-0x0000000186742CF0
		private void UnlockHumbug() {} // 0x0000000186742CF0-0x0000000186742E80
	}
}

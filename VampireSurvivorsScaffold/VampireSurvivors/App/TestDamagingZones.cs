/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using QFSW.MOP2;
using UnityEngine;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.TimerSystem;
using VampireSurvivors.Objects.Pools;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App
{
	public class TestDamagingZones : GameMonoBehaviour // TypeDefIndex: 18504
	{
		// Fields
		private GameSessionData _gameSessionData; // 0x28
		private ObjectPool _explosionPool; // 0x30
		private DiContainer _diContainer; // 0x38
		private DamagingZonePool_Ophion _damagingZonePoolOphion; // 0x40
		private VampireSurvivors.Framework.TimerSystem.Timer _damagingZonesEvent; // 0x48
	
		// Properties
		protected Camera MainCamera { get => default; } // 0x000000018678FD00-0x000000018678FD10 
	
		// Constructors
		public TestDamagingZones() {} // 0x0000000184C44C90-0x0000000184C44CE0
	
		// Methods
		[Inject]
		private void Construct(GameSessionData gameSessionData, DiContainer diContainer) {} // 0x000000018678FD10-0x000000018678FDC0
		private void TestWeapons() {} // 0x000000018678FDC0-0x000000018678FF00
		private void TestCoffins() {} // 0x000000018678FF00-0x0000000186790040
		private void TestTrainees() {} // 0x0000000186790040-0x0000000186790180
		private void TestExplosions() {} // 0x0000000186790180-0x00000001867902C0
		private void TestOphion() {} // 0x00000001867902C0-0x0000000186790530
		private void CancelOphion() {} // 0x0000000186790530-0x0000000186790550
		private void DamagingZone_Weapons(float xOffset = 0f /* Metadata: 0x0197A9D6 */, bool follow = false /* Metadata: 0x0197A9DA */, float duration = 10000f /* Metadata: 0x0197A9DB */) {} // 0x0000000186790550-0x0000000186790870
		private void DamagingZone_Coffins(float xOffset = 0f /* Metadata: 0x0197A9DF */, bool follow = false /* Metadata: 0x0197A9E3 */, float duration = 10000f /* Metadata: 0x0197A9E4 */) {} // 0x0000000186790870-0x0000000186790B90
		private void DamagingZone_Trainees(float yOffset = 0f /* Metadata: 0x0197A9E8 */, bool follow = false /* Metadata: 0x0197A9EC */, float duration = 5000f /* Metadata: 0x0197A9ED */) {} // 0x0000000186790B90-0x0000000186790EC0
		private void DamagingZone_Explosions(float yOffset = 0f /* Metadata: 0x0197A9F1 */, bool follow = false /* Metadata: 0x0197A9F5 */, float duration = 5000f /* Metadata: 0x0197A9F6 */) {} // 0x0000000186790EC0-0x00000001867911F0
		private void FireOphion(float delay, float radius, int times) {} // 0x00000001867911F0-0x00000001867913D0
	}
}

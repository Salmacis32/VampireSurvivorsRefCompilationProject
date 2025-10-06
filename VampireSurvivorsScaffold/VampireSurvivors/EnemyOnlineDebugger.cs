/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Objects.Characters;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class EnemyOnlineDebugger : MonoBehaviour // TypeDefIndex: 14018
	{
		// Fields
		public Material material; // 0x20
		private LineRenderer _errorLineRenderer; // 0x28
		private LineRenderer _velocityLineRenderer; // 0x30
		private EnemyController _enemy; // 0x38
		private SpriteRenderer _enemyRenderer; // 0x40
		private Vector3 _latestRemotePosition; // 0x48
		private bool _init; // 0x54
	
		// Properties
		public static bool EnableDebugPosition { get; set; } // 0x0000000186ADD5E0-0x0000000186ADD620 0x0000000186ADD620-0x0000000186ADD660
		public static bool EnableDebugAuthority { get; set; } // 0x0000000186ADD660-0x0000000186ADD6A0 0x0000000186ADD6A0-0x0000000186ADD6F0
	
		// Constructors
		public EnemyOnlineDebugger() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x0000000186ADD6F0-0x0000000186ADDBB0
		private void InitEnemy() {} // 0x0000000186ADDBB0-0x0000000186ADDCF0
		private bool IsSynced() => default; // 0x0000000186ADDCF0-0x0000000186ADDE10
		private void OnDisable() {} // 0x0000000186ADDE10-0x0000000186ADDE20
		private void DisableLineRenderers() {} // 0x0000000186ADDE20-0x0000000186ADDFD0
		private void OnNetworkSampleReceived(object positionSample, bool stopped, long _) {} // 0x0000000186ADDFD0-0x0000000186ADE050
		private LineRenderer CreateLineRenderer(string goName, Color color) => default; // 0x0000000186ADE050-0x0000000186ADE490
		private void LateUpdate() {} // 0x0000000186ADE490-0x0000000186ADED00
		private void SetPositionCount(LineRenderer renderer) {} // 0x0000000186ADED00-0x0000000186ADEDC0
	}
}

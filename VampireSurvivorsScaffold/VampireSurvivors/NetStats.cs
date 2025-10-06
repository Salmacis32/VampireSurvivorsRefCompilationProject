/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coherence.Connection;
using Coherence.Toolkit;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class NetStats : MonoBehaviour // TypeDefIndex: 14024
	{
		// Fields
		public KeyCode toggleKey; // 0x20
		private static NetStats _instance; // 0x00
		private bool display; // 0x24
		private bool registeredOnDisconnected; // 0x25
		private const int PacketsGraph = 1; // Metadata: 0x01976CD5
		private const int BandwidthGraph = 2; // Metadata: 0x01976CD6
		private const int UpdatesGraph = 3; // Metadata: 0x01976CD7
		private const int EnemyCountGraph = 4; // Metadata: 0x01976CD8
		private const int PingGraph = 5; // Metadata: 0x01976CD9
	
		// Properties
		public static NetStats Instance { get => default; } // 0x0000000186AE26C0-0x0000000186AE2700 
	
		// Constructors
		public NetStats() {} // 0x0000000186AE35C0-0x0000000186AE3610
	
		// Methods
		public void Toggle() {} // 0x0000000186AE2700-0x0000000186AE2720
		private void Start() {} // 0x0000000186AE2720-0x0000000186AE27D0
		private void OnDisconnected(CoherenceBridge _, ConnectionCloseReason __) {} // 0x0000000186AE27D0-0x0000000186AE27F0
		private void RegisterOnDisconnectedEvent() {} // 0x0000000186AE27F0-0x0000000186AE2930
		private void CheckDisplayToggle() {} // 0x0000000186AE2930-0x0000000186AE29B0
		private void DrawGraphs() {} // 0x0000000186AE29B0-0x0000000186AE3270
		private static void RemoveGraphs() {} // 0x0000000186AE3270-0x0000000186AE34A0
		private static void Graph(string key, string label, float min, float max, int graph, Color color, float value) {} // 0x0000000186AE34A0-0x0000000186AE35C0
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI.Bestiary
{
	public class UISketamari : MonoBehaviour // TypeDefIndex: 18543
	{
		// Fields
		[SerializeField]
		private float _Speed; // 0x20
		[SerializeField]
		private GameObject _BonesParent; // 0x28
		private DataManager _dataManager; // 0x30
		private readonly EnemyType[] _enemiesArray; // 0x38
	
		// Constructors
		public UISketamari() {} // 0x00000001867CA160-0x00000001867CA260
	
		// Methods
		private void Awake() {} // 0x00000001867C9520-0x00000001867C9650
		private void Update() {} // 0x00000001867C9650-0x00000001867C9750
		private void OnDestroy() {} // 0x00000001867C9750-0x00000001867C9830
		public void Generate(DataManager dataManager) {} // 0x00000001867C9830-0x00000001867C9990
		private void AddBones(GameObject container, int amount, float radiusMin, float radiusMax, float scaleMax, bool flipY) {} // 0x00000001867C9990-0x00000001867CA160
	}
}

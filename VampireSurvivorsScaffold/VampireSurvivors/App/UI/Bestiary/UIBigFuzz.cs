/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Framework.PhaserTweens;
using VampireSurvivors.Framework.TimerSystem;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.UI.Bestiary
{
	public class UIBigFuzz : MonoBehaviour // TypeDefIndex: 18540
	{
		// Fields
		[SerializeField]
		private Image body; // 0x20
		[SerializeField]
		private Image head; // 0x28
		[SerializeField]
		private Image leftHand; // 0x30
		[SerializeField]
		private Image rightHand; // 0x38
		[SerializeField]
		private Image leftDoor; // 0x40
		[SerializeField]
		private Image rightDoor; // 0x48
		private MultiTargetTween doorOpenTween; // 0x50
		private VampireSurvivors.Framework.TimerSystem.Timer rightHandTimer; // 0x58
		private VampireSurvivors.Framework.TimerSystem.Timer leftHandTimer; // 0x60
		private VampireSurvivors.Framework.TimerSystem.Timer doorTimer; // 0x68
		public float doorOffset; // 0x70
		public float handOffset; // 0x74
	
		// Constructors
		public UIBigFuzz() {} // 0x0000000180B18150-0x0000000180B181A0
	
		// Methods
		private void Start() {} // 0x00000001867C7940-0x00000001867C7FE0
		private void OpenDoors() {} // 0x00000001867C7FE0-0x00000001867C8320
		protected void Update() {} // 0x00000001867C8320-0x00000001867C8FF0
	}
}

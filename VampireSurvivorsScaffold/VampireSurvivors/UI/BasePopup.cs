/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class BasePopup : MonoBehaviour // TypeDefIndex: 14697
	{
		// Fields
		protected List<GameObject> _spawned; // 0x20
		protected string _ID; // 0x28
		protected GameObject _previouslySelected; // 0x30
		private bool _refreshLayouts; // 0x38
		private Action _onClose; // 0x40
	
		// Constructors
		public BasePopup() {} // 0x0000000186798080-0x00000001867981F0
	
		// Methods
		public virtual void Show() {} // 0x0000000186796E70-0x0000000186796EA0
		public virtual void Hide() {} // 0x0000000186796EA0-0x00000001867971A0
		public void BaseInit(string id) {} // 0x00000001867971A0-0x00000001867972B0
		public void AddOnCloseCallback(Action cb) {} // 0x000000018260F820-0x000000018260F880
		protected void SetNavigationUp(Selectable origin, Selectable target = null) {} // 0x00000001867972B0-0x0000000186797510
		protected void SetNavigationDown(Selectable origin, Selectable target = null) {} // 0x0000000186797510-0x00000001867977A0
		protected void SetNavigationLeft(Selectable origin, Selectable target = null) {} // 0x00000001867977A0-0x0000000186797A30
		protected void SetNavigationRight(Selectable origin, Selectable target = null) {} // 0x0000000186797A30-0x0000000186797C90
		protected void SetNavigationMode(Selectable origin, Navigation.Mode mode) {} // 0x0000000186797C90-0x0000000186797CF0
		protected void ClearNavigationUp(Selectable origin) {} // 0x0000000186797CF0-0x0000000186797DC0
		protected void ClearNavigationDown(Selectable origin) {} // 0x0000000186797DC0-0x0000000186797E90
		protected void ClearNavigationLeft(Selectable origin) {} // 0x0000000186797E90-0x0000000186797F60
		protected void ClearNavigationRight(Selectable origin) {} // 0x0000000186797F60-0x0000000186798020
		private void LateUpdate() {} // 0x0000000186798020-0x0000000186798080
		protected void RefreshFormatting() {} // 0x00000001840B86C0-0x00000001840B86D0
	}
}

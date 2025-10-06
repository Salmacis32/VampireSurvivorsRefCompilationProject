/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.UI
{
	public class MobileConfig : MonoBehaviour // TypeDefIndex: 14868
	{
		// Fields
		[SerializeField]
		private bool _DEBUGTHIS; // 0x20
		[SerializeField]
		private bool _ShouldDisableInPortrait; // 0x21
		[SerializeField]
		private bool _ShouldDisableInLandscape; // 0x22
		[SerializeField]
		protected bool _ShouldReparent; // 0x23
		[SerializeField]
		protected bool _StealChildren; // 0x24
		[SerializeField]
		protected bool _WaitForFormatBeforeScaling; // 0x25
		[SerializeField]
		protected RectTransform _NewParent; // 0x28
		[SerializeField]
		protected bool _SetAsFirstSibling; // 0x30
		[SerializeField]
		protected bool _MatchSize; // 0x31
		[SerializeField]
		protected bool _ForcePositionReset; // 0x32
		[SerializeField]
		protected List<RectTransform> _ChildrenToSteal; // 0x38
		[SerializeField]
		protected bool _ShouldScaleToFitWidth; // 0x40
		[SerializeField]
		protected bool _ShouldForceRectTransformSize; // 0x41
		[SerializeField]
		protected Vector2 _ForcedSize; // 0x44
		[SerializeField]
		protected bool _ShouldAnchorPosFromRelativePosition; // 0x4C
		[SerializeField]
		protected Vector2 _RelativeAnchorPosition; // 0x50
		[SerializeField]
		protected bool _ShouldExtendRectTransformToFillScreenY; // 0x58
		[SerializeField]
		protected List<RectTransform> _objectsToExtend; // 0x60
		[SerializeField]
		protected float _Padding; // 0x68
		[SerializeField]
		protected float _MaxHeightPercentage; // 0x6C
		[SerializeField]
		protected float _MaxWidthPercentage; // 0x70
		protected float _myWidth; // 0x74
		protected float _screenWidth; // 0x78
		protected float _scaleAmount; // 0x7C
		protected List<float> _baseHeights; // 0x80
		protected Vector3 _baseScale; // 0x88
		protected bool _IsPortrait; // 0x94
		protected bool _hasInitialized; // 0x95
		private bool _doLateFormat; // 0x96
	
		// Constructors
		public MobileConfig() {} // 0x00000001868F1A80-0x00000001868F1C30
	
		// Methods
		protected virtual void Awake() {} // 0x00000001868F1250-0x00000001868F1560
		protected virtual void OnEnable() {} // 0x00000001868F1560-0x00000001868F15F0
		private void OnDisable() {} // 0x00000001868F15F0-0x00000001868F1670
		public virtual void OnResolutionChanged(Vector2 newRes) {} // 0x00000001868F1670-0x00000001868F1720
		[IteratorStateMachine(typeof(_ApplyRoutine_d__33))]
		private IEnumerator ApplyRoutine() => default; // 0x00000001868F1720-0x00000001868F17C0
		private void LateUpdate() {} // 0x00000001868F17C0-0x00000001868F1870
		protected virtual void Apply() {} // 0x00000001868F1870-0x00000001868F1A80
		public void Refresh() {} // 0x000000018324DF30-0x000000018324DF50
	}
}

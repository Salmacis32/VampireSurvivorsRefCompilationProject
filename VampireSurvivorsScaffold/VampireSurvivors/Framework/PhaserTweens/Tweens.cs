/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using VampireSurvivors.Framework.NumberTypes;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.PhaserTweens
{
	public class Tweens // TypeDefIndex: 18150
	{
		// Fields
		private static Dictionary<System.Type, Action<int, TweenConfig, DG.Tweening.Sequence>> targetTypeSwitch; // 0x00
		private static Dictionary<System.Type, Func<Action<object, object>, Func<object, object>, object, object, TweenConfig, int, Tween>> fieldTypeSwitch; // 0x08
		private static Dictionary<ValueTuple<System.Type, string>, CachedCustomField> customFieldCache; // 0x10
	
		// Constructors
		public Tweens() {} // 0x0000000180B15170-0x0000000180B15180
		static Tweens() {} // 0x00000001866D8F80-0x00000001866D9EF0
	
		// Methods
		public static Func<int, float> Stagger(float value, StaggerConfig config = null) => default; // 0x00000001866CFD70-0x00000001866CFEE0
		public static MultiTargetTween Add(TweenConfig config) => default; // 0x00000001866CFEE0-0x00000001866D0AC0
		private static Action<object, object> CompileFieldSetter(System.Type type, FieldInfo fieldInfo) => default; // 0x00000001866D0AC0-0x00000001866D0E10
		private static Func<object, object> CompileFieldGetter(System.Type type, FieldInfo fieldInfo) => default; // 0x00000001866D0E10-0x00000001866D10A0
		private static Action<object, object> CompilePropertySetter(System.Type type, PropertyInfo fieldInfo) => default; // 0x00000001866D10A0-0x00000001866D13F0
		private static Func<object, object> CompilePropertyGetter(System.Type type, PropertyInfo fieldInfo) => default; // 0x00000001866D13F0-0x00000001866D1680
		private static void HandleYoyo(TweenConfig config) {} // 0x00000001866D1680-0x00000001866D16D0
		private static void AddOnComplete(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D16D0-0x00000001866D1790
		private static void AddOnStart(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D1790-0x00000001866D1850
		private static void AddOnStop(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D1850-0x00000001866D1910
		private static void AddOnYoyo(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D1910-0x00000001866D1AC0
		private static void AddOnRepeat(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D1AC0-0x00000001866D1CD0
		private static void AddOnUpdate(TweenConfig config, DG.Tweening.Sequence sequence, MultiTargetTween multiTargetTween) {} // 0x00000001866D1CD0-0x00000001866D1E60
		private static void AddDelay(int targetIndex, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D1E60-0x00000001866D2260
		private static void AddRepeatDelay(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2260-0x00000001866D22D0
		private static void AddRepeat(TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D22D0-0x00000001866D2390
		private static void AddDelaysAndRepeats(int targetIndex, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2390-0x00000001866D24F0
		private static void AddTransformTweens(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D24F0-0x00000001866D2690
		private static void AddMoveX(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2690-0x00000001866D28B0
		private static void AddMoveY(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D28B0-0x00000001866D2AD0
		private static void AddLocalMoveX(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2AD0-0x00000001866D2CF0
		private static void AddLocalMoveY(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2CF0-0x00000001866D2F10
		private static void AddScale(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D2F10-0x00000001866D3130
		private static void AddScaleX(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3130-0x00000001866D3350
		private static void AddScaleY(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3350-0x00000001866D3570
		private static void AddAngle(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3570-0x00000001866D37C0
		private static void AddLocalAngle(int targetIndex, Transform target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D37C0-0x00000001866D3A10
		private static void AddSpriteTweens(int targetIndex, SpriteRenderer target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3A10-0x00000001866D3AA0
		private static void AddAlphaAndTint(int targetIndex, SpriteRenderer target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3AA0-0x00000001866D3F20
		private static void AddTileSpriteTweens(int targetIndex, TileSprite target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3F20-0x00000001866D3FC0
		private static void AddAlpha(int targetIndex, TileSprite target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D3FC0-0x00000001866D41E0
		private static void AddTileScaleTweens(int targetIndex, TileSprite target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D41E0-0x00000001866D45A0
		private static void AddTilemapTweens(int targetIndex, Tilemap target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D45A0-0x00000001866D4630
		private static void AddAlpha(int targetIndex, Tilemap target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4630-0x00000001866D49C0
		private static void AddTextMeshProTweens(int targetIndex, TextMeshPro target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D49C0-0x00000001866D4A50
		private static void AddTextMeshProUGUITweens(int targetIndex, TextMeshProUGUI target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4A50-0x00000001866D4AE0
		private static void AddAlpha(int targetIndex, TextMeshPro target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4AE0-0x00000001866D4D00
		private static void AddAlphaUGUI(int targetIndex, TextMeshProUGUI target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4D00-0x00000001866D4F20
		private static void AddTextMeshTweens(int targetIndex, TextMesh target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4F20-0x00000001866D4FB0
		private static void AddAlpha(int targetIndex, TextMesh target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D4FB0-0x00000001866D5470
		private static void AddMaterialTweens(int targetIndex, Material target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D5470-0x00000001866D5500
		private static void AddAlpha(int targetIndex, Material target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D5500-0x00000001866D5720
		private static void AddArcadeSpriteTweens(int targetIndex, ArcadeSprite target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D5720-0x00000001866D57F0
		private static void AddPhaserSpriteTweens(int targetIndex, PhaserSprite target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D57F0-0x00000001866D58B0
		private static void AddPhaserTextTweens(int targetIndex, PhaserText target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D58B0-0x00000001866D5970
		private static void AddBitmapTextTweens(int targetIndex, BitmapText target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D5970-0x00000001866D5A30
		private static void AddCustomTweens(int targetIndex, object target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D5A30-0x00000001866D66D0
		private static Tween CustomTweenInt(int targetIndex, Action<object, object> setter, Func<object, object> getter, object target, object value, TweenConfig config) => default; // 0x00000001866D66D0-0x00000001866D6A60
		private static Tween CustomTweenFloat(int targetIndex, Action<object, object> setter, Func<object, object> getter, object target, object value, TweenConfig config) => default; // 0x00000001866D6A60-0x00000001866D6DF0
		private static Tween CustomTweenDouble(int targetIndex, Action<object, object> setter, Func<object, object> getter, object target, object value, TweenConfig config) => default; // 0x00000001866D6DF0-0x00000001866D7180
		private static void CustomTweenEggFloat(int targetIndex, object target, FieldInfo field, TweenConfig config, EggFloat value, DG.Tweening.Sequence sequence) {} // 0x00000001866D7180-0x00000001866D7690
		private static void CustomTweenEggDouble(int targetIndex, object target, FieldInfo field, TweenConfig config, EggDouble value, DG.Tweening.Sequence sequence) {} // 0x00000001866D7690-0x00000001866D7BA0
		private static void CustomTweenEggFloat(int targetIndex, object target, PropertyInfo field, TweenConfig config, EggFloat value, DG.Tweening.Sequence sequence) {} // 0x00000001866D7BA0-0x00000001866D80B0
		private static void CustomTweenEggDouble(int targetIndex, object target, PropertyInfo field, TweenConfig config, EggDouble value, DG.Tweening.Sequence sequence) {} // 0x00000001866D80B0-0x00000001866D85C0
		private static void AddBoxedVector2Tweens(int targetIndex, PhaserScene.BoxedVector2 target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D85C0-0x00000001866D8B00
		private static void AddUiImageTweens(int targetIndex, Image target, TweenConfig config, DG.Tweening.Sequence sequence) {} // 0x00000001866D8B00-0x00000001866D8F80
	}
}

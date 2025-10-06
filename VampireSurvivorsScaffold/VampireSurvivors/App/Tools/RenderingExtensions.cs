/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;
using VampireSurvivors;
using VampireSurvivors.Framework;
using VampireSurvivors.Framework.Particles;
using VampireSurvivors.Framework.Phaser;
using VampireSurvivors.Graphics;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Tools
{
	public static class RenderingExtensions // TypeDefIndex: 18550
	{
		// Fields
		private static ParticleSystem.Particle[] _cachedParticles; // 0x00
		private static readonly int ApplyTint; // 0x08
		private static readonly int TintColor; // 0x0C
		private static readonly int ApplyTintFill; // 0x10
		private static readonly int TintFillColor; // 0x14
		private static Dictionary<int, Sprite> s_circleCache; // 0x18
		private static Shader s_atlasRectTrailShader; // 0x20
		private static Shader s_atlasRectTrailAdditiveShader; // 0x28
		private static int s_atlasRectTrailRectPropertyID; // 0x30
	
		// Constructors
		static RenderingExtensions() {} // 0x00000001867DD460-0x00000001867DD790
	
		// Methods
		private static Color32 HexToColor(uint hexVal) => default; // 0x00000001863F55D0-0x00000001863F55F0
	
		// Extension methods
		public static T SetAngle<T>(this T component, float angle, bool phaserSpace = true /* Metadata: 0x0197AA19 */)
			where T : Component => default;
		public static T SetScale<T>(this T component, float scale)
			where T : Component => default;
		public static T SetScale<T>(this T component, float xScale, float yScale)
			where T : Component => default;
		public static void SetAlpha(this Image image, float alpha) {} // 0x00000001867CDA90-0x00000001867CDB30
		public static TrailRenderer SetAlpha(this TrailRenderer trail, float alpha) => default; // 0x00000001867CDB30-0x00000001867CDC40
		public static TrailRenderer SetTint(this TrailRenderer trail, uint tint) => default; // 0x00000001867CDC40-0x00000001867CDD90
		public static string ToHex(this Color color) => default; // 0x00000001867CDD90-0x00000001867CDFD0
		public static void SetTintEnabled(this MaterialPropertyBlock propBlock, bool isEnabled) {} // 0x00000001867CDFD0-0x00000001867CE0C0
		public static void SetTintColor(this MaterialPropertyBlock propBlock, Color tintColor) {} // 0x00000001867CE0C0-0x00000001867CE1A0
		public static void SetTintColor(this Material material, Color tintColor) {} // 0x00000001867CE1A0-0x00000001867CE2D0
		public static void SetTintFillEnabled(this MaterialPropertyBlock propBlock, bool isEnabled) {} // 0x00000001867CE2D0-0x00000001867CE3C0
		public static void SetTintFillEnabled(this Material material, bool isEnabled) {} // 0x00000001867CE3C0-0x00000001867CE450
		public static void SetTintFillColor(this MaterialPropertyBlock propBlock, Color tintColor) {} // 0x00000001867CE450-0x00000001867CE530
		public static void SetTintFillColor(this Material material, Color tintColor) {} // 0x00000001867CE530-0x00000001867CE660
		public static ParticleEmitterManager particles(this Factory behaviour, string texture = null) => default; // 0x00000001867CE660-0x00000001867CE730
		public static ParticleSystem SetAngle(this ParticleSystem component, ParticleSystem.MinMaxCurve angle, int angleSteps = 0 /* Metadata: 0x0197AA1A */) => default; // 0x00000001867CE730-0x00000001867CEA80
		public static ParticleSystem SetTint(this ParticleSystem component, uint tint) => default; // 0x00000001867CEA80-0x00000001867CEC70
		public static ParticleSystem SetTint(this ParticleSystem component, uint startTint, uint endTint) => default; // 0x00000001867CEC70-0x00000001867CEEF0
		public static ParticleSystem SetGravity(this ParticleSystem component, ParticleSystem.MinMaxCurve gravity) => default; // 0x00000001867CEEF0-0x00000001867CEFC0
		public static ParticleSystem SetScale(this ParticleSystem component, float scale) => default; // 0x00000001867CEFC0-0x00000001867CF210
		public static void SetScale(this ParticleSystem pfx, ParticleSystem.MinMaxCurve scale) {} // 0x00000001867CF210-0x00000001867CF450
		public static void SetScaleX(this ParticleSystem pfx, ParticleSystem.MinMaxCurve scale) {} // 0x00000001867CF450-0x00000001867CF690
		public static void SetScaleY(this ParticleSystem pfx, ParticleSystem.MinMaxCurve scale) {} // 0x00000001867CF690-0x00000001867CF8D0
		public static void SetEmitZone(this ParticleSystem pfx, EmitZone emitZone) {} // 0x00000001867CF8D0-0x00000001867D04E0
		public static void SetQuantity(this ParticleSystem pfx, int quantity) {} // 0x00000001867D04E0-0x00000001867D0810
		public static void SetFrame(this ParticleSystem pfx, int frame) {} // 0x00000001867D0810-0x00000001867D08E0
		public static void SetFrames(this ParticleSystem pfx, List<string> frames, string spritesheet = null, bool clearExistingFrames = false /* Metadata: 0x0197AA1B */, int cycleCount = 0 /* Metadata: 0x0197AA1C */) {} // 0x00000001867D08E0-0x00000001867D0E50
		public static void SetSpeed(this ParticleSystem pfx, float min = 0f /* Metadata: 0x0197AA1D */, float max = 0f /* Metadata: 0x0197AA21 */) {} // 0x00000001867D0E50-0x00000001867D1060
		public static void SetSpeedX(this ParticleSystem pfx, ParticleSystem.MinMaxCurve value) {} // 0x00000001867D1060-0x00000001867D12B0
		public static void SetSpeedY(this ParticleSystem pfx, ParticleSystem.MinMaxCurve value) {} // 0x00000001867D12B0-0x00000001867D1500
		public static void SetCollisionBounds(this ParticleSystem particleSystem, ParticleSystemConfig config) {} // 0x00000001867D1500-0x00000001867D2E10
		public static void SetCollisionBoundsWorld(this ParticleSystem particleSystem, ParticleSystemConfig config) {} // 0x00000001867D2E10-0x00000001867D46A0
		public static void SetCollisionBoundsCircle(this ParticleSystem particleSystem, ParticleSystemConfig config) {} // 0x00000001867D46A0-0x00000001867D4E50
		public static void Start(this ParticleSystem pfx) {} // 0x00000001867D4E50-0x00000001867D4F20
		public static void StopEmitting(this ParticleSystem pfx) {} // 0x00000001867D4F20-0x00000001867D4FE0
		public static void ForceClear(this ParticleSystem pfx) {} // 0x00000001867D4FE0-0x00000001867D5100
		public static float GetRemainingLifetime(this ParticleSystem pfx) => default; // 0x00000001867D5100-0x00000001867D5480
		public static void EmitParticleAt(this ParticleSystem system, Vector2 pos, int count = -1 /* Metadata: 0x0197AA25 */) {} // 0x00000001867D5480-0x00000001867D5820
		public static void SetAlpha(this ParticleSystem system, ParticleSystem.MinMaxCurve value, Easing easing = Easing.Linear /* Metadata: 0x0197AA26 */) {} // 0x00000001867D5820-0x00000001867D5BB0
		public static void SetMaxParticles(this ParticleSystem ps, int maxParticles = 1000 /* Metadata: 0x0197AA27 */) {} // 0x00000001867D5BB0-0x00000001867D5C70
		public static Texture2D ConvertToTexture(this Sprite sprite, bool generateMipMaps = false /* Metadata: 0x0197AA29 */) => default; // 0x00000001867D5C70-0x00000001867D6110
		public static void SetAlpha(this Material material, float alpha) {} // 0x00000001867D6110-0x00000001867D6200
		public static TextMeshPro AddText(this MonoBehaviour monoBehaviour, Vector2 pos, string text) => default; // 0x00000001867D6200-0x00000001867D6290
		public static TextMeshPro AddText(this GameObject gameObject, Vector2 pos, string text) => default; // 0x00000001867D6290-0x00000001867D6540
		public static TextMeshPro SetAlpha(this TextMeshPro textMeshPro, float alpha) => default; // 0x00000001867D6540-0x00000001867D65E0
		public static TextMeshProUGUI SetAlpha(this TextMeshProUGUI textMeshPro, float alpha) => default; // 0x00000001867D6540-0x00000001867D65E0
		public static TextMeshPro SetTint(this TextMeshPro textMeshPro, params uint[] tints) => default; // 0x00000001867D65E0-0x00000001867D66C0
		public static TextMeshPro SetTint(this TextMeshPro textMeshPro, uint tint) => default; // 0x00000001867D66C0-0x00000001867D67A0
		public static TextMeshProUGUI SetTint(this TextMeshProUGUI textMeshPro, uint tint) => default; // 0x00000001867D66C0-0x00000001867D67A0
		public static SpriteRenderer SetFlipX(this SpriteRenderer spriteRenderer, bool flipX) => default; // 0x00000001867D67A0-0x00000001867D67D0
		public static SpriteRenderer SetFlipY(this SpriteRenderer spriteRenderer, bool flipY) => default; // 0x00000001867D67D0-0x00000001867D6800
		public static SpriteRenderer SetX(this SpriteRenderer spriteRenderer, float x) => default; // 0x00000001867D6800-0x00000001867D69A0
		public static SpriteRenderer SetY(this SpriteRenderer spriteRenderer, float y) => default; // 0x00000001867D69A0-0x00000001867D6B40
		public static SpriteRenderer SetVisible(this SpriteRenderer spriteRenderer, bool visible) => default; // 0x00000001867D6B40-0x00000001867D6B70
		public static SpriteRenderer SetName(this SpriteRenderer spriteRenderer, string name) => default; // 0x00000001867D6B70-0x00000001867D6BA0
		public static SpriteRenderer SetParent(this SpriteRenderer spriteRenderer, Transform parent, bool keepWorldPos = true /* Metadata: 0x0197AA2A */) => default; // 0x00000001867D6BA0-0x00000001867D6C00
		public static SpriteRenderer SetAlpha(this SpriteRenderer spriteRenderer, float alpha) => default; // 0x00000001867D6C00-0x00000001867D6D80
		public static SpriteRenderer SetBlendMode(this SpriteRenderer spriteRenderer, VampireSurvivors.Framework.Particles.BlendMode blendMode) => default; // 0x00000001867D6D80-0x00000001867D6E20
		public static SpriteRenderer SetTileMode(this SpriteRenderer spriteRenderer) => default; // 0x00000001867D6E20-0x00000001867D6F40
		public static SpriteRenderer SetTintFill(this SpriteRenderer spriteRenderer, bool isEnabled, Color? tintColor = default) => default; // 0x00000001867D6F40-0x00000001867D71C0
		public static SpriteRenderer SetTint(this SpriteRenderer spriteRenderer, params uint[] tints) => default; // 0x00000001867D71C0-0x00000001867D72A0
		public static PhaserSprite SetTint(this PhaserSprite target, Color topLeft, Color topRight, Color bottomLeft, Color bottomRight, VampireSurvivors.Framework.Particles.BlendMode blendMode = VampireSurvivors.Framework.Particles.BlendMode.Normal /* Metadata: 0x0197AA2B */) => default; // 0x00000001867D72A0-0x00000001867D73A0
		public static PhaserSprite SetTint(this PhaserSprite target, uint topLeft, uint topRight, uint bottomLeft, uint bottomRight, VampireSurvivors.Framework.Particles.BlendMode blendMode = VampireSurvivors.Framework.Particles.BlendMode.Normal /* Metadata: 0x0197AA2C */) => default; // 0x00000001867D73A0-0x00000001867D75F0
		public static SpriteRenderer SetTint(this SpriteRenderer spriteRenderer, Color topLeft, Color topRight, Color bottomLeft, Color bottomRight, VampireSurvivors.Framework.Particles.BlendMode blendMode) => default; // 0x00000001867D75F0-0x00000001867D7D10
		public static SpriteRenderer FillStyle(this SpriteRenderer spriteRenderer, uint tint, float alpha) => default; // 0x00000001867D7D10-0x00000001867D7D90
		public static SpriteRenderer FillCircle(this SpriteRenderer spriteRenderer, int radius, uint colourHex = 16777215 /* Metadata: 0x0197AA2D */) => default; // 0x00000001867D7D90-0x00000001867D81D0
		private static Texture2D GenerateCircle(this Texture2D tex, int x, int y, int r, Color color) => default; // 0x00000001867D81D0-0x00000001867D8300
		public static SpriteRenderer SetTint(this SpriteRenderer spriteRenderer, uint tint) => default; // 0x00000001867D8300-0x00000001867D84C0
		public static SpriteRenderer SetTint(this SpriteRenderer spriteRenderer, string tintString) => default; // 0x00000001867D84C0-0x00000001867D8600
		public static void SetTint(this SpriteRenderer spriteRenderer, Color? tint) {} // 0x00000001867D8600-0x00000001867D86E0
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, float x, float y, string textureName = null, string spriteName = null) => default; // 0x00000001867D86E0-0x00000001867D8780
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, float x, float y, SpriteTextureData sprite) => default; // 0x00000001867D8780-0x00000001867D8830
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, Vector2 pos, string textureName = null, string spriteName = null) => default; // 0x00000001867D8830-0x00000001867D88D0
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867D88D0-0x00000001867D8970
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this GameObject gameObject, float x, float y, string textureName = null, string spriteName = null) => default; // 0x00000001867D8970-0x00000001867D8A10
		public static SpriteRenderer AddSprite(this GameObject gameObject, float x, float y, SpriteTextureData sprite) => default; // 0x00000001867D8A10-0x00000001867D8AA0
		public static SpriteRenderer AddSprite(this GameObject gameObject, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867D8AA0-0x00000001867D8E50
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, float x, float y, Vector2 pivot, string textureName = null, string spriteName = null) => default; // 0x00000001867D8E50-0x00000001867D8F20
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, float x, float y, Vector2 pivot, SpriteTextureData sprite) => default; // 0x00000001867D8F20-0x00000001867D9000
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this GameObject gameObject, float x, float y, Vector2 pivot, string textureName = null, string spriteName = null) => default; // 0x00000001867D9000-0x00000001867D90B0
		public static SpriteRenderer AddSprite(this GameObject gameObject, float x, float y, Vector2 pivot, SpriteTextureData sprite) => default; // 0x00000001867D90B0-0x00000001867D9170
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, Vector2 pos, Vector2 pivot, string textureName = null, string spriteName = null) => default; // 0x00000001867D9170-0x00000001867D9220
		public static SpriteRenderer AddSprite(this MonoBehaviour behaviour, Vector2 pos, Vector2 pivot, SpriteTextureData sprite) => default; // 0x00000001867D9220-0x00000001867D92E0
		public static SpriteRenderer AddSprite(this GameObject gameObject, Vector2 pos, Vector2 pivot, SpriteTextureData sprite) => default; // 0x00000001867D92E0-0x00000001867D9380
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static SpriteRenderer AddSprite(this GameObject gameObject, Vector2 pos, Vector2 pivot, string textureName = null, string spriteName = null) => default; // 0x00000001867D9380-0x00000001867D9750
		public static ArcadeSprite SetParent(this ArcadeSprite arcadeSprite, Transform parent, bool keepWorldPos = true /* Metadata: 0x0197AA31 */) => default; // 0x00000001867D6BA0-0x00000001867D6C00
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static ArcadeSprite AddArcadeSprite(this MonoBehaviour behaviour, Vector2 pos, string textureName = null, string spriteName = null) => default; // 0x00000001867D9750-0x00000001867D97F0
		public static ArcadeSprite AddArcadeSprite(this MonoBehaviour behaviour, Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867D97F0-0x00000001867D9890
		public static ArcadeSprite AddArcadeSprite(this GameObject gameObject, Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867D9890-0x00000001867D9910
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static ArcadeSprite AddArcadeSprite(this GameObject gameObject, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867D9910-0x00000001867D9E00
		public static PhaserText text(this Factory behaviour, Vector2 pos, string text, Color color, float fontSize = 12f /* Metadata: 0x0197AA32 */) => default; // 0x00000001867D9E00-0x00000001867DA120
		public static BitmapText bitmapText(this Factory behaviour, Vector2 pos, string text, Color color, int fontSize = 12 /* Metadata: 0x0197AA36 */) => default; // 0x00000001867DA120-0x00000001867DA460
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static PhaserSprite sprite(this Factory behaviour, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867DA460-0x00000001867DA760
		public static PhaserSprite sprite(this Factory behaviour, Vector2 pos, SpriteTextureData spriteData) => default; // 0x00000001867DA760-0x00000001867DA7E0
		public static PhaserSprite circle(this Factory behaviour, Vector2 pos, int radius, uint colour) => default; // 0x00000001867DA7E0-0x00000001867DAB10
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static PhaserSprite AddPhaserSprite(this MonoBehaviour behaviour, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867DAB10-0x00000001867DABB0
		public static PhaserSprite AddPhaserSprite(this MonoBehaviour behaviour, Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867DABB0-0x00000001867DAC50
		public static PhaserSprite AddPhaserSprite(this GameObject gameObject, Vector2 pos, SpriteTextureData sprite) => default; // 0x00000001867DAC50-0x00000001867DACD0
		[Obsolete("Use \"SpriteTextures.\" instead of strings", false)]
		public static PhaserSprite AddPhaserSprite(this GameObject gameObject, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867DACD0-0x00000001867DAFD0
		public static PhaserSprite AddPhaserSpriteOfType<T>(this MonoBehaviour behaviour, Vector2 pos, string textureName, string spriteName)
			where T : PhaserSprite => default;
		public static T AddPhaserSpriteOfType<T>(this GameObject gameObject, Vector2 pos, string textureName, string spriteName)
			where T : PhaserSprite => default;
		public static SpriteRenderer AddGraphic(this MonoBehaviour behaviour) => default; // 0x00000001867DAFD0-0x00000001867DB050
		public static SpriteRenderer AddGraphic(this MonoBehaviour behaviour, Vector2 pos) => default; // 0x00000001867DB050-0x00000001867DB0D0
		public static SpriteRenderer AddGraphic(this GameObject gameObject, Vector2 pos) => default; // 0x00000001867DB0D0-0x00000001867DB350
		public static TileSprite AddTileSprite(this MonoBehaviour behaviour, float x, float y, float width, float height, string textureName, string spriteName) => default; // 0x00000001867DB350-0x00000001867DB480
		public static TileSpriteBuilder AddTileSprite(this MonoBehaviour behaviour, float x, float y, string textureName = null, string spriteName = null) => default; // 0x00000001867DB480-0x00000001867DB520
		public static TileSpriteBuilder AddTileSprite(this GameObject go, float x, float y, string textureName, string spriteName) => default; // 0x00000001867DB520-0x00000001867DB630
		public static TileSprite SetTexture(this TileSprite tileSprite, string texture) => default; // 0x00000001867DB630-0x00000001867DB6C0
		public static TileSprite SetAlpha(this TileSprite tileSprite, float alpha) => default; // 0x00000001867DB6C0-0x00000001867DB740
		public static TileSprite SetTint(this TileSprite tileSprite, uint tint) => default; // 0x00000001867DB740-0x00000001867DB7C0
		public static TileSprite SetTint(this TileSprite tileSprite, Color32 tint) => default; // 0x00000001867DB7C0-0x00000001867DB8E0
		public static TileSprite SetBlendMode(this TileSprite tileSprite, VampireSurvivors.Framework.Particles.BlendMode blendMode) => default; // 0x00000001867DB8E0-0x00000001867DB9D0
		public static TextMesh SetAlpha(this TextMesh textMesh, float alpha) => default; // 0x00000001867DB9D0-0x00000001867DBB50
		public static TextMesh SetTint(this TextMesh textMesh, uint tint) => default; // 0x00000001867DBB50-0x00000001867DBD10
		public static TextMesh SetDepth(this TextMesh textMesh, int depth) => default; // 0x00000001867DBD10-0x00000001867DBD80
		public static void SetDepth(this TrailRenderer trailRenderer, int depth) {} // 0x00000001867DBD80-0x00000001867DBDA0
		public static void SetVisible(this TrailRenderer trailRenderer, bool visible) {} // 0x00000001867DBDA0-0x00000001867DBDC0
		public static void SetDepthMultiplied(this TrailRenderer trailRenderer, float depth, float mul = 100f /* Metadata: 0x0197AA37 */) {} // 0x00000001867DBDC0-0x00000001867DBE00
		public static void SetDepth(this TilemapRenderer tilemapRenderer, int depth) {} // 0x00000001867DBD80-0x00000001867DBDA0
		public static void SetBlendMode(this ParticleSystem pfx, VampireSurvivors.Framework.Particles.BlendMode blendMode) {} // 0x00000001867DBE00-0x00000001867DBED0
		public static void SetDepth(this ParticleSystem pfx, int depth) {} // 0x00000001867DBED0-0x00000001867DBFE0
		public static void SetDepthMultiplied(this ParticleSystem pfx, float depth, float multiplier = 100f /* Metadata: 0x0197AA3B */) {} // 0x00000001867DBFE0-0x00000001867DC110
		public static TextMeshPro SetDepth(this TextMeshPro textMeshPro, int depth) => default; // 0x00000001867DC110-0x00000001867DC140
		public static TextMeshPro SetDepthMultiplied(this TextMeshPro textMeshPro, float depth, float multiplier = 100f /* Metadata: 0x0197AA3F */) => default; // 0x00000001867DC140-0x00000001867DC180
		public static SpriteRenderer SetDepth(this SpriteRenderer spriteRenderer, int depth) => default; // 0x00000001867DC180-0x00000001867DC1B0
		public static SpriteRenderer SetDepthMultiplied(this SpriteRenderer spriteRenderer, float depth, float multiplier = 100f /* Metadata: 0x0197AA43 */) => default; // 0x00000001867DC1B0-0x00000001867DC1F0
		[Il2CppSetOption(Option.NullChecks, false)]
		public static void SetDepthCached(this SpriteRenderer spriteRenderer, int newDepth, ref int currentDepth) {} // 0x00000001867DC1F0-0x00000001867DC210
		public static T SetScrollFactor<T>(this T component, float scrollFactor, bool fullscreen = false /* Metadata: 0x0197AA47 */)
			where T : Component => default;
		public static T setPositionPixelsScrollFactor0<T>(this T component, float x, float y)
			where T : Component => default;
		public static TrailRendererPauseController AddPauseController(this TrailRenderer trailRenderer) => default; // 0x00000001867DC210-0x00000001867DC3A0
		public static void SetMaterialToPackedSprite(this TrailRenderer trailRenderer, Sprite sprite, bool autoSetTrailWidth = true /* Metadata: 0x0197AA48 */, bool additive = false /* Metadata: 0x0197AA49 */) {} // 0x00000001867DC3A0-0x00000001867DC500
		public static void SetMaterialToPackedSprite(this LineRenderer lineRenderer, Sprite sprite, bool autoSetTrailWidth = true /* Metadata: 0x0197AA4A */, bool additive = false /* Metadata: 0x0197AA4B */) {} // 0x00000001867DC500-0x00000001867DC660
		private static void SetMaterialToPackedSpriteInternal(this UnityEngine.Renderer trailRenderer, Sprite sprite, bool additive) {} // 0x00000001867DC660-0x00000001867DCE90
		public static void ClearRenderTexture(this RenderTexture renderTexture) {} // 0x00000001867DCE90-0x00000001867DD020
		public static Image AddImage(this MonoBehaviour behaviour, float x, float y, string textureName = null, string spriteName = null) => default; // 0x00000001867DD020-0x00000001867DD0C0
		public static Image AddImage(this GameObject gameObject, float x, float y, string textureName = null, string spriteName = null) => default; // 0x00000001867DD0C0-0x00000001867DD160
		public static Image AddImage(this GameObject gameObject, Vector2 pos, string textureName, string spriteName) => default; // 0x00000001867DD160-0x00000001867DD460
		public static Image SetTint(this Image image, uint tint) => default; // 0x00000001867D66C0-0x00000001867D67A0
	}
}

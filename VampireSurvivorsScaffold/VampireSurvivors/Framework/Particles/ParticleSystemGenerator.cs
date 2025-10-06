/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.Particles
{
	public static class ParticleSystemGenerator // TypeDefIndex: 18233
	{
		// Methods
		public static ParticleSystem GenerateParticleSystem(ParticleSystemConfig config, Transform parent = null, string name = null, bool usePauseSystem = true /* Metadata: 0x019788DC */) => default; // 0x000000018670B2A0-0x000000018670B7A0
		public static GravityWell GenerateGravityWell(GravityWellConfig config, Transform parent = null, string name = null, bool usePauseSystem = true /* Metadata: 0x019788DD */) => default; // 0x000000018670B7A0-0x000000018670BB80
		public static void SetupTimeline(Transform parent, GameObject gameObject, bool usePauseSystem = true /* Metadata: 0x019788DE */) {} // 0x000000018670BB80-0x000000018670BC20
		private static void ConfigureParticleSystem(ParticleSystem particleSystem, ParticleSystemConfig config) {} // 0x000000018670BC20-0x000000018670C730
		private static void ConfigureFrames(ParticleSystemConfig config, ParticleSystem.TextureSheetAnimationModule textureSheetAnimation) {} // 0x000000018670C730-0x000000018670CCB0
		private static void ConfigureSpeed(ParticleSystemConfig config, ParticleSystem ps) {} // 0x000000018670CCB0-0x000000018670D110
		private static void ConfigureAngle(ParticleSystemConfig config, ParticleSystem.ShapeModule shape) {} // 0x000000018670D110-0x000000018670D410
		private static void ConfigureRotation(ParticleSystemConfig config, ParticleSystem.MainModule main) {} // 0x000000018670D410-0x000000018670D4C0
		private static void ConfigureLifespan(ParticleSystemConfig config, ParticleSystem.MainModule main) {} // 0x000000018670D4C0-0x000000018670D550
		private static void ConfigureScale(ParticleSystemConfig config, ParticleSystem.SizeOverLifetimeModule sizeOverLifetime, ParticleSystemRenderer psr, ParticleSystem.MainModule main, float sizeMult) {} // 0x000000018670D550-0x000000018670ED90
		private static void ConfigureAlpha(ParticleSystemConfig config, ParticleSystem.ColorOverLifetimeModule colorOverLifetime) {} // 0x000000018670ED90-0x000000018670F320
		private static void ConfigureQuantity(ParticleSystemConfig config, ParticleSystem.EmissionModule emission) {} // 0x000000018670F320-0x000000018670F660
		private static void ConfigureOn(ParticleSystemConfig config, ParticleSystem.EmissionModule emission) {} // 0x000000018670F660-0x000000018670F6D0
		private static void ConfigureGravity(ParticleSystemConfig config, ParticleSystem.MainModule main) {} // 0x000000018670F6D0-0x000000018670F760
		private static void ConfigureTint(ParticleSystemConfig config, ParticleSystem.MainModule main) {} // 0x000000018670F760-0x000000018670FBE0
		private static Color32 HexToColor(uint hexVal) => default; // 0x00000001863F55D0-0x00000001863F55F0
		private static void ConfigureEmitZone(ParticleSystemConfig config, ParticleSystem particleSystem) {} // 0x000000018670FBE0-0x000000018670FEA0
		private static void ConfigurePosition(ParticleSystemConfig config, ParticleSystem particleSystem) {} // 0x000000018670FEA0-0x0000000186710070
		private static void UpdateCollisionBounds(ParticleSystemConfig config, ParticleSystem particleSystem) {} // 0x0000000186710070-0x00000001867100E0
		private static Material GetMaterial(BlendMode? blendMode) => default; // 0x00000001867100E0-0x00000001867101A0
		private static void ConfigureGravityWell(GravityWell gravityWell, GravityWellConfig config) {} // 0x00000001867101A0-0x0000000186710270
		private static void ConfigureGravityWellPosition(GravityWellConfig config, GravityWell well) {} // 0x0000000186710270-0x0000000186710470
	}
}

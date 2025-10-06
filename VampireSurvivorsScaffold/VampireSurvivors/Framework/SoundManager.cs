/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DarkTonic.MasterAudio;
using JetBrains.Annotations;
using VampireSurvivors.Data;
using VampireSurvivors.Objects;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[UsedImplicitly]
	public class SoundManager : IInitializable, IDisposable // TypeDefIndex: 17528
	{
		// Fields
		private static PlayerOptions _playerOptions; // 0x00
		private static readonly Dictionary<SfxType, int> SoundInstances; // 0x08
		private static float _currentVolume; // 0x10
		private static Dictionary<SfxType, PlaySoundResult> _prevSkippableSounds; // 0x18
		private static DataManager _dataManager; // 0x20
		public const string BGM_CACHE_GROUP = "BGM"; // Metadata: 0x019786FF
		public const string SFX_CACHE_GROUP = "SFX"; // Metadata: 0x01978703
	
		// Properties
		public static BgmType CurrentBgm { get; set; } // 0x0000000187348E30-0x0000000187348E90 0x0000000187348E90-0x0000000187348EF0
		public static SoundConfig CurrentMusicSoundConfig { get; set; } // 0x0000000187348EF0-0x0000000187348F50 0x0000000187348F50-0x0000000187349010
		public static bool AllowUIFades { get; set; } // 0x0000000187349010-0x0000000187349070 0x0000000187349070-0x00000001873490D0
		public static float NormalMusicVolume { get => default; } // 0x000000018734B990-0x000000018734B9A0 
	
		// Nested types
		public class SoundConfig // TypeDefIndex: 17523
		{
			// Fields
			public bool Mute; // 0x10
			public float? Volume; // 0x14
			public float Rate; // 0x1C
			public float Detune; // 0x20
			public float Seek; // 0x24
			public bool Loop; // 0x28
			public float Delay; // 0x2C
			public float Pan; // 0x30
	
			// Constructors
			public SoundConfig() {} // 0x0000000187351000-0x0000000187351010
		}
	
		// Constructors
		public SoundManager() {} // 0x0000000180B15170-0x0000000180B15180
		static SoundManager() {} // 0x0000000187350E40-0x0000000187351000
	
		// Methods
		[Inject]
		private void Construct(PlayerOptions playerOptions, DataManager data) {} // 0x00000001873490D0-0x0000000187349210
		public void Initialize() {} // 0x0000000187349210-0x00000001873495F0
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public static void Cleanup() {} // 0x00000001873495F0-0x00000001873499D0
		public static PlaySoundResult PlaySound(SfxType sfxType, SoundConfig soundConfig = null, float durationMillis = 0f /* Metadata: 0x019786E0 */, int maxInstances = 10 /* Metadata: 0x019786E4 */, float time = 0f /* Metadata: 0x019786E5 */) => default; // 0x00000001873499D0-0x000000018734A180
		public static PlaySoundResult PlaySoundNonAlloc(SfxType sfxType, float durationMillis = 0f /* Metadata: 0x019786E9 */, int maxInstances = 10 /* Metadata: 0x019786ED */, float time = 0f /* Metadata: 0x019786EE */, float? Volume = default, float Rate = 1f /* Metadata: 0x019786F2 */, float Detune = 0f /* Metadata: 0x019786F6 */, bool Loop = false /* Metadata: 0x019786FA */, float Delay = 0f /* Metadata: 0x019786FB */) => default; // 0x000000018734A180-0x000000018734AA20
		private static void HandlePlaybackSkipping(PlaySoundResult sound, SfxType sfxType) {} // 0x000000018734AA20-0x000000018734B190
		public static void StopSound(SfxType sfxType) {} // 0x000000018734B190-0x000000018734B2E0
		public static void StopAll() {} // 0x000000018734B2E0-0x000000018734B330
		public static void GetPlaylistSource(BgmType bgmType) {} // 0x000000018734B330-0x000000018734B3D0
		public static void PreloadBgmAsync(BgmType bgmType) {} // 0x000000018734B3D0-0x000000018734B4D0
		public static void PreloadBgmAsync(List<BgmType> bgmTypes) {} // 0x000000018734B4D0-0x000000018734B990
		public static void PlayMusic(BgmType bgmType, SoundConfig config = null) {} // 0x000000018734B9A0-0x000000018734C030
		public static void TransitionMusic(BgmType newTrack, float durationMillisOut, float durationMillisIn, float? finalVolume = default) {} // 0x000000018734C030-0x000000018734C180
		public static void FadeInMusic(BgmType newTrack, float fadeInTimeMillis, float? finalVolume = default) {} // 0x000000018734C180-0x000000018734C2C0
		public static void StopMusic(BgmType bgmType) {} // 0x000000018734C2C0-0x000000018734C360
		public static void FadeMusic(float volume, float durationMillis) {} // 0x000000018734C360-0x000000018734C410
		public static void FadeMusic(BgmType bgmType, float volume, float durationMillis) {} // 0x000000018734C410-0x000000018734C5E0
		public static void UpdateMusicVolume(float volume) {} // 0x000000018734C5E0-0x000000018734C730
		public static void UpdateSfxVolume(float volume) {} // 0x000000018734C730-0x000000018734C790
		public static void UpdateCurrentMusicWithConfig(SoundConfig config) {} // 0x000000018734C790-0x000000018734C8E0
		public static string GetSoundGroupFromType(SfxType sfxType) => default; // 0x000000018734C8E0-0x0000000187350E10
		private static float CalculatePitch(float detune, float rate) => default; // 0x0000000187350E10-0x0000000187350E40
	}
}

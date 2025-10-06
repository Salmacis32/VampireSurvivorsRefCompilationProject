/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework.System
{
	public class UnityServicesManager : IInitializable, IDisposable // TypeDefIndex: 18604
	{
		// Fields
		[CanBeNull]
		private Action<IronSourceAdInfo> _rewardUserCallback; // 0x10
		private bool _rewardEarned; // 0x18
		private const string POST_RUN_EXTRA_GOLD_REWARDED = ""; // Metadata: 0x0197AD83
		private const string REVIVE_REWARDED = ""; // Metadata: 0x0197AD84
	
		// Properties
		public bool IsUnityServicesInitialized { get; private set; } // 0x0000000181B4E3A0-0x0000000181B4E3B0 0x0000000181B4E3B0-0x0000000181B4E3C0
	
		// Constructors
		public UnityServicesManager() {} // 0x0000000180B15170-0x0000000180B15180
	
		// Methods
		public void Initialize() {} // 0x00000001867EFBB0-0x00000001867EFD00
		public void Dispose() {} // 0x0000000180B15170-0x0000000180B15180
		public bool IsAppleArcade() => default; // 0x0000000180B15290-0x0000000180B152A0
		public bool CanShowPostRunRewardAd() => default; // 0x00000001867EFD00-0x00000001867EFD30
		public void ShowPostRunRewardAd(Action<IronSourceAdInfo> rewardUserCallback) {} // 0x00000001867EFD30-0x00000001867EFE30
		public void LoadRewardedVideoAd() {} // 0x00000001867EFE30-0x00000001867EFED0
		public bool CanShowReviveRewardAd() => default; // 0x00000001867EFED0-0x00000001867EFF00
		public void ShowReviveRewardAd(Action<IronSourceAdInfo> rewardUserCallback) {} // 0x00000001867EFF00-0x00000001867F0000
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void InitOnLoad() {} // 0x00000001867F0000-0x00000001867F0190
		private static void DisableUnityAnalytics() {} // 0x00000001867F0190-0x00000001867F0220
		private async UniTask InitServicesAsync() => default; // 0x00000001867F0220-0x00000001867F0370
		private void InitFailed(Exception error) {} // 0x00000001867F0370-0x00000001867F0420
		private void SetupAds() {} // 0x00000001867F0420-0x00000001867F0780
		private void InitLevelPlay() {} // 0x0000000180B15170-0x0000000180B15180
		private void OnLevelPlayInitialized() {} // 0x00000001867F0780-0x00000001867F0860
		private void CleanupAds() {} // 0x00000001867F0860-0x00000001867F0B20
		private void ShowRewardedAdAsync(string adId = null) {} // 0x00000001867F0B20-0x00000001867F0D20
		private bool CanUserHideAdsViaDlc() => default; // 0x0000000181958370-0x0000000181958380
		private void RewardedVideoOnAdAvailable(IronSourceAdInfo adInfo) {} // 0x00000001867F0D20-0x00000001867F0DA0
		private void RewardedVideoOnAdUnavailable() {} // 0x00000001867F0DA0-0x00000001867F0E00
		private void RewardedVideoOnAdLoadFailed(IronSourceError error) {} // 0x00000001867F0E00-0x00000001867F0F50
		private void RewardedVideoOnAdOpenedEvent(IronSourceAdInfo adInfo) {} // 0x00000001867F0F50-0x00000001867F0FD0
		private void RewardedVideoOnAdShowFailedEvent(IronSourceError error, IronSourceAdInfo adInfo) {} // 0x00000001867F0FD0-0x00000001867F1240
		private void RewardedVideoOnAdClickedEvent(IronSourcePlacement placementInfo, IronSourceAdInfo adInfo) {} // 0x00000001867F1240-0x00000001867F12C0
		private void RewardedVideoOnAdClosedEvent(IronSourceAdInfo adInfo) {} // 0x00000001867F12C0-0x00000001867F1360
		private void RewardedVideoOnAdRewardedEvent(IronSourcePlacement placementInfo, IronSourceAdInfo adInfo) {} // 0x0000000184C2DB10-0x0000000184C2DB20
	}
}

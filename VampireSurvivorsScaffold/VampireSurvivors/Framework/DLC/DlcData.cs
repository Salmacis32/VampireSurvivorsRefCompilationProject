/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework.DLC
{
	[Serializable]
	[CreateAssetMenu(fileName = "DlcData", menuName = "VampireSurvivors/New DlcData")]
	public class DlcData : ScriptableObject // TypeDefIndex: 18323
	{
		// Fields
		public string _Title; // 0x18
		public string _TitleLocKey; // 0x20
		public DlcType _DlcType; // 0x28
		public Sprite _DlcIcon; // 0x30
		public ContentGroupType _ContentGroupType; // 0x38
		[SerializeField]
		public string _ExpectedVersion; // 0x40
		[SerializeField]
		[Tooltip("Defines whether this DLC has been released on the stores yet. Used when checking whether to patch a DLC.")]
		public bool _HasBeenReleased; // 0x48
		[SerializeField]
		public ReleaseDateData _ReleaseDate; // 0x50
		[SerializeField]
		public SteamDlcData _Steam; // 0x58
		[SerializeField]
		public EpicGamesStoreData _EpicGamesesStore; // 0x60
		[SerializeField]
		public XboxDlcData _Xbox; // 0x68
		[SerializeField]
		public SwitchDlcData _Switch; // 0x70
		[SerializeField]
		public PlayStationDlcData _PS5; // 0x78
		[SerializeField]
		public PlayStationDlcData _PS4; // 0x80
		[SerializeField]
		public MobileDlcData _Mobile; // 0x88
		[SerializeField]
		[Tooltip("If enabled this DLC will be bundled and made available locally for testing on the selected platforms.")]
		public BundleDlcData _BundleDlc; // 0x90
		public bool DoNotAutoInclude; // 0x98
		[SerializeField]
		[Tooltip("If ticked this DLC will be not be built at all. It will only be available in editor.")]
		public bool _DoNotBuild; // 0x99
	
		// Constructors
		public DlcData() {} // 0x000000018672F9E0-0x000000018672FD90
	}
}

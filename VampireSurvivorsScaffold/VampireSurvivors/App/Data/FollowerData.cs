/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Poncle.Schema.Attributes.Attributes;
using VampireSurvivors.Data;
using VampireSurvivors.Objects.Algorithm;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Data
{
	[Serializable]
	public class FollowerData // TypeDefIndex: 18617
	{
		// Properties
		[JsonProperty("followerCharacter")]
		[Title("Follower Character")]
		public VampireSurvivors.Data.CharacterType FollowerCharacter { get; set; } // 0x0000000180B15510-0x0000000180B15520 0x0000000180B19030-0x0000000180B19040
		[JsonProperty("followerAI")]
		[Title("Follower AI")]
		public AIType FollowerAI { get; set; } // 0x0000000180B15AD0-0x0000000180B15AE0 0x0000000181968000-0x0000000181968010
		[JsonProperty("isFollowerInvinceable")]
		[Title("Is Follower Invincible")]
		public bool IsFollowerInvinceable { get; set; } // 0x000000018195C490-0x000000018195C4A0 0x0000000181B4E390-0x0000000181B4E3A0
		[JsonProperty("countsAsMainCharacterForRevivals")]
		[Title("Counts as Main Character for Revivals")]
		public bool CountsAsMainCharacterForRevivals { get; set; } // 0x0000000181B4E3A0-0x0000000181B4E3B0 0x0000000181B4E3B0-0x0000000181B4E3C0
		[JsonProperty("manualLevelUps")]
		[Title("Manual LevelUps")]
		public bool ManualLevelUps { get; set; } // 0x0000000183D9FF80-0x0000000183D9FF90 0x0000000184C34C90-0x0000000184C34CA0
		[JsonProperty("trackedByCamera")]
		[Title("Tracked By Camera")]
		public bool TrackedByCamera { get; set; } // 0x00000001846FEDC0-0x00000001846FEDD0 0x000000018508D5C0-0x000000018508D5D0
		[JsonProperty("shouldFollowMainPlayer")]
		[Title("Should Follow Main Player")]
		public bool ShouldFollowMainPlayer { get; set; } // 0x0000000181B4EA60-0x0000000181B4EA70 0x0000000181B4EA70-0x0000000181B4EA80
		[JsonProperty("allowDuplicates")]
		[Title("Allow Duplicates")]
		public bool AllowDuplicates { get; set; } // 0x0000000181B4EA80-0x0000000181B4EA90 0x0000000181B4EA90-0x0000000181B4EAA0
		[JsonProperty("everyXLevels")]
		[Title("Every X Levels")]
		public int EveryXLevels { get; set; } // 0x000000018195ECC0-0x000000018195ECD0 0x0000000181962000-0x0000000181962010
		[JsonProperty("ShouldSharePassives")]
		[Title("Should Share Passives")]
		public bool ShouldSharePassives { get; set; } // 0x00000001821A7CD0-0x00000001821A7CE0 0x00000001821A7CE0-0x00000001821A7CF0
		[JsonProperty("ShouldFollowerReactToArcanas")]
		[Title("Should Follower React To Arcanas")]
		public bool ShouldFollowerReactToArcanas { get; set; } // 0x00000001821A7CF0-0x00000001821A7D00 0x00000001821A7D00-0x00000001821A7D10
	
		// Constructors
		public FollowerData() {} // 0x00000001867F5700-0x00000001867F5710
	}
}

/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using VampireSurvivors.App.Data;
using VampireSurvivors.Data;
using VampireSurvivors.Data.PowerUp;
using VampireSurvivors.Framework;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public static class SerializationUtils // TypeDefIndex: 14063
	{
		// Methods
		public static byte[] SerializeEnum<T>(List<T> enumList)
			where T : System.Enum => default;
		public static List<T> DeserializeEnum<T>(byte[] buffer)
			where T : System.Enum => default;
		public static byte[] SerializeLimitBreaks(List<WeightedLimitBreak> limitBreaks) => default; // 0x0000000186C3F580-0x0000000186C3F9F0
		public static List<WeightedLimitBreak> DeserializeLimitBreaks(byte[] buffer) => default; // 0x0000000186C3F9F0-0x0000000186C3FEF0
		public static byte[] SerializePowerUps(List<PowerUpLevel> powerUps) => default; // 0x0000000186C3FEF0-0x0000000186C40380
		public static List<PowerUpLevel> DeserializePowerUps(byte[] buffer) => default; // 0x0000000186C40380-0x0000000186C40740
		public static byte[] SerializeTreasurePrizePairs(List<TreasurePrizeTypePair> prizePairs) => default; // 0x0000000186C40740-0x0000000186C40CD0
		public static List<TreasurePrizeTypePair> DeserializeTreasurePrizePairs(byte[] buffer) => default; // 0x0000000186C40CD0-0x0000000186C411B0
		public static byte[] SerializePickupCount(Dictionary<VampireSurvivors.Data.ItemType, int> pickupCount) => default; // 0x0000000186C411B0-0x0000000186C41630
		public static Dictionary<VampireSurvivors.Data.ItemType, int> DeserializePickupCount(byte[] buffer) => default; // 0x0000000186C41630-0x0000000186C41980
		public static byte[] SerializeSelectedSkins(Dictionary<VampireSurvivors.Data.CharacterType, SkinType> selectedSkins) => default; // 0x0000000186C41980-0x0000000186C42060
		public static Dictionary<VampireSurvivors.Data.CharacterType, SkinType> DeserializeSelectedSkins(byte[] buffer) => default; // 0x0000000186C42060-0x0000000186C42500
		public static byte[] SerializeAscensionData(Dictionary<PowerUpType, int> ascensionData) => default; // 0x0000000186C42500-0x0000000186C42980
		public static Dictionary<PowerUpType, int> DeserializeAscensionData(byte[] buffer) => default; // 0x0000000186C42980-0x0000000186C42CD0
		public static List<byte[]> SerializeUnlockedSkins(Dictionary<VampireSurvivors.Data.CharacterType, List<SkinType>> unlockedSkins) => default; // 0x0000000186C42CD0-0x0000000186C434A0
		public static Dictionary<VampireSurvivors.Data.CharacterType, List<SkinType>> DeserializeUnlockedSkins(List<byte[]> chunks) => default; // 0x0000000186C434A0-0x0000000186C43950
		public static byte[] SerializeCustomMerchantData(CustomMerchantData adventureMerchantData) => default; // 0x0000000186C43950-0x0000000186C440F0
		public static CustomMerchantData DeserializeCustomMerchantData(byte[] buffer) => default; // 0x0000000186C440F0-0x0000000186C44830
		private static byte GetStringLength(string s) => default; // 0x0000000186C44830-0x0000000186C448B0
		private static int GetSizeForSerializationType(SerializationType serializationType) => default; // 0x0000000186C448B0-0x0000000186C44940
		private static void WriteEnumValue<T>(SerializationType serializationType, BinaryWriter bw, T value)
			where T : System.Enum {}
		private static T ReadEnumValue<T>(SerializationType serializationType, BinaryReader br)
			where T : System.Enum => default;
		public static List<byte[]> SplitByteArray(byte[] buffer) => default; // 0x0000000186C44940-0x0000000186C44B30
		public static byte[] JoinByteArrays(List<byte[]> chunks) => default; // 0x0000000186C44B30-0x0000000186C44E10
	}
}

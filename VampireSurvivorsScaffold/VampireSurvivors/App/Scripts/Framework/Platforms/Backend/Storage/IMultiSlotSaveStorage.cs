/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Scripts.Framework.Platforms.Backend.Storage
{
	public interface IMultiSlotSaveStorage // TypeDefIndex: 18722
	{
		// Methods
		Task<bool> SetSlotData(int slot, PlayerOptionsData value);
		Task<PlayerOptionsData> GetSlotData(int slot);
		Task<PlayerOptionsData> GetMergeConflictSlotData();
	}
}

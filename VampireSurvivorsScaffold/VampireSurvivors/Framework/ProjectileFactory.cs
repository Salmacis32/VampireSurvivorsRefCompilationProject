/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using VampireSurvivors.App.Tools;
using VampireSurvivors.Data;
using VampireSurvivors.Framework.Validation;
using VampireSurvivors.Objects.Projectiles;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Framework
{
	[CreateAssetMenu(fileName = "ProjectileFactory", menuName = "VampireSurvivors/New ProjectileFactory")]
	public class ProjectileFactory : SerializedScriptableObject, IValidateReferences // TypeDefIndex: 17518
	{
		// Fields
		[SerializeField]
		private ProjectilesDictionary _Projectiles; // 0x58
		[SerializeField]
		private List<ProjectileFactory> _LinkedFactories; // 0x60
	
		// Nested types
		[Serializable]
		public class ProjectilesDictionary : UnitySerializedDictionary<WeaponType, Projectile> // TypeDefIndex: 17517
		{
			// Constructors
			public ProjectilesDictionary() {} // 0x0000000187345D70-0x0000000187345DB0
		}
	
		// Constructors
		public ProjectileFactory() {} // 0x0000000187345C90-0x0000000187345D70
	
		// Methods
		public Projectile GetProjectilePrefab(WeaponType weaponType) => default; // 0x00000001873450C0-0x00000001873456B0
		public List<string> ValidateReferences() => default; // 0x00000001873456B0-0x0000000187345C90
	}
}

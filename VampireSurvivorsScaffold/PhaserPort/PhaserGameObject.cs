/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class PhaserGameObject : GameMonoBehaviour, ArcadeColliderType // TypeDefIndex: 38102
{
	// Fields
	public BaseBody body; // 0x28
	private PhaserScene _scene; // 0x30
	private bool _visible; // 0x38
	private bool _ignoreDestroy; // 0x39
	[NonSerialized]
	public PhaserContainer _parentContainer; // 0x40

	// Properties
	public virtual bool isParent { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public virtual bool isTilemap { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	BaseBody ArcadeColliderType.body { get => default; } // 0x0000000180B15540-0x0000000180B15550 
	public virtual Rect? frame { get => default; } // 0x0000000184C499C0-0x0000000184C499D0 
	public bool active { get => default; set {} } // 0x0000000184C499D0-0x0000000184C49A70 0x0000000184C49A70-0x0000000184C49AA0
	GameObject ArcadeColliderType.gameObject { get => default; } // 0x0000000182774DD0-0x0000000182774DE0 

	// Constructors
	public PhaserGameObject() {} // 0x0000000184C44C90-0x0000000184C44CE0

	// Methods
	public virtual SpriteRenderer GetAttachedRenderer() => default; // 0x0000000184C49AA0-0x0000000184C49C10
	protected override void OnDestroy() {} // 0x0000000184C49C10-0x0000000184C49C80
}


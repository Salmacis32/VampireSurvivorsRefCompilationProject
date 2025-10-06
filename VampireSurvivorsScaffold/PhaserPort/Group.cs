/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class Group : EventEmitter, ArcadeColliderType // TypeDefIndex: 38100
{
	// Fields
	private HashSet<PhaserGameObject> children; // 0x18
	private readonly HashSet<PhaserGameObject> childrenToRemove; // 0x20
	private readonly HashSet<PhaserGameObject> childrenToAdd; // 0x28
	public PhysicsType _physicsType; // 0x30
	private static readonly ProfilerMarker MarkerRemove; // 0x00

	// Properties
	public int length { get => default; } // 0x0000000184C495A0-0x0000000184C495F0 
	public bool isParent { get => default; } // 0x0000000181958370-0x0000000181958380 
	public BaseBody body { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 
	public bool isTilemap { get => default; } // 0x0000000180B15290-0x0000000180B152A0 
	public GameObject gameObject { get => default; } // 0x0000000180B15D70-0x0000000180B15D80 

	// Constructors
	public Group() {} // Dummy constructor
	public Group(int capacity) {} // 0x0000000184C48AB0-0x0000000184C48E20
	static Group() {} // 0x0000000184C495F0-0x0000000184C49660

	// Methods
	public Group add(PhaserGameObject child) => default; // 0x0000000184C48E20-0x0000000184C48EC0
	public void remove(PhaserGameObject child) {} // 0x0000000184C48EC0-0x0000000184C49030
	public bool isFull() => default; // 0x0000000180B15290-0x0000000180B152A0
	public int countActive(bool value = true /* Metadata: 0x01AAC334 */) => default; // 0x0000000184C49030-0x0000000184C491B0
	public bool contains(PhaserGameObject child) => default; // 0x0000000184C491B0-0x0000000184C49210
	public HashSet<PhaserGameObject> getChildren() => default; // 0x0000000180B15520-0x0000000180B15530
	protected void clear() {} // 0x0000000184C49210-0x0000000184C49270
	public void UpdateHashSetElements() {} // 0x0000000184C49270-0x0000000184C495A0
}


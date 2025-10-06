/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class Collider // TypeDefIndex: 38124
{
	// Fields
	protected string _name; // 0x10
	protected World _world; // 0x18
	public bool _active; // 0x20
	protected bool _overlapOnly; // 0x21
	protected ArcadeColliderType _object1; // 0x28
	protected ArcadeColliderType _object2; // 0x30
	protected ArcadePhysicsCallback _collideCallback; // 0x38
	protected ArcadePhysicsCallback _processCallback; // 0x40
	protected CallbackContext _callbackContext; // 0x48

	// Constructors
	public Collider() {} // Dummy constructor
	public Collider(World world, bool overlapOnly, ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext) {} // 0x0000000184C59E80-0x0000000184C5A140

	// Methods
	public Collider setName(string name) => default; // 0x0000000184C5A140-0x0000000184C5A220
	public virtual void update() {} // 0x0000000184C5A220-0x0000000184C5A270
	public void destroy() {} // 0x0000000184C5A270-0x0000000184C5A490
	public void SetColliderRunPosition(int position) {} // 0x0000000184C5A490-0x0000000184C5A5B0
}


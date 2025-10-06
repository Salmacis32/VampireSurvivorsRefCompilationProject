/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class Factory // TypeDefIndex: 38127
{
	// Fields
	private World _world; // 0x10
	private PhaserScene _scene; // 0x18

	// Constructors
	public Factory() {} // Dummy constructor
	public Factory(World world) {} // 0x0000000184C5A5B0-0x0000000184C5A690

	// Methods
	public Collider collider(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) => default; // 0x0000000184C5A690-0x0000000184C5A780
	public Collider overlap(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) => default; // 0x0000000184C5A780-0x0000000184C5A870
	public PhaserGameObject existing(PhaserGameObject gameObject, bool isStatic = false /* Metadata: 0x01AAC389 */) => default; // 0x0000000184C5A870-0x0000000184C5A8A0
	public StaticPhysicsGroup staticGroup(List<PhaserGameObject> children = null, PhysicsGroupConfig config = null) => default; // 0x0000000184C5A8A0-0x0000000184C5A920
	public PhysicsGroup group(List<PhaserGameObject> children = null, PhysicsGroupConfig config = null, bool allowRTreeQueries = true /* Metadata: 0x01AAC38A */, int capacity = 10 /* Metadata: 0x01AAC38B */) => default; // 0x0000000184C5A920-0x0000000184C5A9F0
	public void destroy() {} // 0x0000000184C5A9F0-0x0000000184C5AAA0
}


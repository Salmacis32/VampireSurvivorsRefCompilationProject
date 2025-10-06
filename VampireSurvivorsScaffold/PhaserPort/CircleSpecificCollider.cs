/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class CircleSpecificCollider : Collider // TypeDefIndex: 38123
{
	// Fields
	private PhysicsGroup group1; // 0x50
	private PhysicsGroup group2; // 0x58
	private static readonly ProfilerMarker s_circleColliderMarker; // 0x00
	private static readonly ProfilerMarker s_circleOverlapMarker; // 0x08
	private static readonly ProfilerMarker s_circleVelocityMarker; // 0x10
	private static readonly ProfilerMarker s_circlePositionMarker; // 0x18

	// Constructors
	public CircleSpecificCollider() {} // Dummy constructor
	public CircleSpecificCollider(World world, bool overlapOnly, ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) {} // 0x0000000184C59220-0x0000000184C59480
	static CircleSpecificCollider() {} // 0x0000000184C59D50-0x0000000184C59E80

	// Methods
	public override void update() {} // 0x0000000184C59480-0x0000000184C59800
	private static void ComputeSeparations(BaseBody body1, BaseBody body2) {} // 0x0000000184C59800-0x0000000184C59D50
}


/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Profiling;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class Body : BaseBody, ArcadeObject // TypeDefIndex: 38122
{
	// Fields
	public float2 _scale; // 0xC0
	public float2 _prev; // 0xC8
	public float2 _prevFrame; // 0xD0
	public bool _allowRotation; // 0xD8
	public float _rotation; // 0xDC
	public float2 _sourceSize; // 0xE0
	public float2 _acceleration; // 0xE8
	public bool _allowDrag; // 0xF0
	public float2 _drag; // 0xF4
	public float2? _worldBounce; // 0xFC
	public ArcadeBodyBounds _customBoundsRectangle; // 0x108
	public float _maxSpeed; // 0x110
	public float2 _friction; // 0x114
	public bool _useDamping; // 0x11C
	public float _angularVelocity; // 0x120
	public float _angularAcceleration; // 0x124
	public float _angularDrag; // 0x128
	public float _maxAngular; // 0x12C
	public float _angle; // 0x130
	public float _speed; // 0x134
	private static readonly ProfilerMarker s_postUpdateMarker; // 0x00

	// Properties
	public Body body { get => default; } // 0x00000001826AE170-0x00000001826AE180 

	// Constructors
	public Body() {} // 0x0000000184C56F10-0x0000000184C56F60
	public Body(World world, PhaserGameObject gameObject) {} // 0x0000000184C56F60-0x0000000184C56FE0
	static Body() {} // 0x0000000184C591B0-0x0000000184C59220

	// Methods
	public override void Reset(World world, PhaserGameObject gameObject, bool initial = false /* Metadata: 0x01AAC37B */) {} // 0x0000000184C56FE0-0x0000000184C572A0
	private void updateBounds() {} // 0x0000000184C572A0-0x0000000184C57470
	public void updateFromGameObject() {} // 0x0000000184C57470-0x0000000184C57520
	private void resetFlags(bool clear = false /* Metadata: 0x01AAC37C */) {} // 0x0000000184C57520-0x0000000184C57540
	public void preUpdate(bool willStep, float delta) {} // 0x0000000184C57540-0x0000000184C575E0
	public void update(float delta) {} // 0x0000000184C575E0-0x0000000184C57940
	public override void postUpdate() {} // 0x0000000184C57940-0x0000000184C57AD0
	public override Body setBoundsRectangle(ArcadeBodyBounds bounds) => default; // 0x0000000184C57AD0-0x0000000184C57B50
	public bool checkWorldBounds() => default; // 0x0000000184C57B50-0x0000000184C57D60
	public Body stop() => default; // 0x0000000184C57D60-0x0000000184C57DF0
	public ArcadeBodyBounds getBounds(ArcadeBodyBounds toFill) => default; // 0x0000000184C57DF0-0x0000000184C57E20
	public bool hitTest(float x, float y) => default; // 0x0000000184C57E20-0x0000000184C57E80
	public bool onFloor() => default; // 0x0000000184C57E80-0x0000000184C57E90
	public bool onCeiling() => default; // 0x0000000184C57E90-0x0000000184C57EA0
	public bool onWall() => default; // 0x0000000184C57EA0-0x0000000184C57EC0
	public override float deltaAbsX() => default; // 0x0000000184C57EC0-0x0000000184C57EE0
	public override float deltaAbsY() => default; // 0x0000000184C57EE0-0x0000000184C57F00
	public float deltaX() => default; // 0x0000000184C57F00-0x0000000184C57F10
	public float deltaY() => default; // 0x0000000184C57F10-0x0000000184C57F20
	public override void drawDebug() {} // 0x0000000184C57F20-0x0000000184C58390
	public override bool willDrawDebug() => default; // 0x0000000181958370-0x0000000181958380
	public Body setCollideWorldBounds(bool? shouldCollide = default, float? bounceX = default, float? bounceY = default, bool? onWorldBounds = default) => default; // 0x0000000184C58390-0x0000000184C58580
	public Body setVelocity(float x, float y) => default; // 0x0000000184C58580-0x0000000184C585C0
	public Body setVelocityX(float value) => default; // 0x0000000184C585C0-0x0000000184C58600
	public Body setVelocityY(float value) => default; // 0x0000000184C58600-0x0000000184C58640
	public Body setMaxSpeed(float value) => default; // 0x0000000184C58640-0x0000000184C58650
	public Body setBounce(float x, float y) => default; // 0x0000000184C58650-0x0000000184C58670
	public Body setBounceX(float value) => default; // 0x0000000184C58670-0x0000000184C58680
	public Body setBounceY(float value) => default; // 0x0000000184C58680-0x0000000184C58690
	public Body setAcceleration(float x, float y) => default; // 0x0000000184C58690-0x0000000184C586B0
	public Body setAccelerationX(float value) => default; // 0x0000000184C586B0-0x0000000184C586C0
	public Body setAccelerationY(float value) => default; // 0x0000000184C586C0-0x0000000184C586D0
	public Body setAllowDrag(bool value = true /* Metadata: 0x01AAC37D */) => default; // 0x0000000184C586D0-0x0000000184C586E0
	public Body setAllowGravity(bool value = true /* Metadata: 0x01AAC37E */) => default; // 0x00000001828C3320-0x00000001828C3330
	public Body setAllowRotation(bool value = true /* Metadata: 0x01AAC37F */) => default; // 0x0000000184C586E0-0x0000000184C586F0
	public Body setDrag(float x, float y) => default; // 0x0000000184C586F0-0x0000000184C58710
	public Body setDamping(bool value) => default; // 0x0000000184C58710-0x0000000184C58720
	public Body setDragX(float value) => default; // 0x0000000184C58720-0x0000000184C58730
	public Body setDragY(float value) => default; // 0x0000000184C58730-0x0000000184C58740
	public Body setGravity(float x, float y) => default; // 0x0000000184C58740-0x0000000184C58760
	public Body setGravityX(float value) => default; // 0x0000000184C58760-0x0000000184C58770
	public Body setGravityY(float value) => default; // 0x0000000184C58770-0x0000000184C58780
	public Body setFriction(float x, float y) => default; // 0x0000000184C58780-0x0000000184C587A0
	public Body setFrictionX(float value) => default; // 0x0000000184C587A0-0x0000000184C587B0
	public Body setFrictionY(float value) => default; // 0x0000000184C587B0-0x0000000184C587C0
	public Body setAngularVelocity(float value) => default; // 0x0000000184C587C0-0x0000000184C587D0
	public Body setAngularAcceleration(float value) => default; // 0x0000000184C587D0-0x0000000184C587E0
	public Body setAngularDrag(float value) => default; // 0x0000000184C587E0-0x0000000184C587F0
	public Body setMass(float value) => default; // 0x0000000184C587F0-0x0000000184C58800
	public Body setImmovable(bool value = true /* Metadata: 0x01AAC380 */) => default; // 0x0000000184C58800-0x0000000184C58810
	public Body setEnable(bool value = true /* Metadata: 0x01AAC381 */) => default; // 0x0000000184C58810-0x0000000184C58820
	public override BaseBody setCircle(float radius, float? offsetX = default, float? offsetY = default, bool worldSpace = false /* Metadata: 0x01AAC382 */) => default; // 0x0000000184C58820-0x0000000184C58CE0
	public override BaseBody setSize(float? width, float? height, bool center = true /* Metadata: 0x01AAC383 */) => default; // 0x0000000184C58CE0-0x0000000184C591B0
}


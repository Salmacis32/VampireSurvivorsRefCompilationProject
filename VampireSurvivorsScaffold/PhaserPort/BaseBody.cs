/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public abstract class BaseBody : RBush.IRectangular // TypeDefIndex: 38121
{
	// Fields
	public SpriteRenderer _spriteRenderer; // 0x20
	public ArcadeTransform _transform; // 0x28
	public World _world; // 0x30
	public PhaserGameObject _gameObject; // 0x38
	public bool _enable; // 0x40
	public bool _isCircle; // 0x41
	public float _radius; // 0x44
	public float2 _offset; // 0x48
	public float2 _position; // 0x50
	public float2 _size; // 0x58
	public float2 _halfSize; // 0x60
	public float2 _center; // 0x68
	public float2 _velocity; // 0x70
	public bool _allowGravity; // 0x78
	public float2 _gravity; // 0x7C
	public float2 _bounce; // 0x84
	public bool _onWorldBounds; // 0x8C
	public bool _onCollide; // 0x8D
	public bool _onOverlap; // 0x8E
	public float _mass; // 0x90
	public bool _immovable; // 0x94
	public bool _pushable; // 0x95
	public bool _embedded; // 0x96
	protected bool _collideWorldBounds; // 0x97
	public ArcadeBodyCollision _checkCollision; // 0x98
	public ArcadeBodyCollision _blocked; // 0x9C
	public PhysicsType _physicsType; // 0xA0
	public float _dx; // 0xA4
	public float _dy; // 0xA8
	protected Transform _cachedUnityTransform; // 0xB0
	protected Transform _cachedSpriteUnityTransform; // 0xB8

	// Properties
	public Transform CachedUnityTransform { get; } // 0x00000001819A0190-0x00000001819A01A0 
	public Transform CachedSpriteUnityTransform { get; } // 0x0000000184C55CC0-0x0000000184C55E10 
	public float x { get; set; } // 0x0000000183A343D0-0x0000000183A343E0 0x0000000184C564A0-0x0000000184C564B0
	public float y { get; set; } // 0x0000000184C564B0-0x0000000184C564C0 0x0000000184C564C0-0x0000000184C564D0
	public float left { get; } // 0x0000000183A343D0-0x0000000183A343E0 
	public float right { get; } // 0x0000000184C564D0-0x0000000184C564E0 
	public float top { get; } // 0x0000000184C564B0-0x0000000184C564C0 
	public float bottom { get; } // 0x0000000184C564E0-0x0000000184C564F0 
	public float PhaserRadius { get; } // 0x0000000184C56E20-0x0000000184C56E30 
	public float WorldRadius { get; } // 0x0000000184C56E30-0x0000000184C56F10 

	// Constructors
	protected BaseBody() {} // 0x0000000184C56F10-0x0000000184C56F60

	// Methods
	public virtual void Reset(World world, PhaserGameObject gameObject, bool initial = false /* Metadata: 0x01AAC374 */) {} // 0x0000000184C55E10-0x0000000184C56440
	public virtual void drawDebug() {} // 0x0000000180B15170-0x0000000180B15180
	public virtual bool willDrawDebug() => default; // 0x0000000181958370-0x0000000181958380
	public virtual void postUpdate() {} // 0x0000000180B15170-0x0000000180B15180
	public bool RectangleContains(float x, float y) => default; // 0x0000000184C56440-0x0000000184C56470
	public bool CircleContains(float x, float y) => default; // 0x0000000184C56470-0x0000000184C564A0
	public virtual float deltaAbsX() => default; // 0x00000001826256C0-0x00000001826256D0
	public virtual float deltaAbsY() => default; // 0x00000001826256C0-0x00000001826256D0
	public void updateCenter() {} // 0x0000000184C564F0-0x0000000184C56540
	public void destroy() {} // 0x0000000184C56540-0x0000000184C565F0
	public void processX(float x, float? vx, bool left = false /* Metadata: 0x01AAC375 */, bool right = false /* Metadata: 0x01AAC376 */) {} // 0x0000000184C565F0-0x0000000184C566B0
	public void processY(float y, float? vy, bool up = false /* Metadata: 0x01AAC377 */, bool down = false /* Metadata: 0x01AAC378 */) {} // 0x0000000184C566B0-0x0000000184C56770
	public virtual BaseBody setCircle(float radius, float? offsetX = default, float? offsetY = default, bool worldSpace = false /* Metadata: 0x01AAC379 */) => default; // 0x0000000184C56770-0x0000000184C56C70
	public virtual BaseBody setOffset(float x, float? y = default) => default; // 0x0000000184C56C70-0x0000000184C56D50
	public virtual BaseBody setSize(float? width, float? height, bool center = true /* Metadata: 0x01AAC37A */) => default; // 0x0000000184C56D50-0x0000000184C56D90
	public virtual Body setBoundsRectangle(ArcadeBodyBounds bounds) => default; // 0x0000000184C56D90-0x0000000184C56E20
}


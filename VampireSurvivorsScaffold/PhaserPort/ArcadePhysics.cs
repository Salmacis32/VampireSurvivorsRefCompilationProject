/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class ArcadePhysics : GameMonoBehaviour // TypeDefIndex: 38116
{
	// Fields
	[SerializeField]
	private ArcadeWorldConfig _config; // 0x28
	private static ArcadePhysics s_instance; // 0x00
	private static ArcadeWorldConfig s_currentConfig; // 0x08
	private static PhaserScene s_scene; // 0x10
	public static World s_world; // 0x18
	public Factory add; // 0x30
	private List<BaseBody> _overlapCache; // 0x38
	private List<BaseBody> _overlapCache2; // 0x40
	private RBush.RectangularBox searchRect; // 0x48
	private List<BaseBody> _overlapCircBodyCache; // 0x50
	private List<BaseBody> _overlapLineBodyCache; // 0x58

	// Properties
	public static ArcadePhysics Instance { get => default; } // 0x0000000184C52440-0x0000000184C52480 
	public static ArcadeWorldConfig Config { get => default; } // 0x0000000184C52480-0x0000000184C524C0 
	public static PhaserScene scene { get => default; } // 0x0000000184C524C0-0x0000000184C52500 
	public World world { get => default; } // 0x0000000184C52500-0x0000000184C52540 

	// Constructors
	public ArcadePhysics() {} // 0x0000000184C53FE0-0x0000000184C542E0

	// Methods
	private new void Awake() {} // 0x0000000184C52540-0x0000000184C529E0
	private void Update() {} // 0x0000000184C529E0-0x0000000184C52A30
	public void Cleanup() {} // 0x0000000184C52A30-0x0000000184C52B60
	public List<BaseBody> OverlapRect(float x, float y, float width, float height, bool includeDynamic = true /* Metadata: 0x01AAC369 */, bool includeStatic = false /* Metadata: 0x01AAC36A */, Group specificGroup = null) => default; // 0x0000000184C52B60-0x0000000184C530A0
	public List<BaseBody> OverlapCirc(float x, float y, float radius, bool includeDynamic = true /* Metadata: 0x01AAC36B */, bool includeStatic = false /* Metadata: 0x01AAC36C */, Group specificGroup = null) => default; // 0x0000000184C530A0-0x0000000184C53310
	private bool CircleToCircle(ArcadeCircle a, ArcadeCircle b) => default; // 0x0000000184C53310-0x0000000184C53350
	private bool CircleToRectangle(ArcadeCircle circle, ArcadeRect rect) => default; // 0x0000000184C53350-0x0000000184C53460
	public List<BaseBody> OverlapLine(float2 lineStart, float2 lineEnd, float lineWidth, bool includeDynamic = true /* Metadata: 0x01AAC36D */, bool includeStatic = false /* Metadata: 0x01AAC36E */, Group specificGroup = null) => default; // 0x0000000184C53460-0x0000000184C53770
	private bool LineToCircle(float2 lineStart, float2 lineEnd, float2 circlePos, float circleRadius) => default; // 0x0000000184C53770-0x0000000184C53880
	private bool LineToRectangle(float2 lineStart, float2 lineEnd, ArcadeRect rect) => default; // 0x0000000184C53880-0x0000000184C53AE0
	private int CohenSutherlandCode(ArcadeRect rect, float2 position) => default; // 0x0000000184C53AE0-0x0000000184C53B40
	public PhaserGameObject closest(ArcadeSprite source, ICollection<PhaserGameObject> targets) => default; // 0x0000000184C53B40-0x0000000184C53F00
	public float2 velocityFromAngle(float angle, float speed, ref float2 vec2) => default; // 0x0000000184C53F00-0x0000000184C53F70
	public float2 velocityFromRotation(float rotation, float speed, ref float2 vec2) => default; // 0x0000000184C53F70-0x0000000184C53FE0
}


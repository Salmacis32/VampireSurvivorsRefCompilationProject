/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class PhaserScene // TypeDefIndex: 38158
{
	// Fields
	public Factory add; // 0x10
	public ArcadePhysics physics; // 0x18
	public CameraSet cameras; // 0x20
	private Renderer _renderer; // 0x28

	// Properties
	public Renderer renderer { get => default; } // 0x0000000180B15540-0x0000000180B15550 

	// Nested types
	public class Renderer // TypeDefIndex: 38155
	{
		// Fields
		public float width; // 0x10
		public float height; // 0x14
		public int pixelWidth; // 0x18
		public int pixelHeight; // 0x1C
		public float screenWidth; // 0x20
		public float screenHeight; // 0x24
		public float screenWidthPixels; // 0x28
		public float screenHeightPixels; // 0x2C
		public float sortPivotY; // 0x30
		public float2 screenCenter; // 0x34
		public float2 cameraVelocity; // 0x3C
		public ArcadeRect playArea; // 0x44
		private float2 lastScreenCenter; // 0x54
		private bool firstFrame; // 0x5C

		// Constructors
		public Renderer() {} // 0x0000000184C67C70-0x0000000184C67C80

		// Methods
		public void UpdateCameraVelocity() {} // 0x0000000184C67AF0-0x0000000184C67BF0
		public bool IsInPlayableScreenBounds(float2 point) => default; // 0x0000000184C67BF0-0x0000000184C67C70
	}

	public class BoxedVector2 // TypeDefIndex: 38156
	{
		// Fields
		public float x; // 0x10
		public float y; // 0x14

		// Constructors
		public BoxedVector2() {} // Dummy constructor
		public BoxedVector2(float x, float y) {} // 0x00000001828A3D20-0x00000001828A3D30
	}

	public class CameraSet // TypeDefIndex: 38157
	{
		// Fields
		public PhaserCamera main; // 0x10

		// Constructors
		public CameraSet() {} // 0x0000000180B15170-0x0000000180B15180
	}

	// Constructors
	public PhaserScene() {} // 0x0000000184C67610-0x0000000184C677C0

	// Methods
	public void UpdateRendererCache() {} // 0x0000000184C677C0-0x0000000184C67AF0
}


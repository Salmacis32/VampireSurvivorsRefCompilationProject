/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class ArcadeTransform // TypeDefIndex: 38119
{
	// Fields
	private static ProfilerMarker updateDisplayOriginSampler; // 0x00
	private static ProfilerMarker updateRendererMarker; // 0x08
	private static ProfilerMarker setFromGameObjectMarker; // 0x10
	private SpriteCachedData data; // 0x10
	private Transform _unityTransform; // 0x28
	private Transform _rendererTransform; // 0x30
	private SpriteRenderer _unitySpriteRenderer; // 0x38
	private BaseBody _body; // 0x40
	public float2 position; // 0x48
	public float2 scale; // 0x50
	protected float3 _unityangles; // 0x58
	protected float _unityz; // 0x64
	protected float _scalez; // 0x68
	public float2 displayOrigin; // 0x6C
	private float2 _origin; // 0x74
	private float2 cachedLocalPosition; // 0x7C

	// Properties
	public ref SpriteCachedData Data { get => default; } // 0x000000018373A220-0x000000018373A230 
	public float z { get => default; } // 0x000000018289FD70-0x000000018289FD80 
	public float2 origin { get => default; } // 0x00000001835D2FB0-0x00000001835D2FD0 
	public float rotation { get => default; } // 0x00000001832F7340-0x00000001832F7350 

	// Constructors
	public ArcadeTransform() {} // Dummy constructor
	public ArcadeTransform(Transform unityTransform, SpriteRenderer unitySpriteRenderer, BaseBody body) {} // 0x0000000184C54940-0x0000000184C54960
	static ArcadeTransform() {} // 0x0000000184C55BD0-0x0000000184C55CC0

	// Methods
	public void Reset(Transform unityTransform, SpriteRenderer unitySpriteRenderer, BaseBody body) {} // 0x0000000184C54960-0x0000000184C54B80
	public void setOrigin(float2 o) {} // 0x0000000184C54B80-0x0000000184C54C10
	public void OnSpriteChanged() {} // 0x0000000184C54C10-0x0000000184C54CC0
	public void OnSpriteChanged(float2 originalSize) {} // 0x0000000184C54CC0-0x0000000184C54DB0
	public void SetFromGameObject() {} // 0x0000000184C54DB0-0x0000000184C55090
	public void AddPosition(float2 pos) {} // 0x0000000184C55090-0x0000000184C551D0
	public void AddPositionForced(float2 pos) {} // 0x0000000184C551D0-0x0000000184C55200
	public void SetPosition(float2 pos) {} // 0x0000000184C55200-0x0000000184C55330
	public void SetPositionForced(float2 pos) {} // 0x0000000184C55330-0x0000000184C55400
	public void UpdateDisplayOrigin(bool forced = false /* Metadata: 0x01AAC36F */) {} // 0x0000000184C55400-0x0000000184C55470
	public void UpdateRendererPosition(bool force = false /* Metadata: 0x01AAC370 */) {} // 0x0000000184C55470-0x0000000184C55630
	public static float2 GetRendererPosition(float2 origin, Sprite sprite) => default; // 0x0000000184C55630-0x0000000184C556E0
	public static float2 GetRendererPosition(float2 origin, SpriteCachedData data) => default; // 0x0000000184C556E0-0x0000000184C55730
	public void AddRotation(float deltaZ) {} // 0x0000000184C55730-0x0000000184C557B0
	public void ForceSpriteFetch() {} // 0x0000000184C557B0-0x0000000184C558B0
	public void ForceFullReupdate() {} // 0x0000000184C558B0-0x0000000184C55940
	public bool SetRotation(float rotation) => default; // 0x0000000184C55940-0x0000000184C55A10
	public void SetRotationForced(float rotation) {} // 0x0000000184C55A10-0x0000000184C55A70
	public void SetPositionAndRotationForced(float2 transformPosition, float f) {} // 0x0000000184C55A70-0x0000000184C55BD0
}


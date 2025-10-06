/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class FakeRigidBodyMover : MonoBehaviour // TypeDefIndex: 13848
{
	// Fields
	[Header("Physics Settings")]
	[SerializeField]
	public float mass; // 0x20
	[SerializeField]
	public float drag; // 0x24
	[SerializeField]
	public float angularDrag; // 0x28
	[SerializeField]
	public bool useGravity; // 0x2C
	[SerializeField]
	public Vector3 customGravity; // 0x30
	[Header("Debug")]
	[SerializeField]
	private bool showDebugInfo; // 0x3C
	private Vector3 velocity; // 0x40
	public Vector3 angularVelocity; // 0x4C
	public bool isKinematic; // 0x58
	private Vector3 effectiveGravity; // 0x5C

	// Properties
	public Vector3 Velocity { get => default; set {} } // 0x00000001865A10D0-0x00000001865A10F0 0x00000001865A10F0-0x00000001865A1100
	public Vector3 AngularVelocity { get => default; set {} } // 0x0000000185DA1D80-0x0000000185DA1DA0 0x0000000186148FF0-0x0000000186149000
	public bool IsKinematic { get => default; set {} } // 0x00000001827FCB50-0x00000001827FCB60 0x00000001827FCB60-0x00000001827FCB70
	public float Mass { get => default; set {} } // 0x0000000181967D10-0x0000000181967D20 0x0000000184C5EF70-0x0000000184C5EF80
	public float Drag { get => default; set {} } // 0x0000000184C5EF80-0x0000000184C5EF90 0x0000000184C5EF90-0x0000000184C5EFA0
	public float AngularDrag { get => default; set {} } // 0x000000018273EC30-0x000000018273EC40 0x000000018273EE00-0x000000018273EE10
	public bool UseGravity { get => default; set {} } // 0x0000000182760700-0x0000000182760710 0x000000018289C440-0x000000018289C450

	// Constructors
	public FakeRigidBodyMover() {} // 0x00000001865A2440-0x00000001865A2570

	// Methods
	private void Start() {} // 0x00000001865A1100-0x00000001865A1220
	private void Update() {} // 0x00000001865A1220-0x00000001865A1980
	public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force /* Metadata: 0x01976A20 */) {} // 0x00000001865A1980-0x00000001865A1AF0
	public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, float upwardsModifier = 0f /* Metadata: 0x01976A21 */, ForceMode mode = ForceMode.Force /* Metadata: 0x01976A25 */) {} // 0x00000001865A1AF0-0x00000001865A1E60
	public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force /* Metadata: 0x01976A26 */) {} // 0x00000001865A1E60-0x00000001865A1FD0
	public void ResetPhysics() {} // 0x00000001865A1FD0-0x00000001865A2070
	private void OnDrawGizmos() {} // 0x00000001865A2070-0x00000001865A2440
}


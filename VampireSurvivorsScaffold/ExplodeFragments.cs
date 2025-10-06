/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class ExplodeFragments : MonoBehaviour // TypeDefIndex: 13847
{
	// Fields
	[Header("Explosion Settings")]
	[SerializeField]
	private float lifetime; // 0x20
	[SerializeField]
	private AnimationCurve scaleOverLifetime; // 0x28
	[SerializeField]
	private float radialSpeed; // 0x30
	[SerializeField]
	private float radialSpeedJitter; // 0x34
	[SerializeField]
	private float directionJitterDegrees; // 0x38
	[SerializeField]
	private Vector2 spinSpeedRangeDeg; // 0x3C
	[SerializeField]
	private Vector3 gravity; // 0x44
	[SerializeField]
	private int seed; // 0x50
	[SerializeField]
	private Vector3 extraVelocityJitter; // 0x54
	[Header("FXs")]
	[SerializeField]
	private ParticleSystem explodeParticles; // 0x60
	[Header("Rigidbody Settings")]
	[SerializeField]
	private float mass; // 0x68
	[SerializeField]
	private float drag; // 0x6C
	[SerializeField]
	private float angularDrag; // 0x70
	[SerializeField]
	private bool useGravity; // 0x74
	[Header("Fragment Settings")]
	[SerializeField]
	private Transform fragmentRoot; // 0x78
	[SerializeField]
	private Transform explosionTransform; // 0x80
	[SerializeField]
	private bool enableRootOnExplode; // 0x88
	[SerializeField]
	private bool disableRootOnStop; // 0x89
	private Dictionary<Transform, OriginalTransformData> originalTransforms; // 0x90
	private Dictionary<Transform, FakeRigidBodyMover> fragmentMovers; // 0x98
	private List<Transform> fragments; // 0xA0
	private bool isExploding; // 0xA8

	// Nested types
	private struct OriginalTransformData // TypeDefIndex: 13845
	{
		// Fields
		public Vector3 scale; // 0x00
		public Vector3 position; // 0x0C
		public Quaternion rotation; // 0x18
	}

	// Constructors
	public ExplodeFragments() {} // 0x000000018659F9F0-0x000000018659FDD0

	// Methods
	private void Awake() {} // 0x000000018659E060-0x000000018659E160
	private void CollectFragments() {} // 0x000000018659E160-0x000000018659E9B0
	private void SetupFragments() {} // 0x000000018659E9B0-0x000000018659EDD0
	public void Explode() {} // 0x000000018659EDD0-0x000000018659F010
	public void ResetFragments() {} // 0x000000018659F010-0x000000018659F780
	[IteratorStateMachine(typeof(_ExplodeCoroutine_d__28))]
	private IEnumerator ExplodeCoroutine() => default; // 0x000000018659F780-0x000000018659F820
	private static Vector3 RandomOnUnitSphere(System.Random rng) => default; // 0x000000018659F820-0x000000018659F9F0
}


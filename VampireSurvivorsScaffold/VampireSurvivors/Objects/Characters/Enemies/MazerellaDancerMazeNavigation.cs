/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Tilemaps;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Objects.Characters.Enemies
{
	public class MazerellaDancerMazeNavigation : MonoBehaviour // TypeDefIndex: 17426
	{
		// Fields
		private const float DistanceBetweenNodes = 5.12f; // Metadata: 0x01978582
		private const float HalfDistanceBetweenNodes = 2.56f; // Metadata: 0x01978586
		private const float FirstNodeX = 12.16f; // Metadata: 0x0197858A
		private const float FirstNodeY = 12.16f; // Metadata: 0x0197858E
		private const float InverseFirstNodeX = 74.88f; // Metadata: 0x01978592
		private const float InverseFirstNodeY = 74.88f; // Metadata: 0x01978596
		private const int PlayerStartNavigationNodeIndex = 84; // Metadata: 0x0197859A
		private const int LeftDancerDestinationNavigationNodeIndex = 6; // Metadata: 0x0197859C
		private const int RightDancerDestinationNavigationNodeIndex = 162; // Metadata: 0x0197859D
		private readonly List<PathLineSegment> _lineSegmentsBetweenDanceFloors; // 0x28
	
		// Properties
		public List<NavigationNode> NavigationNodes { get; } // 0x0000000180B15530-0x0000000180B15540 
		public float CurrentTotalNormalizedPosition { get; private set; } // 0x0000000181949690-0x00000001819496A0 0x00000001819496A0-0x00000001819496B0
	
		// Nested types
		public enum MazerellaNavigationNodeDirection // TypeDefIndex: 17423
		{
			North = 0,
			South = 1,
			East = 2,
			West = 3
		}
	
		[Serializable]
		public class NavigationNode // TypeDefIndex: 17424
		{
			// Fields
			public Vector2 Position; // 0x10
			public int LeftDancerWeight; // 0x18
			public int RightDancerWeight; // 0x1C
			public NavigationNode NorthNode; // 0x20
			public NavigationNode SouthNode; // 0x28
			public NavigationNode EastNode; // 0x30
			public NavigationNode WestNode; // 0x38
	
			// Constructors
			public NavigationNode() {} // 0x0000000180B15170-0x0000000180B15180
		}
	
		// Constructors
		public MazerellaDancerMazeNavigation() {} // 0x00000001872BBB20-0x00000001872BBCB0
	
		// Methods
		private void PrecalculateNavigationWeights() {} // 0x00000001872B9C80-0x00000001872B9F90
		private void CachePathBetweenDanceFloors() {} // 0x00000001872B9F90-0x00000001872BA320
		private List<NavigationNode> GetPathToDanceFloor(NavigationNode startNode, NavigationNode targetNode, EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001872BA320-0x00000001872BA450
		private NavigationNode GetLowestWeightNode(NavigationNode navigationNode, EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001872BA450-0x00000001872BA770
		private int GetNodeWeight(NavigationNode nodeToCheck, EnemyMazerellaDancer.DancerSide dancerSide) => default; // 0x00000001872BA770-0x00000001872BA7A0
		private Vector3 GetNearestPositionOnPathBetweenDanceFloors(Vector3 position, out int lineSegmentIndex, out float normalizedDistanceOnLineSegment) {
			lineSegmentIndex = default;
			normalizedDistanceOnLineSegment = default;
			return default;
		} // 0x00000001872BA7A0-0x00000001872BAA60
		public Vector3 GetPositionOnLineSegmentWithOffset(int lineSegmentIndex, float startPointNormalizedPosition, float offsetDistanceInWorldSpace) => default; // 0x00000001872BAA60-0x00000001872BACF0
		private Vector3 GetClosestPointOnLineToPoint(PathLineSegment lineSegment, Vector3 point, out float normalizedDistance) {
			normalizedDistance = default;
			return default;
		} // 0x00000001872BACF0-0x00000001872BADF0
		private Vector3 GetClosestPointOnLineToPoint(Vector3 lineStart, Vector3 lineEnd, Vector3 point, out float normalizedDistance) {
			normalizedDistance = default;
			return default;
		} // 0x00000001872BADF0-0x00000001872BAF20
		private void SetLeftDancerWeight(NavigationNode currentNode, int weightToSet) {} // 0x00000001872BAF20-0x00000001872BAFC0
		private void SetRightDancerWeight(NavigationNode currentNode, int weightToSet) {} // 0x00000001872BAFC0-0x00000001872BB060
		public void UpdateNearestPositionToPlayer(Transform playerTransform) {} // 0x00000001872BB060-0x00000001872BB3B0
		public bool TryGetNodeInDirection(MazerellaNavigationNodeDirection direction, NavigationNode currentNode, out NavigationNode navigationNode) {
			navigationNode = default;
			return default;
		} // 0x00000001872BB3B0-0x00000001872BB4B0
		public void ConfigureNavigationNodes(Tilemap walls) {} // 0x00000001872BB4B0-0x00000001872BB560
		private void CreateNodes() {} // 0x00000001872BB560-0x00000001872BB790
		private void ProcessNavigationNodes(Tilemap walls) {} // 0x00000001872BB790-0x00000001872BBB20
	}
}

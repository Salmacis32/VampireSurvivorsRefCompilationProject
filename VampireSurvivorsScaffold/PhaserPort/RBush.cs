/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Unity.Profiling;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class RBush // TypeDefIndex: 38164
{
	// Fields
	private int _maxEntries; // 0x10
	private int _minEntries; // 0x14
	private Node data; // 0x18
	private List<BaseBody> _searchResults; // 0x20
	private Node[] _nodesToSearch; // 0x28
	private int _nodesToSearchCount; // 0x30
	private List<Node> _insertPath; // 0x38
	private List<Node> _liveNodes; // 0x40
	private List<Node> _spareNodes; // 0x48
	private List<IRectangular> _convertedList; // 0x50
	private static readonly ProfilerMarker s_searchMarker; // 0x00
	private static readonly ProfilerMarker s_loadMarker; // 0x08
	private List<IRectangular> _innerNodesToSearch; // 0x58
	private Stack<int> _multiSelectStack; // 0x60

	// Nested types
	public class RectangularBox : IRectangular // TypeDefIndex: 38161
	{
		// Constructors
		public RectangularBox() {} // 0x0000000184C6C120-0x0000000184C6C170
	}

	public abstract class IRectangular // TypeDefIndex: 38162
	{
		// Fields
		public static readonly Comparison<IRectangular> CompareMinX; // 0x00
		public static readonly Comparison<IRectangular> CompareMinY; // 0x08
		public float MinX; // 0x10
		public float MinY; // 0x14
		public float MaxX; // 0x18
		public float MaxY; // 0x1C

		// Constructors
		protected IRectangular() {} // 0x0000000180B15170-0x0000000180B15180
		static IRectangular() {} // 0x0000000184C6C270-0x0000000184C6C400

		// Methods
		[Il2CppSetOption(Option.NullChecks, false)]
		private static int compareNodeMinX(IRectangular a, IRectangular b) => default; // 0x0000000184C6C170-0x0000000184C6C1F0
		[Il2CppSetOption(Option.NullChecks, false)]
		private static int compareNodeMinY(IRectangular a, IRectangular b) => default; // 0x0000000184C6C1F0-0x0000000184C6C270
	}

	public class Node : IRectangular // TypeDefIndex: 38163
	{
		// Fields
		public List<IRectangular> children; // 0x20
		public int height; // 0x28
		public bool leaf; // 0x2C

		// Constructors
		public Node() {} // 0x0000000184C6C490-0x0000000184C6C4E0

		// Methods
		public void Clear() {} // 0x0000000184C6C400-0x0000000184C6C490
	}

	// Constructors
	public RBush() {} // Dummy constructor
	public RBush(int maxEntries = 9 /* Metadata: 0x01AAC3B6 */) {} // 0x0000000184C67C80-0x0000000184C681A0
	static RBush() {} // 0x0000000184C6C070-0x0000000184C6C120

	// Methods
	public List<BaseBody> all() => default; // 0x0000000184C681A0-0x0000000184C68230
	public List<BaseBody> search(IRectangular bbox) => default; // 0x0000000184C68230-0x0000000184C687B0
	public RBush load(HashSet<PhaserGameObject> data) => default; // 0x0000000184C687B0-0x0000000184C68F60
	public RBush insert(IRectangular item) => default; // 0x0000000184C68F60-0x0000000184C68FA0
	public RBush clear() => default; // 0x0000000184C68FA0-0x0000000184C690A0
	public RBush remove(IRectangular item, Func<IRectangular, IRectangular, bool> equalsFn = null) => default; // 0x0000000184C690A0-0x0000000184C694C0
	private List<BaseBody> _all(Node node, List<BaseBody> result) => default; // 0x0000000184C694C0-0x0000000184C69720
	private Node _build(List<IRectangular> items, int left, int right, int? height = default) => default; // 0x0000000184C69720-0x0000000184C69D60
	private Node _chooseSubtree(IRectangular bbox, Node node, int level, List<Node> path) => default; // 0x0000000184C69D60-0x0000000184C6A150
	private void _insert(IRectangular item, int level, bool isNode = false /* Metadata: 0x01AAC3B7 */) {} // 0x0000000184C6A150-0x0000000184C6A490
	private void _split(List<Node> insertPath, int level) {} // 0x0000000184C6A490-0x0000000184C6AA30
	private void _splitRoot(Node node, Node newNode) {} // 0x0000000184C6AA30-0x0000000184C6ABA0
	private int _chooseSplitIndex(Node node, int m, int M) => default; // 0x0000000184C6ABA0-0x0000000184C6AD30
	private void _chooseSplitAxis(Node node, int m, int M) {} // 0x0000000184C6AD30-0x0000000184C6AE70
	private float _allDistMargin(Node node, int m, int M, Comparison<IRectangular> compare) => default; // 0x0000000184C6AE70-0x0000000184C6B1D0
	private void _adjustParentBBoxes(IRectangular bbox, List<Node> path, int level) {} // 0x0000000184C6B1D0-0x0000000184C6B320
	private void _condense(List<Node> path) {} // 0x0000000184C6B320-0x0000000184C6B4A0
	private int findItem(IRectangular item, List<IRectangular> items, Func<IRectangular, IRectangular, bool> equalsFn) => default; // 0x0000000184C6B4A0-0x0000000184C6B5D0
	private void calcBBox(Node node) {} // 0x0000000184C6B5D0-0x0000000184C6B640
	private Node distBBox(Node node, int k, int p, Node destNode = null) => default; // 0x0000000184C6B640-0x0000000184C6B800
	private Node extend(Node a, IRectangular b) => default; // 0x0000000184C6B800-0x0000000184C6B8C0
	private float bboxArea(IRectangular a) => default; // 0x0000000184C6B8C0-0x0000000184C6B8F0
	private float bboxMargin(IRectangular a) => default; // 0x0000000184C6B8F0-0x0000000184C6B920
	private float enlargedArea(IRectangular a, IRectangular b) => default; // 0x0000000184C6B920-0x0000000184C6BA30
	public static float intersectionArea(Node a, Node b) => default; // 0x0000000184C6BA30-0x0000000184C6BB70
	public static bool contains(IRectangular a, IRectangular b) => default; // 0x0000000184C6BB70-0x0000000184C6BBD0
	public static bool intersects(IRectangular a, IRectangular b) => default; // 0x0000000184C6BBD0-0x0000000184C6BC30
	private Node createNode() => default; // 0x0000000184C6BC30-0x0000000184C6BE30
	public void drawDebug(Color colour) {} // 0x0000000184C6BE30-0x0000000184C6C070
	private void multiSelect<T>(ref ListAccessor<T> list, int left, int right, int n, Comparison<T> compare) {}
}


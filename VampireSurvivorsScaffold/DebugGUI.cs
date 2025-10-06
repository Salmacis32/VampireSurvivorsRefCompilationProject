/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

public class DebugGUI : MonoBehaviour // TypeDefIndex: 13854
{
	// Fields
	private static DebugGUI _instance; // 0x00
	private const int graphWidth = 600; // Metadata: 0x01976A3D
	private const int graphHeight = 100; // Metadata: 0x01976A3F
	private const float temporaryLogLifetime = 5f; // Metadata: 0x01976A41
	[SerializeField]
	private bool drawInBuild; // 0x20
	[SerializeField]
	private bool displayGraphs; // 0x21
	[SerializeField]
	private bool displayLogs; // 0x22
	[SerializeField]
	private Color backgroundColor; // 0x24
	[Header("Runtime Debugging Only")]
	[SerializeField]
	private List<GraphContainer> graphs; // 0x38
	private Dictionary<object, string> persistentLogs; // 0x40
	private Queue<TransientLog> transientLogs; // 0x48
	private Dictionary<object, GraphContainer> graphDictionary; // 0x50
	private GUIStyle minMaxTextStyle; // 0x58
	private GUIStyle boxStyle; // 0x60
	private bool freezeGraphs; // 0x68
	private bool isOnRight; // 0x69
	private Texture2D boxTexture; // 0x70
	private const float minMaxTextHeight = 8f; // Metadata: 0x01976A45
	private const float nextLineHeight = 15f; // Metadata: 0x01976A49
	private GUIContent labelGuiContent; // 0x78
	private float textWidth; // 0x80
	private Rect textRect; // 0x84
	private HashSet<int> graphGroupBoxesDrawn; // 0x98
	private float graphLabelWidth; // 0xA0
	private StringBuilder stringBuilder; // 0xA8
	private List<MonoBehaviour> attributeContainers; // 0xB0
	private Dictionary<System.Type, HashSet<FieldInfo>> debugGUIPrintFields; // 0xB8
	private Dictionary<System.Type, HashSet<PropertyInfo>> debugGUIPrintProperties; // 0xC0
	private Dictionary<System.Type, HashSet<FieldInfo>> debugGUIGraphFields; // 0xC8
	private Dictionary<System.Type, HashSet<PropertyInfo>> debugGUIGraphProperties; // 0xD0
	private Dictionary<System.Type, int> typeInstanceCounts; // 0xD8
	private Dictionary<MonoBehaviour, List<AttributeKey>> attributeKeys; // 0xE0

	// Properties
	private static DebugGUI Instance { get => default; } // 0x00000001865A25D0-0x00000001865A28E0 
	private static bool LogsEnabled { get => default; } // 0x00000001865A28E0-0x00000001865A2960 
	private static bool GraphsEnabled { get => default; } // 0x00000001865A2960-0x00000001865A29E0 

	// Nested types
	private class AttributeKey // TypeDefIndex: 13851
	{
		// Fields
		public MemberInfo memberInfo; // 0x10

		// Constructors
		public AttributeKey() {} // Dummy constructor
		public AttributeKey(MemberInfo memberInfo) {} // 0x0000000181958310-0x0000000181958370
	}

	private struct TransientLog // TypeDefIndex: 13852
	{
		// Fields
		public string text; // 0x00
		public float expiryTime; // 0x08

		// Constructors
		public TransientLog(string text, float duration) {
			this.text = default;
			expiryTime = default;
		} // 0x00000001865AAD00-0x00000001865AADB0
	}

	[Serializable]
	private class GraphContainer // TypeDefIndex: 13853
	{
		// Fields
		public string name; // 0x10
		public float max; // 0x18
		private float defaultMax; // 0x1C
		public float min; // 0x20
		private float defaultMin; // 0x24
		public bool autoScale; // 0x28
		public Color color; // 0x2C
		public int group; // 0x3C
		private Texture2D tex0; // 0x40
		private Texture2D tex1; // 0x48
		private bool texFlipFlop; // 0x50
		private int currentIndex; // 0x54
		private float[] values; // 0x58
		private static Color32[] clearColorArray; // 0x00

		// Constructors
		public GraphContainer() {} // Dummy constructor
		public GraphContainer(int width, int height) {} // 0x00000001865AAE80-0x00000001865AB0B0
		static GraphContainer() {} // 0x00000001865ABC40-0x00000001865ABD00

		// Methods
		public void SetDefaultMinMax() {} // 0x00000001865AADB0-0x00000001865AAE10
		public void SetMinMax(float min, float max, bool isDefault) {} // 0x00000001865AAE10-0x00000001865AAE80
		public void Push(float val) {} // 0x00000001865AB0B0-0x00000001865AB430
		public void Clear() {} // 0x00000001865AB430-0x00000001865AB580
		public void Draw(Rect rect) {} // 0x00000001865AB580-0x00000001865AB640
		public float GetValue(int index) => default; // 0x00000001865AB640-0x00000001865AB6E0
		private void RegenerateGraph() {} // 0x00000001865AB6E0-0x00000001865AB930
		private static int Mod(int n, int m) => default; // 0x00000001865AB930-0x00000001865AB950
		private void DrawLine(Texture2D tex, int x0, int y0, int x1, int y1, Color col) {} // 0x00000001865AB950-0x00000001865ABB60
		public void DestroyTextures() {} // 0x00000001865ABB60-0x00000001865ABC40
	}

	// Constructors
	public DebugGUI() {} // 0x00000001865AA470-0x00000001865AAD00

	// Methods
	public static void LogPersistent(object key, object message) {} // 0x00000001865A29E0-0x00000001865A2B40
	public static void RemovePersistent(object key) {} // 0x00000001865A2B40-0x00000001865A2C00
	public static void ClearPersistent() {} // 0x00000001865A2C00-0x00000001865A2C80
	public static void Log(object message) {} // 0x00000001865A2C80-0x00000001865A2CF0
	public static void SetGraphsOnRight(bool isOnRight) {} // 0x00000001865A2CF0-0x00000001865A2D20
	public static void SetGraphProperties(object key, string label, float min, float max, int group, Color color, bool autoScale) {} // 0x00000001865A2D20-0x00000001865A2ED0
	public static bool GetGraphExists(object key) => default; // 0x00000001865A2ED0-0x00000001865A2F60
	public static void Graph(object key, float val) {} // 0x00000001865A2F60-0x00000001865A3050
	public static void RemoveGraph(object key) {} // 0x00000001865A3050-0x00000001865A3090
	public static void ClearGraph(object key) {} // 0x00000001865A3090-0x00000001865A3290
	private void InstanceLogPersistent(object key, object message) {} // 0x00000001865A3290-0x00000001865A33E0
	private void InstanceRemovePersistent(object key) {} // 0x00000001865A33E0-0x00000001865A3480
	private void InstanceClearPersistent() {} // 0x00000001865A3480-0x00000001865A34D0
	private void InstanceRemoveGraph(object key) {} // 0x00000001865A34D0-0x00000001865A36B0
	private void InstanceClearGraph(object key) {} // 0x00000001865A36B0-0x00000001865A3890
	private void InstanceLog(string str) {} // 0x00000001865A3890-0x00000001865A3A90
	private void InstanceGraph(object key, float val) {} // 0x00000001865A3A90-0x00000001865A3B60
	private void InstanceSetGraphProperties(object key, string label, float min, float max, int group, Color color, bool autoScale) {} // 0x00000001865A3B60-0x00000001865A3CF0
	private bool InstanceGetGraphExists(object key) => default; // 0x00000001865A3CF0-0x00000001865A3D70
	private void InstanceCreateGraph(object key) {} // 0x00000001865A3D70-0x00000001865A3E90
	private void Awake() {} // 0x00000001865A3E90-0x00000001865A3F00
	private void Update() {} // 0x00000001865A3F00-0x00000001865A4860
	private void OnGUI() {} // 0x00000001865A4860-0x00000001865A4960
	private void InitializeGUIStyles() {} // 0x00000001865A4960-0x00000001865A4D60
	private void DrawLogs() {} // 0x00000001865A4D60-0x00000001865A5C70
	private void DrawLabel(string label) {} // 0x00000001865A5C70-0x00000001865A5D80
	private void DrawGraphs() {} // 0x00000001865A5D80-0x00000001865A7AF0
	public static void ForceReinitializeAttributes() {} // 0x00000001865A7AF0-0x00000001865A8770
	private void RegisterAttributes() {} // 0x00000001865A8770-0x00000001865A9E00
	private void CleanUpDeletedAtributes() {} // 0x00000001865A9E00-0x00000001865AA370
	private void OnDestroy() {} // 0x00000001865AA370-0x00000001865AA470
}


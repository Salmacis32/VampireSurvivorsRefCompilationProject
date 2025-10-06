/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Profiling;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class ProcessQueue<T> // TypeDefIndex: 38159
{
	// Fields
	private List<T> _pending;
	private List<KeyValuePair<T, int>> _pendingInserts;
	private List<T> _active;
	private List<T> _destroy;
	private int _toProcess;
	private bool _checkQueue;
	private static readonly ProfilerMarker s_processQueueMarker;

	// Constructors
	public ProcessQueue() {}
	static ProcessQueue() {}

	// Methods
	public T add(T item) => default;
	public T insert(T item, int position) => default;
	public T remove(T item) => default;
	public ProcessQueue<T> removeAll() => default;
	public List<T> Update() => default;
	private List<T> getActive() => default;
	private int length() => default;
	public void destroy() {}
}


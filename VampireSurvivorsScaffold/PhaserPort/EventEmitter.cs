/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class EventEmitter // TypeDefIndex: 38096
{
	// Fields
	private Delegate[] callbacks; // 0x10

	// Constructors
	public EventEmitter() {} // 0x0000000184C45E80-0x0000000184C45F10

	// Methods
	public DelegateType getDelegate<DelegateType>(WorldEvents evt)
		where DelegateType : Delegate => default;
	public void on<DelegateType>(DelegateType a, WorldEvents evt)
		where DelegateType : Delegate {}
	public void emit(WorldEvents evt) {} // 0x0000000184C45DF0-0x0000000184C45E80
	public void emit<T1>(WorldEvents evt, T1 arg1) {}
	public void emit<T1, T2>(WorldEvents evt, T1 arg1, T2 arg2) {}
	public void emit<T1, T2, T3>(WorldEvents evt, T1 arg1, T2 arg2, T3 arg3) {}
	public void emit<T1, T2, T3, T4>(WorldEvents evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4) {}
	public void emit<T1, T2, T3, T4, T5>(WorldEvents evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) {}
	public void emit<T1, T2, T3, T4, T5, T6>(WorldEvents evt, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) {}
	public void removeAllListeners() {} // 0x00000001838BBAC0-0x00000001838BBB70
}


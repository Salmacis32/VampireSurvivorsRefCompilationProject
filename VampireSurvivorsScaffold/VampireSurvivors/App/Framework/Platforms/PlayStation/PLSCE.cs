/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.App.Framework.Platforms.PlayStation
{
	public static class PLSCE // TypeDefIndex: 18606
	{
		// Fields
		public const int SCE_OK = 0; // Metadata: 0x0197AD85
		public const int k_INVALID_REQUESTID = -666; // Metadata: 0x0197AD86
		public const int PL_INVALID_SCE_ERROR_CODE = -267581850; // Metadata: 0x0197AD88
		public const int PL_SAVEDATA_IO_ERROR_UNKNOWN = -267581851; // Metadata: 0x0197AD8C
		public const int PL_SAVEDATA_IO_FILEPATH_NOLEADINGSLASH = -267581852; // Metadata: 0x0197AD90
		public const int PL_SAVEDATA_IO_FILEPATH_NOT_FOUND = -267581853; // Metadata: 0x0197AD94
		public const int PL_SAVEDATA_IO_BACKUP_NO_RESPONSE = -267581854; // Metadata: 0x0197AD98
		public const int SCE_USER_SERVICE_ERROR_INTERNAL = -2137653247; // Metadata: 0x0197AD9C
		public const int SCE_USER_SERVICE_ERROR_NOT_INITIALIZED = -2137653246; // Metadata: 0x0197ADA1
		public const int SCE_USER_SERVICE_ERROR_ALREADY_INITIALIZED = -2137653245; // Metadata: 0x0197ADA6
		public const int SCE_USER_SERVICE_ERROR_NO_MEMORY = -2137653244; // Metadata: 0x0197ADAB
		public const int SCE_USER_SERVICE_ERROR_INVALID_ARGUMENT = -2137653243; // Metadata: 0x0197ADB0
		public const int SCE_USER_SERVICE_ERROR_OPERATION_NOT_SUPPORTED = -2137653242; // Metadata: 0x0197ADB5
		public const int SCE_USER_SERVICE_ERROR_NO_EVENT = -2137653241; // Metadata: 0x0197ADBA
		public const int SCE_USER_SERVICE_ERROR_NOT_LOGGED_IN = -2137653239; // Metadata: 0x0197ADBF
		public const int SCE_USER_SERVICE_ERROR_BUFFER_TOO_SHORT = -2137653238; // Metadata: 0x0197ADC4
		public const int SCE_SAVE_DATA_ERROR_PARAMETER = -2137063424; // Metadata: 0x0197ADC9
		public const int SCE_SAVE_DATA_ERROR_NOT_INITIALIZED = -2137063423; // Metadata: 0x0197ADCE
		public const int SCE_SAVE_DATA_ERROR_OUT_OF_MEMORY = -2137063422; // Metadata: 0x0197ADD3
		public const int SCE_SAVE_DATA_ERROR_BUSY = -2137063421; // Metadata: 0x0197ADD8
		public const int SCE_SAVE_DATA_ERROR_NOT_MOUNTED = -2137063420; // Metadata: 0x0197ADDD
		public const int SCE_SAVE_DATA_ERROR_NO_PERMISSION = -2137063419; // Metadata: 0x0197ADE2
		public const int SCE_SAVE_DATA_ERROR_FINGERPRINT_MISMATCH = -2137063418; // Metadata: 0x0197ADE7
		public const int SCE_SAVE_DATA_ERROR_EXISTS = -2137063417; // Metadata: 0x0197ADEC
		public const int SCE_SAVE_DATA_ERROR_NOT_FOUND = -2137063416; // Metadata: 0x0197ADF1
		public const int SCE_SAVE_DATA_ERROR_NO_SPACE = -2137063415; // Metadata: 0x0197ADF6
		public const int SCE_SAVE_DATA_ERROR_NO_SPACE_FS = -2137063414; // Metadata: 0x0197ADFB
		public const int SCE_SAVE_DATA_ERROR_INTERNAL = -2137063413; // Metadata: 0x0197AE00
		public const int SCE_SAVE_DATA_ERROR_MOUNT_FULL = -2137063412; // Metadata: 0x0197AE05
		public const int SCE_SAVE_DATA_ERROR_BAD_MOUNTED = -2137063411; // Metadata: 0x0197AE0A
		public const int SCE_SAVE_DATA_ERROR_FILE_NOT_FOUND = -2137063410; // Metadata: 0x0197AE0F
		public const int SCE_SAVE_DATA_ERROR_BROKEN = -2137063409; // Metadata: 0x0197AE14
		public const int SCE_SAVE_DATA_ERROR_INVALID_LOGIN_USER = -2137063407; // Metadata: 0x0197AE19
		public const int SCE_SAVE_DATA_ERROR_MEMORY_NOT_READY = -2137063406; // Metadata: 0x0197AE1E
		public const int SCE_SAVE_DATA_ERROR_BACKUP_BUSY = -2137063405; // Metadata: 0x0197AE23
		public const int SCE_SAVE_DATA_ERROR_NOT_REGIST_CALLBACK = -2137063403; // Metadata: 0x0197AE28
		public const int SCE_SAVE_DATA_ERROR_BUSY_FOR_SAVING = -2137063402; // Metadata: 0x0197AE2D
		public const int SCE_SAVE_DATA_ERROR_LIMITATION_OVER = -2137063401; // Metadata: 0x0197AE32
		public const int SCE_SAVE_DATA_ERROR_EVENT_BUSY = -2137063400; // Metadata: 0x0197AE37
		public const int SCE_SAVE_DATA_ERROR_PARAMSFO_TRANSFER_TITLE_ID_NOT_FOUND = -2137063399; // Metadata: 0x0197AE3C
		public const int SCE_SAVE_DATA_ERROR_RESOURCE_FULL = -2137063398; // Metadata: 0x0197AE41
		public const int SCE_SAVE_DATA_ERROR_RESOURCE_BUSY = -2137063397; // Metadata: 0x0197AE46
		public const int SCE_SAVE_DATA_ERROR_RESOURCE_INVALID = -2137063396; // Metadata: 0x0197AE4B
		private const int SCE_COMMON_DIALOG_ERROR_NOT_SYSTEM_INITIALIZED = -2135425023; // Metadata: 0x0197AE50
		private const int SCE_COMMON_DIALOG_ERROR_ALREADY_SYSTEM_INITIALIZED = -2135425022; // Metadata: 0x0197AE55
		private const int SCE_COMMON_DIALOG_ERROR_NOT_INITIALIZED = -2135425021; // Metadata: 0x0197AE5A
		private const int SCE_COMMON_DIALOG_ERROR_ALREADY_INITIALIZED = -2135425020; // Metadata: 0x0197AE5F
		private const int SCE_COMMON_DIALOG_ERROR_NOT_FINISHED = -2135425019; // Metadata: 0x0197AE64
		private const int SCE_COMMON_DIALOG_ERROR_INVALID_STATE = -2135425018; // Metadata: 0x0197AE69
		private const int SCE_COMMON_DIALOG_ERROR_RESULT_NONE = -2135425017; // Metadata: 0x0197AE6E
		private const int SCE_COMMON_DIALOG_ERROR_BUSY = -2135425016; // Metadata: 0x0197AE73
		private const int SCE_COMMON_DIALOG_ERROR_OUT_OF_MEMORY = -2135425015; // Metadata: 0x0197AE78
		private const int SCE_COMMON_DIALOG_ERROR_PARAM_INVALID = -2135425014; // Metadata: 0x0197AE7D
		private const int SCE_COMMON_DIALOG_ERROR_NOT_RUNNING = -2135425013; // Metadata: 0x0197AE82
		private const int SCE_COMMON_DIALOG_ERROR_ALREADY_CLOSE = -2135425012; // Metadata: 0x0197AE87
		private const int SCE_COMMON_DIALOG_ERROR_ARG_NULL = -2135425011; // Metadata: 0x0197AE8C
		private const int SCE_COMMON_DIALOG_ERROR_UNEXPECTED_FATAL = -2135425010; // Metadata: 0x0197AE91
		private const int SCE_COMMON_DIALOG_ERROR_NOT_SUPPORTED = -2135425009; // Metadata: 0x0197AE96
		private const int SCE_COMMON_DIALOG_ERROR_INHIBIT_SHAREPLAY_CLIENT = -2135425008; // Metadata: 0x0197AE9B
	
		// Methods
		public static bool Succeeded(int sceReturnCode) => default; // 0x00000001867F1960-0x00000001867F1970
		public static int MapFileIOExceptionToError(Exception exceptionDuringFileIO) => default; // 0x00000001867F1970-0x00000001867F19B0
		public static string GetName(int sceReturnCode) => default; // 0x00000001867F19B0-0x00000001867F2240
	}
}

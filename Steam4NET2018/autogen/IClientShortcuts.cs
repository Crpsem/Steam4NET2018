// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientShortcutsVTable
	{
		public IntPtr GetUniqueLocalAppId0;
		public IntPtr GetGameIDForAppID1;
		public IntPtr GetAppIDForGameID2;
		public IntPtr GetShortcutCount3;
		public IntPtr GetShortcutAppIDByIndex4;
		public IntPtr GetShortcutAppNameByIndex5;
		public IntPtr GetShortcutExeByIndex6;
		public IntPtr GetShortcutUserTagCountByIndex7;
		public IntPtr GetShortcutUserTagByIndex8;
		public IntPtr BIsShortcutRemoteByIndex9;
		public IntPtr GetShortcutAppNameByAppID10;
		public IntPtr GetShortcutExeByAppID11;
		public IntPtr GetShortcutStartDirByAppID12;
		public IntPtr GetShortcutIconByAppID13;
		public IntPtr GetShortcutUserTagCountByAppID14;
		public IntPtr GetShortcutUserTagByAppID15;
		public IntPtr BIsShortcutRemoteByAppID16;
		public IntPtr AddShortcut17;
		public IntPtr SetShortcutFromFullpath18;
		public IntPtr SetShortcutAppName19;
		public IntPtr SetShortcutExe20;
		public IntPtr SetShortcutStartDir21;
		public IntPtr SetShortcutIcon22;
		public IntPtr ClearShortcutUserTags23;
		public IntPtr AddShortcutUserTag24;
		public IntPtr RemoveShortcut25;
		public IntPtr LaunchShortcut26;
		private IntPtr DTorIClientShortcuts27;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTSHORTCUTS_INTERFACE_VERSION001")]
	public class IClientShortcuts : InteropHelp.NativeWrapper<IClientShortcutsVTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetUniqueLocalAppId( IntPtr thisptr );
		public UInt32 GetUniqueLocalAppId(  ) 
		{
			return this.GetFunction<NativeGetUniqueLocalAppId>( this.Functions.GetUniqueLocalAppId0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameIDForAppIDU( IntPtr thisptr, ref UInt64 retarg, UInt32 unAppID );
		public CGameID GetGameIDForAppID( UInt32 unAppID ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetGameIDForAppIDU>( this.Functions.GetGameIDForAppID1 )( this.ObjectAddress, ref ret, unAppID ); return new CGameID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppIDForGameIDC( IntPtr thisptr, UInt64 gameID );
		public UInt32 GetAppIDForGameID( CGameID gameID ) 
		{
			return this.GetFunction<NativeGetAppIDForGameIDC>( this.Functions.GetAppIDForGameID2 )( this.ObjectAddress, gameID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutCount( IntPtr thisptr );
		public UInt32 GetShortcutCount(  ) 
		{
			return this.GetFunction<NativeGetShortcutCount>( this.Functions.GetShortcutCount3 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutAppIDByIndexU( IntPtr thisptr, UInt32 uIndex );
		public UInt32 GetShortcutAppIDByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeGetShortcutAppIDByIndexU>( this.Functions.GetShortcutAppIDByIndex4 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutAppNameByIndexU( IntPtr thisptr, UInt32 uIndex );
		public string GetShortcutAppNameByIndex( UInt32 uIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutAppNameByIndexU>( this.Functions.GetShortcutAppNameByIndex5 )( this.ObjectAddress, uIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutExeByIndexU( IntPtr thisptr, UInt32 uIndex );
		public string GetShortcutExeByIndex( UInt32 uIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutExeByIndexU>( this.Functions.GetShortcutExeByIndex6 )( this.ObjectAddress, uIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutUserTagCountByIndexU( IntPtr thisptr, UInt32 uIndex );
		public UInt32 GetShortcutUserTagCountByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeGetShortcutUserTagCountByIndexU>( this.Functions.GetShortcutUserTagCountByIndex7 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutUserTagByIndexUU( IntPtr thisptr, UInt32 uIndex, UInt32 arg1 );
		public string GetShortcutUserTagByIndex( UInt32 uIndex, UInt32 arg1 ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutUserTagByIndexUU>( this.Functions.GetShortcutUserTagByIndex8 )( this.ObjectAddress, uIndex, arg1 ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsShortcutRemoteByIndexU( IntPtr thisptr, UInt32 uIndex );
		public bool BIsShortcutRemoteByIndex( UInt32 uIndex ) 
		{
			return this.GetFunction<NativeBIsShortcutRemoteByIndexU>( this.Functions.BIsShortcutRemoteByIndex9 )( this.ObjectAddress, uIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutAppNameByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutAppNameByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutAppNameByAppIDU>( this.Functions.GetShortcutAppNameByAppID10 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutExeByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutExeByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutExeByAppIDU>( this.Functions.GetShortcutExeByAppID11 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutStartDirByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutStartDirByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutStartDirByAppIDU>( this.Functions.GetShortcutStartDirByAppID12 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutIconByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public string GetShortcutIconByAppID( UInt32 unAppID ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutIconByAppIDU>( this.Functions.GetShortcutIconByAppID13 )( this.ObjectAddress, unAppID ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetShortcutUserTagCountByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public UInt32 GetShortcutUserTagCountByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeGetShortcutUserTagCountByAppIDU>( this.Functions.GetShortcutUserTagCountByAppID14 )( this.ObjectAddress, unAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetShortcutUserTagByAppIDUU( IntPtr thisptr, UInt32 unAppID, UInt32 arg1 );
		public string GetShortcutUserTagByAppID( UInt32 unAppID, UInt32 arg1 ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetShortcutUserTagByAppIDUU>( this.Functions.GetShortcutUserTagByAppID15 )( this.ObjectAddress, unAppID, arg1 ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsShortcutRemoteByAppIDU( IntPtr thisptr, UInt32 unAppID );
		public bool BIsShortcutRemoteByAppID( UInt32 unAppID ) 
		{
			return this.GetFunction<NativeBIsShortcutRemoteByAppIDU>( this.Functions.BIsShortcutRemoteByAppID16 )( this.ObjectAddress, unAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeAddShortcutSSS( IntPtr thisptr, string arg0, string arg1, string arg2 );
		public UInt32 AddShortcut( string arg0, string arg1, string arg2 ) 
		{
			return this.GetFunction<NativeAddShortcutSSS>( this.Functions.AddShortcut17 )( this.ObjectAddress, arg0, arg1, arg2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutFromFullpathUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutFromFullpath( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutFromFullpathUS>( this.Functions.SetShortcutFromFullpath18 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutAppNameUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutAppName( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutAppNameUS>( this.Functions.SetShortcutAppName19 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutExeUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutExe( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutExeUS>( this.Functions.SetShortcutExe20 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutStartDirUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutStartDir( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutStartDirUS>( this.Functions.SetShortcutStartDir21 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetShortcutIconUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void SetShortcutIcon( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeSetShortcutIconUS>( this.Functions.SetShortcutIcon22 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearShortcutUserTagsU( IntPtr thisptr, UInt32 arg0 );
		public void ClearShortcutUserTags( UInt32 arg0 ) 
		{
			this.GetFunction<NativeClearShortcutUserTagsU>( this.Functions.ClearShortcutUserTags23 )( this.ObjectAddress, arg0 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddShortcutUserTagUS( IntPtr thisptr, UInt32 arg0, string arg1 );
		public void AddShortcutUserTag( UInt32 arg0, string arg1 ) 
		{
			this.GetFunction<NativeAddShortcutUserTagUS>( this.Functions.AddShortcutUserTag24 )( this.ObjectAddress, arg0, arg1 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRemoveShortcutU( IntPtr thisptr, UInt32 arg0 );
		public void RemoveShortcut( UInt32 arg0 ) 
		{
			this.GetFunction<NativeRemoveShortcutU>( this.Functions.RemoveShortcut25 )( this.ObjectAddress, arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLaunchShortcutU( IntPtr thisptr, UInt32 arg0 );
		public bool LaunchShortcut( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeLaunchShortcutU>( this.Functions.LaunchShortcut26 )( this.ObjectAddress, arg0 ); 
		}
		
	};
}

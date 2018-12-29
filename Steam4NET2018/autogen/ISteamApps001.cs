// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamApps001VTable
	{
		public IntPtr GetAppData0;
		private IntPtr DTorISteamApps0011;
	};
	
	[InteropHelp.InterfaceVersion("STEAMAPPS_INTERFACE_VERSION001")]
	public class ISteamApps001 : InteropHelp.NativeWrapper<ISteamApps001VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetAppDataUSSI( IntPtr thisptr, UInt32 nAppID, string pchKey, StringBuilder pchValue, Int32 cchValueMax );
		public Int32 GetAppData( UInt32 nAppID, string pchKey, StringBuilder pchValue ) 
		{
			return this.GetFunction<NativeGetAppDataUSSI>( this.Functions.GetAppData0 )( this.ObjectAddress, nAppID, pchKey, pchValue, (Int32) pchValue.Capacity ); 
		}
		
	};
}

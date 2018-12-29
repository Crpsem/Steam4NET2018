// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct TSteamExternalBillingInfo
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 101)]
		public string szAccountName;
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]
		public string szPassword;
	};
	
}

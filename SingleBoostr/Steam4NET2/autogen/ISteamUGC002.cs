// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamUGC002VTable
	{
		public IntPtr CreateQueryUserUGCRequest0;
		public IntPtr CreateQueryAllUGCRequest1;
		public IntPtr SendQueryUGCRequest2;
		public IntPtr GetQueryUGCResult3;
		public IntPtr ReleaseQueryUGCRequest4;
		public IntPtr AddRequiredTag5;
		public IntPtr AddExcludedTag6;
		public IntPtr SetReturnLongDescription7;
		public IntPtr SetReturnTotalOnly8;
		public IntPtr SetAllowCachedResponse9;
		public IntPtr SetCloudFileNameFilter10;
		public IntPtr SetMatchAnyTag11;
		public IntPtr SetSearchText12;
		public IntPtr SetRankedByTrendDays13;
		public IntPtr RequestUGCDetails14;
		private IntPtr DTorISteamUGC00215;
	};
	
	[InteropHelp.InterfaceVersion("STEAMUGC_INTERFACE_VERSION002")]
	public class ISteamUGC002 : InteropHelp.NativeWrapper<ISteamUGC002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreateQueryUserUGCRequestUEEEUUU( IntPtr thisptr, UInt32 unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, UInt32 nCreatorAppID, UInt32 nConsumerAppID, UInt32 unPage );
		public UInt64 CreateQueryUserUGCRequest( UInt32 unAccountID, EUserUGCList eListType, EUGCMatchingUGCType eMatchingUGCType, EUserUGCListSortOrder eSortOrder, UInt32 nCreatorAppID, UInt32 nConsumerAppID, UInt32 unPage ) 
		{
			return this.GetFunction<NativeCreateQueryUserUGCRequestUEEEUUU>( this.Functions.CreateQueryUserUGCRequest0 )( this.ObjectAddress, unAccountID, eListType, eMatchingUGCType, eSortOrder, nCreatorAppID, nConsumerAppID, unPage ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreateQueryAllUGCRequestEEUUU( IntPtr thisptr, EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, UInt32 nCreatorAppID, UInt32 nConsumerAppID, UInt32 unPage );
		public UInt64 CreateQueryAllUGCRequest( EUGCQuery eQueryType, EUGCMatchingUGCType eMatchingeMatchingUGCTypeFileType, UInt32 nCreatorAppID, UInt32 nConsumerAppID, UInt32 unPage ) 
		{
			return this.GetFunction<NativeCreateQueryAllUGCRequestEEUUU>( this.Functions.CreateQueryAllUGCRequest1 )( this.ObjectAddress, eQueryType, eMatchingeMatchingUGCTypeFileType, nCreatorAppID, nConsumerAppID, unPage ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSendQueryUGCRequestU( IntPtr thisptr, UInt64 handle );
		public UInt64 SendQueryUGCRequest( UInt64 handle ) 
		{
			return this.GetFunction<NativeSendQueryUGCRequestU>( this.Functions.SendQueryUGCRequest2 )( this.ObjectAddress, handle ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQueryUGCResultUUS( IntPtr thisptr, UInt64 handle, UInt32 index, ref SteamUGCDetails_t pDetails );
		public bool GetQueryUGCResult( UInt64 handle, UInt32 index, ref SteamUGCDetails_t pDetails ) 
		{
			return this.GetFunction<NativeGetQueryUGCResultUUS>( this.Functions.GetQueryUGCResult3 )( this.ObjectAddress, handle, index, ref pDetails ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReleaseQueryUGCRequestU( IntPtr thisptr, UInt64 handle );
		public bool ReleaseQueryUGCRequest( UInt64 handle ) 
		{
			return this.GetFunction<NativeReleaseQueryUGCRequestU>( this.Functions.ReleaseQueryUGCRequest4 )( this.ObjectAddress, handle ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddRequiredTagUS( IntPtr thisptr, UInt64 handle, string pTagName );
		public bool AddRequiredTag( UInt64 handle, string pTagName ) 
		{
			return this.GetFunction<NativeAddRequiredTagUS>( this.Functions.AddRequiredTag5 )( this.ObjectAddress, handle, pTagName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddExcludedTagUS( IntPtr thisptr, UInt64 handle, string pTagName );
		public bool AddExcludedTag( UInt64 handle, string pTagName ) 
		{
			return this.GetFunction<NativeAddExcludedTagUS>( this.Functions.AddExcludedTag6 )( this.ObjectAddress, handle, pTagName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetReturnLongDescriptionUB( IntPtr thisptr, UInt64 handle, [MarshalAs(UnmanagedType.I1)] bool bReturnLongDescription );
		public bool SetReturnLongDescription( UInt64 handle, bool bReturnLongDescription ) 
		{
			return this.GetFunction<NativeSetReturnLongDescriptionUB>( this.Functions.SetReturnLongDescription7 )( this.ObjectAddress, handle, bReturnLongDescription ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetReturnTotalOnlyUB( IntPtr thisptr, UInt64 handle, [MarshalAs(UnmanagedType.I1)] bool bReturnTotalOnly );
		public bool SetReturnTotalOnly( UInt64 handle, bool bReturnTotalOnly ) 
		{
			return this.GetFunction<NativeSetReturnTotalOnlyUB>( this.Functions.SetReturnTotalOnly8 )( this.ObjectAddress, handle, bReturnTotalOnly ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetAllowCachedResponseUU( IntPtr thisptr, UInt64 handle, UInt32 uUnk );
		public bool SetAllowCachedResponse( UInt64 handle, UInt32 uUnk ) 
		{
			return this.GetFunction<NativeSetAllowCachedResponseUU>( this.Functions.SetAllowCachedResponse9 )( this.ObjectAddress, handle, uUnk ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetCloudFileNameFilterUS( IntPtr thisptr, UInt64 handle, string pMatchCloudFileName );
		public bool SetCloudFileNameFilter( UInt64 handle, string pMatchCloudFileName ) 
		{
			return this.GetFunction<NativeSetCloudFileNameFilterUS>( this.Functions.SetCloudFileNameFilter10 )( this.ObjectAddress, handle, pMatchCloudFileName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetMatchAnyTagUB( IntPtr thisptr, UInt64 handle, [MarshalAs(UnmanagedType.I1)] bool bMatchAnyTag );
		public bool SetMatchAnyTag( UInt64 handle, bool bMatchAnyTag ) 
		{
			return this.GetFunction<NativeSetMatchAnyTagUB>( this.Functions.SetMatchAnyTag11 )( this.ObjectAddress, handle, bMatchAnyTag ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetSearchTextUS( IntPtr thisptr, UInt64 handle, string pSearchText );
		public bool SetSearchText( UInt64 handle, string pSearchText ) 
		{
			return this.GetFunction<NativeSetSearchTextUS>( this.Functions.SetSearchText12 )( this.ObjectAddress, handle, pSearchText ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRankedByTrendDaysUU( IntPtr thisptr, UInt64 handle, UInt32 unDays );
		public bool SetRankedByTrendDays( UInt64 handle, UInt32 unDays ) 
		{
			return this.GetFunction<NativeSetRankedByTrendDaysUU>( this.Functions.SetRankedByTrendDays13 )( this.ObjectAddress, handle, unDays ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUGCDetailsUU( IntPtr thisptr, UInt64 nPublishedFileID, UInt32 uUnk );
		public UInt64 RequestUGCDetails( UInt64 nPublishedFileID, UInt32 uUnk ) 
		{
			return this.GetFunction<NativeRequestUGCDetailsUU>( this.Functions.RequestUGCDetails14 )( this.ObjectAddress, nPublishedFileID, uUnk ); 
		}
		
	};
}

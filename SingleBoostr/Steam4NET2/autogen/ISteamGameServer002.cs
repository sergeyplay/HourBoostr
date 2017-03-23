// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamGameServer002VTable
	{
		public IntPtr LogOn0;
		public IntPtr LogOff1;
		public IntPtr BLoggedOn2;
		public IntPtr SetSpawnCount3;
		public IntPtr GetSteam2GetEncryptionKeyToSendToNewClient4;
		public IntPtr SendSteam2UserConnect5;
		public IntPtr SendSteam3UserConnect6;
		public IntPtr RemoveUserConnect7;
		public IntPtr SendUserDisconnect8;
		public IntPtr SendUserStatusResponse9;
		public IntPtr Obsolete_GSSetStatus10;
		public IntPtr UpdateStatus11;
		public IntPtr BSecure12;
		public IntPtr GetSteamID13;
		public IntPtr SetServerType14;
		public IntPtr SetServerType215;
		public IntPtr UpdateStatus216;
		public IntPtr CreateUnauthenticatedUser17;
		public IntPtr SetUserData18;
		public IntPtr UpdateSpectatorPort19;
		public IntPtr SetGameType20;
		private IntPtr DTorISteamGameServer00221;
	};
	
	[InteropHelp.InterfaceVersion("SteamGameServer002")]
	public class ISteamGameServer002 : InteropHelp.NativeWrapper<ISteamGameServer002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOn( IntPtr thisptr );
		public void LogOn(  ) 
		{
			this.GetFunction<NativeLogOn>( this.Functions.LogOn0 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff( IntPtr thisptr );
		public void LogOff(  ) 
		{
			this.GetFunction<NativeLogOff>( this.Functions.LogOff1 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn( IntPtr thisptr );
		public bool BLoggedOn(  ) 
		{
			return this.GetFunction<NativeBLoggedOn>( this.Functions.BLoggedOn2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpawnCountU( IntPtr thisptr, UInt32 ucSpawn );
		public void SetSpawnCount( UInt32 ucSpawn ) 
		{
			this.GetFunction<NativeSetSpawnCountU>( this.Functions.SetSpawnCount3 )( this.ObjectAddress, ucSpawn ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetSteam2GetEncryptionKeyToSendToNewClientBUU( IntPtr thisptr, Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey );
		public bool GetSteam2GetEncryptionKeyToSendToNewClient( Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey ) 
		{
			return this.GetFunction<NativeGetSteam2GetEncryptionKeyToSendToNewClientBUU>( this.Functions.GetSteam2GetEncryptionKeyToSendToNewClient4 )( this.ObjectAddress, pvEncryptionKey, ref pcbEncryptionKey, cbMaxEncryptionKey ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendSteam2UserConnectUBUUUBU( IntPtr thisptr, UInt32 unUserID, Byte[] pvRawKey, UInt32 unKeyLen, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie, UInt32 cubCookie );
		public bool SendSteam2UserConnect( UInt32 unUserID, Byte[] pvRawKey, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie ) 
		{
			return this.GetFunction<NativeSendSteam2UserConnectUBUUUBU>( this.Functions.SendSteam2UserConnect5 )( this.ObjectAddress, unUserID, pvRawKey, (UInt32) pvRawKey.Length, unIPPublic, usPort, pvCookie, (UInt32) pvCookie.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendSteam3UserConnectCUBU( IntPtr thisptr, UInt64 steamID, UInt32 unIPPublic, Byte[] pvCookie, UInt32 cubCookie );
		public bool SendSteam3UserConnect( CSteamID steamID, UInt32 unIPPublic, Byte[] pvCookie ) 
		{
			return this.GetFunction<NativeSendSteam3UserConnectCUBU>( this.Functions.SendSteam3UserConnect6 )( this.ObjectAddress, steamID.ConvertToUint64(), unIPPublic, pvCookie, (UInt32) pvCookie.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveUserConnectU( IntPtr thisptr, UInt32 unUserID );
		public bool RemoveUserConnect( UInt32 unUserID ) 
		{
			return this.GetFunction<NativeRemoveUserConnectU>( this.Functions.RemoveUserConnect7 )( this.ObjectAddress, unUserID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserDisconnectCU( IntPtr thisptr, UInt64 steamID, UInt32 unUserID );
		public bool SendUserDisconnect( CSteamID steamID, UInt32 unUserID ) 
		{
			return this.GetFunction<NativeSendUserDisconnectCU>( this.Functions.SendUserDisconnect8 )( this.ObjectAddress, steamID.ConvertToUint64(), unUserID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserStatusResponseCII( IntPtr thisptr, UInt64 steamID, Int32 nSecondsConnected, Int32 nSecondsSinceLast );
		public bool SendUserStatusResponse( CSteamID steamID, Int32 nSecondsConnected, Int32 nSecondsSinceLast ) 
		{
			return this.GetFunction<NativeSendUserStatusResponseCII>( this.Functions.SendUserStatusResponse9 )( this.ObjectAddress, steamID.ConvertToUint64(), nSecondsConnected, nSecondsSinceLast ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeObsolete_GSSetStatusIUIIIISSSS( IntPtr thisptr, Int32 nAppIdServed, UInt32 unServerFlags, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, Int32 unGamePort, string pchServerName, string pchGameDir, string pchMapName, string pchVersion );
		public bool Obsolete_GSSetStatus( Int32 nAppIdServed, UInt32 unServerFlags, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, Int32 unGamePort, string pchServerName, string pchGameDir, string pchMapName, string pchVersion ) 
		{
			return this.GetFunction<NativeObsolete_GSSetStatusIUIIIISSSS>( this.Functions.Obsolete_GSSetStatus10 )( this.ObjectAddress, nAppIdServed, unServerFlags, cPlayers, cPlayersMax, cBotPlayers, unGamePort, pchServerName, pchGameDir, pchMapName, pchVersion ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateStatusIIISS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pchMapName );
		public bool UpdateStatus( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pchMapName ) 
		{
			return this.GetFunction<NativeUpdateStatusIIISS>( this.Functions.UpdateStatus11 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pchMapName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSecure( IntPtr thisptr );
		public bool BSecure(  ) 
		{
			return this.GetFunction<NativeBSecure>( this.Functions.BSecure12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID( IntPtr thisptr, ref UInt64 retarg );
		public CSteamID GetSteamID(  ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetSteamID>( this.Functions.GetSteamID13 )( this.ObjectAddress, ref ret ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetServerTypeIUUUSS( IntPtr thisptr, Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt32 unGamePort, string pchGameDir, string pchVersion );
		public bool SetServerType( Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt32 unGamePort, string pchGameDir, string pchVersion ) 
		{
			return this.GetFunction<NativeSetServerTypeIUUUSS>( this.Functions.SetServerType14 )( this.ObjectAddress, nGameAppId, unServerFlags, unGameIP, unGamePort, pchGameDir, pchVersion ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetServerType2IUUUUUSSB( IntPtr thisptr, Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode );
		public bool SetServerType2( Int32 nGameAppId, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 usSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode ) 
		{
			return this.GetFunction<NativeSetServerType2IUUUUUSSB>( this.Functions.SetServerType215 )( this.ObjectAddress, nGameAppId, unServerFlags, unGameIP, unGamePort, usSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateStatus2IIISSS( IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName );
		public bool UpdateStatus2( Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName ) 
		{
			return this.GetFunction<NativeUpdateStatus2IIISSS>( this.Functions.UpdateStatus216 )( this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCreateUnauthenticatedUserC( IntPtr thisptr, ref UInt64 pSteamID );
		public bool CreateUnauthenticatedUser( ref CSteamID pSteamID ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeCreateUnauthenticatedUserC>( this.Functions.CreateUnauthenticatedUser17 )( this.ObjectAddress, ref s0 ); pSteamID = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserDataCSU( IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore );
		public bool SetUserData( CSteamID steamIDUser, string pchPlayerName, UInt32 uScore ) 
		{
			return this.GetFunction<NativeSetUserDataCSU>( this.Functions.SetUserData18 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateSpectatorPortU( IntPtr thisptr, UInt16 unSpectatorPort );
		public void UpdateSpectatorPort( UInt16 unSpectatorPort ) 
		{
			this.GetFunction<NativeUpdateSpectatorPortU>( this.Functions.UpdateSpectatorPort19 )( this.ObjectAddress, unSpectatorPort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTypeS( IntPtr thisptr, string pchGameType );
		public void SetGameType( string pchGameType ) 
		{
			this.GetFunction<NativeSetGameTypeS>( this.Functions.SetGameType20 )( this.ObjectAddress, pchGameType ); 
		}
		
	};
}

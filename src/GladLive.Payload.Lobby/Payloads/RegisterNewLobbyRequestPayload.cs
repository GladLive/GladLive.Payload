using GladLive.Payload.Common;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GladLive.Payload.Lobby
{
	/// <summary>
	/// Represents the payload of the request to register the current user's lobby in the lobby system.
	/// </summary>
	[GladNetSerializationContract]
	[AuthorizationRequired] //this is obviously a request that requires authorization.
	[GladLivePayload(GladLivePayloadMessageType.RegisterNewLobbyRequest)]
	public class RegisterNewLobbyRequestPayload<TConnectionDetailsType, TLobbyDetailsType> : PacketPayload
		where TConnectionDetailsType : class, ILobbyConnectionDetails
		where TLobbyDetailsType : class, ILobbyDetails
	{
		/// <summary>
		/// Represents the data a remote connection would use to connect to the current lobby session.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public TConnectionDetailsType LobbyConnectionDetails { get; private set; }

		/// <summary>
		/// Represents the details about the lobby.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		public TLobbyDetailsType LobbyDetails { get; private set; }

		public RegisterNewLobbyRequestPayload(TLobbyDetailsType lobbyDetails, TConnectionDetailsType connectionDetails)
		{
			LobbyConnectionDetails = connectionDetails;
			LobbyDetails = lobbyDetails;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected RegisterNewLobbyRequestPayload()
		{

		}
	}
}

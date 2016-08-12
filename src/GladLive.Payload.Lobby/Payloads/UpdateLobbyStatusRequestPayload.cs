using GladLive.Payload.Common;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Lobby.Payloads
{
	/// <summary>
	/// Represents a request to update the current lobby settings. This could include a change in gametype, privacy permissions or
	/// a change in maximum allowed player count.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.UpdateLobbyStatusRequest)]
	public class UpdateLobbyStatusRequestPayload<TLobbyDetailsType> : PacketPayload
		where TLobbyDetailsType : class, ILobbyDetails
	{
		/// <summary>
		/// Represents the details about the lobby.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public TLobbyDetailsType LobbyDetails { get; private set; }

		/// <summary>
		/// Creates a new <see cref="RegisterNewLobbyResponsePayload"/> with the provided <see cref="RegisterNewLobbyResponseCode"/>.
		/// </summary>
		/// <param name="responseCode"></param>
		public UpdateLobbyStatusRequestPayload(TLobbyDetailsType lobbyDetails)
		{
			LobbyDetails = lobbyDetails;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected UpdateLobbyStatusRequestPayload()
		{

		}
	}
}

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
	/// Represents the payload of the response to register the current user's lobby in the lobby system.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.RegisterNewLobbyResponse)]
	public class RegisterNewLobbyResponsePayload : PacketPayload, IResponseStatus<RegisterNewLobbyResponseCode>
	{
		/// <summary>
		/// Represents the data a remote connection would use to connect to the current lobby session.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public RegisterNewLobbyResponseCode ResponseCode { get; private set; }

		/// <summary>
		/// Creates a new <see cref="RegisterNewLobbyResponsePayload"/> with the provided <see cref="RegisterNewLobbyResponseCode"/>.
		/// </summary>
		/// <param name="responseCode"></param>
		public RegisterNewLobbyResponsePayload(RegisterNewLobbyResponseCode responseCode)
		{
			ResponseCode = responseCode;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected RegisterNewLobbyResponsePayload()
		{

		}
	}
}

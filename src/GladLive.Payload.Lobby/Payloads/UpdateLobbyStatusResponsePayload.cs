using GladLive.Payload.Common;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Lobby
{
	/// <summary>
	/// Represents a response that provides the details about the result of the attempted <see cref="UpdateLobbyStatusRequest"/>.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.UpdateLobbyStatusResponse)]
	public class UpdateLobbyStatusResponsePayload : PacketPayload, IResponseStatus<UpdateLobbyStatusResponseCode>
	{
		/// <summary>
		/// Response status; the response code of the request.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public UpdateLobbyStatusResponseCode ResponseCode { get; private set; }

		/// <summary>
		/// Creates a new <see cref="UpdateLobbyStatusResponsePayload"/> with the provided <see cref="UpdateLobbyStatusResponseCode"/>.
		/// </summary>
		/// <param name="responseCode"></param>
		public UpdateLobbyStatusResponsePayload(UpdateLobbyStatusResponseCode responseCode)
		{
			ResponseCode = responseCode;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected UpdateLobbyStatusResponsePayload()
		{

		}
	}
}

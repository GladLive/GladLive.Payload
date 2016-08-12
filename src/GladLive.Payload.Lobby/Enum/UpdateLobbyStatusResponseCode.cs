using System;
using System.Collections.Generic;
using System.Linq;
using GladLive.Payload.Common;

namespace GladLive.Payload.Lobby
{
	/// <summary>
	/// Indicates the status of the <see cref="GladLivePayloadMessageType.UpdateLobbyStatusResponse"/>.
	/// </summary>
	public enum UpdateLobbyStatusResponseCode : byte
	{
		/// <summary>
		/// Represents an unknown <see cref="GladLivePayloadMessageType.UpdateLobbyStatusResponse"/> state.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Indicates the the remote service is not available to register a new lobby.
		/// </summary>
		ServiceUnavailable = 1,

		/// <summary>
		/// Indicates that the remote service has temporarily suspended registration priveleges for some reason.
		/// </summary>
		SuspendedRegistrationPriveleges = 2,

		/// <summary>
		/// Indicates that the <see cref="GladLivePayloadMessageType.UpdateLobbyStatusResponse"/> was successful.
		/// </summary>
		Success = 3,
	}
}

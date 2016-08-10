using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Common
{
	/// <summary>
	/// Indicates the status of the <see cref="GladLivePayloadMessageType.HelloResponse"/>.
	/// </summary>
	public enum HelloResponseCode : int
	{
		/// <summary>
		/// Represents an unknown <see cref="GladLivePayloadMessageType.HelloResponse"/> state.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Indicates the the remote service is not available for hello.
		/// </summary>
		ServiceUnavailable = 1,

		/// <summary>
		/// Indicates that the remote service does not handle Hellos from users they've never seen.
		/// Even if that user is authenticated with GladLive.
		/// </summary>
		ServiceDoesntServiceNewcomingHello = 2,

		/// <summary>
		/// Indicates that the <see cref="GladLivePayloadMessageType.HelloRequest"/> was successful.
		/// </summary>
		HelloSuccess = 3,
	}
}

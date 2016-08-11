using GladLive.Payload.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile.Enums.Payload
{
	/// <summary>
	/// Indicates the status of the <see cref="GladLivePayloadMessageType.GetMinimumProfilesResponse"/>.
	/// </summary>
	public enum MinimumProfilesResponseCode : int
	{
		/// <summary>
		/// Represents an unknown <see cref="GladLivePayloadMessageType.GetMinimumProfilesResponse"/> state.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Indicates the the remote service is not available for hello.
		/// </summary>
		ServiceUnavailable = 1,

		/// <summary>
		/// Indicates that the service limits the amount of concurrent profile requests and the request
		/// exceeded this value.
		/// </summary>
		TooManyProfileRequests = 2,

		/// <summary>
		/// Indicates that the service returned atleast one of the profile requests but could not service them all.
		/// </summary>
		PartialSuccess = 3,
		
		/// <summary>
		/// Indicates that the service returned profiles for all requested profiles.
		/// </summary>
		Success = 4,
	}
}

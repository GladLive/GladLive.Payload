using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile
{
	/// <summary>
	/// Contract for minimum profile data.
	/// </summary>
	public interface IMinimumProfileDataModel
	{
		/// <summary>
		/// Color of the <see cref="GladLive"/> profile.
		/// </summary>
		ProfileColorModel Color { get; }

		/// <summary>
		/// Tag object of the <see cref="GladLive"/> profile.
		/// </summary>
		ProfileTagModel ProfileTag { get; }

		/// <summary>
		/// Name of the profile.
		/// </summary>
		string ProfileName { get; }
	}
}

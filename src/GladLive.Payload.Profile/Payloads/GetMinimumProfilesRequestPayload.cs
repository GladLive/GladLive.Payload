using GladLive.Payload.Common;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile
{
	/// <summary>
	/// Represents a request for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
	/// the least extensive and quichest to service profile data for the user.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.GetMinimumProfilesRequest)]
	public class GetMinimumProfilesRequestPayload : PacketPayload
	{
		/// <summary>
		/// Serialized profile names to query about.
		/// This is a List for protobufnet serialization support.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		private readonly IList<string> internalProfileNamesList; //probably username or something.

		/// <summary>
		/// Represents the unique name of the profiles the user is interested.
		/// </summary>
		public IEnumerable<string> ProfileNames { get { return internalProfileNamesList; } }

		/// <summary>
		/// Creates a new <see cref="GetMinimumProfilesRequestPayload"/> that requests information about multiple
		/// profiles.
		/// </summary>
		/// <param name="profilesDesired">Profiles to request.</param>
		public GetMinimumProfilesRequestPayload(IList<string> profilesDesired)
		{
			if (profilesDesired == null || profilesDesired.Count == 0)
				throw new ArgumentException($"Provided profiles must not be null or empty.", nameof(profilesDesired));

			internalProfileNamesList = profilesDesired;
		}

		/// <summary>
		/// Creates a new <see cref="GetMinimumProfilesRequestPayload"/> that requests information about a single profile.
		/// </summary>
		/// <param name="profileName"></param>
		public GetMinimumProfilesRequestPayload(string profileName)
			: this(new List<string>(1) { profileName })
		{

		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected GetMinimumProfilesRequestPayload()
		{

		}
	}
}

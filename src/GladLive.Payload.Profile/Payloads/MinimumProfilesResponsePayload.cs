using GladLive.Payload.Common;
using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile
{
	/// <summary>
	/// Represents a response for <see cref="GetMinimumProfilesRequest"/> for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
	/// the least extensive and quichest to service profile data for the user.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.GetMinimumProfilesResponse)]
	public class MinimumProfilesResponsePayload : PacketPayload, IResponseStatus<MinimumProfilesResponseCode>
	{
		/// <summary>
		/// Response status; the response code of the request.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public MinimumProfilesResponseCode ResponseCode { get; private set; }

		/// <summary>
		/// Internally serialized profile data models.
		/// IList for protobufnet support.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		private readonly IList<MinimumProfileDataModel> internalProfileDataModels;

#if !NET35 //net35 doesn't support the covariance
		public IEnumerable<IMinimumProfileDataModel> ProfileDataModels { get { return internalProfileDataModels; } }
#else
		public IEnumerable<MinimumProfileDataModel> ProfileDataModels { get { return internalProfileDataModels; } }
#endif

		/// <summary>
		/// Creates a <see cref="MinimumProfilesResponsePayload"/> with only a <see cref="MinimumProfilesResponseCode"/>.
		/// </summary>
		/// <param name="responseCode">Response code.</param>
		public MinimumProfilesResponsePayload(MinimumProfilesResponseCode responseCode)
		{
			ResponseCode = responseCode;
		}

		/// <summary>
		/// Creates a <see cref="MinimumProfilesResponsePayload"/> with a <see cref="MinimumProfilesResponseCode"/>
		/// and collection of profiles.
		/// </summary>
		/// <param name="responseCode">Response code.</param>
		public MinimumProfilesResponsePayload(MinimumProfilesResponseCode responseCode, List<MinimumProfileDataModel> profiles)
		{
			//Don't check profiles. We expect null or emprt sometimes. We can't force calling code to call other ctor.
			//We don't want to throw on the server either because it opens us up to service disruption.

			ResponseCode = responseCode;
			internalProfileDataModels = profiles;
		}

		/// <summary>
		/// Creates a <see cref="MinimumProfilesResponsePayload"/> with a <see cref="MinimumProfilesResponseCode"/> and
		/// a single profile response.
		/// </summary>
		/// <param name="responseCode">Response code.</param>
		public MinimumProfilesResponsePayload(MinimumProfilesResponseCode responseCode, MinimumProfileDataModel profile)
			: this(responseCode, new List<MinimumProfileDataModel>(1) { profile })
		{

		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected MinimumProfilesResponsePayload()
		{

		}
	}
}

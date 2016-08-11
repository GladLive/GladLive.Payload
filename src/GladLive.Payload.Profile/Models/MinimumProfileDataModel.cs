using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile
{
	/// <summary>
	/// Contract for minimum profile data.
	/// </summary>
	[GladNetSerializationContract]
	public class MinimumProfileDataModel : IMinimumProfileDataModel
	{
		/// <summary>
		/// Color of the <see cref="GladLive"/> profile.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public ProfileColorModel Color { get; private set; }

		/// <summary>
		/// Tag object of the <see cref="GladLive"/> profile.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		public ProfileTagModel ProfileTag { get; private set; }

		/// <summary>
		/// Name of the profile.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		public string ProfileName { get; private set; }

		public MinimumProfileDataModel(ProfileColorModel color, ProfileTagModel profileTag, string profileName)
		{
			if (color == null)
				throw new ArgumentNullException($"Provided model was null.", nameof(color));

			if (profileTag == null)
				throw new ArgumentNullException($"Provided model was null.", nameof(profileTag));

			if (String.IsNullOrEmpty(profileName))
				throw new ArgumentNullException($"Provided model was null or empty.", nameof(profileName));


			Color = color;
			ProfileTag = profileTag;
			ProfileName = profileName;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected MinimumProfileDataModel()
		{

		}
	}
}

using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GladLive.Payload.Profile
{
	/// <summary>
	/// <see cref="GladLive"/> profile tag.
	/// </summary>
	[GladNetSerializationContract]
	public class ProfileTagModel
	{
		//For now we just provide a string tag.
		//Future implementation could contain Clan/Guild/Party information or something
		
		/// <summary>
		/// Profile tag. This could be a tagline message or a combination of characters in an FPS for
		/// identification like AK7. Depends on implementation.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public string Tag { get; private set; }

		/// <summary>
		/// Creates a new <see cref="ProfileTagModel"/> with the provided
		/// tag value.
		/// </summary>
		/// <param name="tagValue">Value of the tag.</param>
		public ProfileTagModel(string tagValue)
		{
			Tag = tagValue;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected ProfileTagModel()
		{

		}

	}
}

using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Common
{
	/// <summary>
	/// The <see cref="GladNetIncludeIndex"/> for GladLive that provides well-named enum values
	/// for corresponding message types.
	/// </summary>
	public enum GladLivePayloadMessageType : int
	{
		//You may wonder where authentication is. It's not here, it's part of GladNet

		/// <summary>
		/// The initial Hello to the server application. This provides a chance for the server application to handle/prepare
		/// for the first request a user may make on the server. Since GladLive is slightly decentralized a user may connect to a
		/// server that has never seen it before. The server may have to run queries to prepare for the user's actual interactions with the service.
		/// </summary>
		HelloRequest = GladNetIncludeIndex.Index1,

		/// <summary>
		/// This response is paired with the <see cref="HelloRequest"/> and indicates the result of the Hello. Some servers in the distributed network
		/// may not support Hellos from users it has never seen before. This may be because setup for a user may be too lengthy to do at runtime on the server it's communicating with.
		/// Complex queuries to generate the 
		/// </summary>
		HelloResponse = GladNetIncludeIndex.Index2,

		/// <summary>
		/// Represents a request for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
		/// the least extensive and quichest to service profile data for the user.
		/// </summary>
		GetMinimumProfileRequest = GladNetIncludeIndex.Index3,

		/// <summary>
		/// Represents a response for <see cref="GetMinimumProfileRequest"/> for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
		/// the least extensive and quichest to service profile data for the user.
		/// </summary>
		GetMinimumProfileResponse = GladNetIncludeIndex.Index4,

		/// <summary>
		/// Represents a level 2 request for profile details. This request represents the concept of closer player inspection of a particular profile. This could contain
		/// information that wouldn't otherwise be immediately important to the enduser in a typical setting.
		/// </summary>
		GetProfileDetailsRequest = GladNetIncludeIndex.Index5,

		/// <summary>
		/// Represents a the response for <see cref="GetProfileDetailsRequest"/> for profile details. This request represents the concept of closer player inspection of a particular profile. This could contain
		/// information that wouldn't otherwise be immediately important to the enduser in a typical setting.
		/// </summary>
		GetProfileDetailsResponse = GladNetIncludeIndex.Index6
	}
}

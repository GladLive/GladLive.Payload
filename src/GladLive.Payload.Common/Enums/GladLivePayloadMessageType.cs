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

		#region PROFILE MESSAGES
		/// <summary>
		/// Represents a request for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
		/// the least extensive and quichest to service profile data for the user.
		/// </summary>
		GetMinimumProfilesRequest = GladNetIncludeIndex.Index3,

		/// <summary>
		/// Represents a response for <see cref="GetMinimumProfilesRequest"/> for the minimum profile. This may be just the level or maybe rank or a player. It represents the concept of
		/// the least extensive and quichest to service profile data for the user.
		/// </summary>
		GetMinimumProfilesResponse = GladNetIncludeIndex.Index4,

		/// <summary>
		/// Represents a level 2 request for profile details. This request represents the concept of closer player inspection of a particular profile. This could contain
		/// information that wouldn't otherwise be immediately important to the enduser in a typical setting.
		/// </summary>
		GetProfileDetailsRequest = GladNetIncludeIndex.Index5,

		/// <summary>
		/// Represents a the response for <see cref="GetProfileDetailsRequest"/> for profile details. This request represents the concept of closer player inspection of a particular profile. This could contain
		/// information that wouldn't otherwise be immediately important to the enduser in a typical setting.
		/// </summary>
		GetProfileDetailsResponse = GladNetIncludeIndex.Index6,

		/// <summary>
		/// Represents a request for private details related to the user. This is conceptually data that is unavailable to the average user
		/// such as personal information that only authenticated users or users of higher level priveleges can query for.
		/// </summary>
		GetPrivateUserProfileDetailsRequest = GladNetIncludeIndex.Index7,

		/// <summary>
		/// Represents a response for private details related to the user. This is conceptually data that is unavailable to the average user
		/// such as personal information that only authenticated users or users of higher level priveleges can query for.
		/// </summary>
		GetPrivateUserProfileDetailsResponse = GladNetIncludeIndex.Index8,

		#endregion

		#region LOBBY MESSAGES
		/// <summary>
		/// Represents a request to register the current user's lobby in the lobby system.
		/// </summary>
		RegisterNewLobbyRequest = GladNetIncludeIndex.Index9,

		/// <summary>
		/// Represents a response that provides the details about the result of the attempted <see cref="RegisterNewLobbyRequest"/>.
		/// </summary>
		RegisterNewLobbyResponse = GladNetIncludeIndex.Index10,

		/// <summary>
		/// Represents a request to update the current lobby settings. This could include a change in gametype, privacy permissions or
		/// a change in maximum allowed player count.
		/// </summary>
		UpdateLobbyStatusRequest = GladNetIncludeIndex.Index11,

		/// <summary>
		/// Represents a response that provides the details about the result of the attempted <see cref="UpdateLobbyStatusRequest"/>.
		/// </summary>
		UpdateLobbyStatusResponse = GladNetIncludeIndex.Index12,
		#endregion
	}
}

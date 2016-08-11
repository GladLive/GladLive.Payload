using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Common
{
	/// <summary>
	/// The initial Hello to the server application. This provides a chance for the server application to handle/prepare
	/// for the first request a user may make on the server. Since GladLive is slightly decentralized a user may connect to a
	/// server that has never seen it before. The server may have to run queries to prepare for the user's actual interactions with the service.
	/// </summary>
	[GladNetSerializationContract]
	[AuthorizationRequired] //HelloRequests must be authorized as the end-user must be authenticated.
	[GladLivePayload(GladLivePayloadMessageType.HelloRequest)]
	public class HelloRequestPayload : PacketPayload
	{
		//Current Hello/Authorization/Authentication implementations don't require any actual data in the payload
		//JWT: Sent in Header and reabable on ASP servers.

		/// <summary>
		/// Constructs a new <see cref="HelloRequestPayload"/> instance.
		/// </summary>
		public HelloRequestPayload()
		{

		}
	}
}

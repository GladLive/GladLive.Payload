using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Common
{
	/// <summary>
	/// This response is paired with the <see cref="HelloRequest"/> and indicates the result of the Hello. Some servers in the distributed network
	/// may not support Hellos from users it has never seen before. This may be because setup for a user may be too lengthy to do at runtime on the server it's communicating with.
	/// Complex queuries to generate the user.
	/// </summary>
	[GladNetSerializationContract]
	[GladLivePayload(GladLivePayloadMessageType.HelloResponse)]
	public class HelloResponsePayload : PacketPayload, IResponseStatus<HelloResponseCode>
	{
		/// <summary>
		/// Indicates the status of the <see cref="HelloResponsePayload"/>.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public HelloResponseCode ResponseCode { get; private set; }

		/// <summary>
		/// Creates a new <see cref="HelloResponsePayload"/> with the provided <see cref="HelloResponseCode"/>.
		/// </summary>
		/// <param name="responseCode"><see cref="HelloResponseCode"/> result of response.</param>
		public HelloResponsePayload(HelloResponseCode responseCode)
		{
			ResponseCode = responseCode;
		}

		/// <summary>
		/// Protected serialization ctor.
		/// </summary>
		protected HelloResponsePayload()
		{

		}
	}
}

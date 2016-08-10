using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive
{
	/// <summary>
	/// Extensions for payload registration.
	/// </summary>
	public static class PayloadRegistrationExtensions
	{
		/// <summary>
		/// Register all the <see cref="PacketPayload"/>s in the <see cref="GladLive.Payload.Common"/> assembly.
		/// </summary>
		/// <typeparam name="TSerializerRegistryType"></typeparam>
		/// <param name="registry">Serialization registry to register the payloads with.</param>
		/// <returns>The registry to fluently chain off.</returns>
		public static TSerializerRegistryType RegisterCommonGladLivePayload<TSerializerRegistryType>(this TSerializerRegistryType registry)
			where TSerializerRegistryType : ISerializerRegistry
		{
			//Create a collection of the Common Payloads
			IEnumerable<Type> payloadTypes = typeof(PayloadRegistrationExtensions).Assembly
				.GetTypes()
				.Where(t => typeof(PacketPayload).IsAssignableFrom(t)); //Finds all the payloads that can be assigned to PacketPayload

			if (payloadTypes == null || payloadTypes.Count() == 0)
				return registry;

			foreach (Type pType in payloadTypes)
			{
				registry.Register(pType);
			}

			return registry;
		}
	}
}

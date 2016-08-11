﻿using GladNet.Payload;
using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GladLive.Payload.Common.Tests
{
	public class GeneralPayloadTests
	{
		private readonly ITestOutputHelper logger;

		public GeneralPayloadTests(ITestOutputHelper output)
		{
			this.logger = output;
		}

		[Fact]
		public void Test_All_Payloads_Marked_With_GladLiveAttribute()
		{
			List<Type> failedTypes = new List<Type>();

			foreach (Type t in GetPacketPayloadTypes())
			{
				if (t.GetCustomAttribute<GladLivePayloadAttribute>() == null)
				{
					failedTypes.Add(t);
					logger.WriteLine($"***ERROR***: {t?.FullName} doesn't implement the {nameof(GladLivePayloadAttribute)}");
				}
			}

			if (failedTypes.Count > 0)
				throw new Exception("Invalid Payload declarations.");
		}

		[Fact]
		public void Test_All_Payloads_Marked_With_Contract()
		{
			List<Type> failedTypes = new List<Type>();

			foreach (Type t in GetPacketPayloadTypes())
			{
				if (t.GetCustomAttribute<GladNetSerializationContractAttribute>() == null)
				{
					failedTypes.Add(t);
					logger.WriteLine($"***ERROR***: {t?.FullName} doesn't implement the {nameof(GladNetSerializationContractAttribute)}");
				}
			}

			if (failedTypes.Count > 0)
				throw new Exception("Invalid Payload declarations.");
		}

		[Fact]
		public void Test_All_Payloads_Marked_With_GladLiveAttribute_Have_Unique_Includes()
		{
			List<Type> failedTypes = new List<Type>();

			IEnumerable<Tuple<Type, GladLivePayloadAttribute>> tuples = GetPacketPayloadTypes()
				.Select(x => new Tuple<Type, GladLivePayloadAttribute>(x, x.GetCustomAttribute<GladLivePayloadAttribute>()))
				.Where(x => x != null);

			foreach (var tup in tuples)
			{
				foreach(var tup2 in tuples)
				{
					if (tup2.Item1 == tup.Item1)
						continue;
					else
						if(tup2.Item2 == tup.Item2)
						{
							failedTypes.Add(tup.Item1);
							logger.WriteLine($"***ERROR***: {tup.Item1?.FullName} and {tup2.Item1?.FullName} have the same {nameof(GladLivePayloadMessageType)}");
						}
				}
			}
			

			if (failedTypes.Count > 0)
				throw new Exception("Invalid Payload declarations.");
		}

		private IEnumerable<Type> GetPacketPayloadTypes()
		{
			return typeof(PayloadRegistrationExtensions).Assembly.GetTypes().Where(t => typeof(PacketPayload).IsAssignableFrom(t));
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace GladLive.Payload.Common.Tests
{
	public class GladLivePayloadMessageTypeTests
	{
		private readonly ITestOutputHelper logger;

		public GladLivePayloadMessageTypeTests(ITestOutputHelper output)
		{
			this.logger = output;
		}

		[Fact]
		public void Test_MessageType_Enum_Doesnt_Contain_Duplicate_Values()
		{
			//arrange
			IEnumerable<GladLivePayloadMessageType> messageTypes = Enum.GetValues(typeof(GladLivePayloadMessageType)) as GladLivePayloadMessageType[];

			//act
			bool result = messageTypes.Count() == messageTypes.Distinct().Count();

			if(result == false)
				logger.WriteLine($"***ERROR***: Found duplicate values in {nameof(GladLivePayloadMessageType)}.");

			//Find the duplicate values
			IEnumerable<GladLivePayloadMessageType> duplicates = messageTypes
				.Where(v => messageTypes.Where(test => ((int)test) == ((int)v)).Count() > 1); //select the values that have more than 1

			//Won't fully report the Types because it can't determine which was which.
			//Goog enough though
			foreach(GladLivePayloadMessageType message in duplicates)
				logger.WriteLine($"***ERROR***: Found duplicate value: {message.ToString()}.");


			Assert.True(result);
		}
	}
}

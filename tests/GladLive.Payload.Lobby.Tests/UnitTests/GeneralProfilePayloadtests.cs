using GladLive.Payload.Common.Tests;
using GladLive.Payload.Lobby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace GladLive.Payload.Profile.Tests
{
	public class GeneralProfilePayloadtests : GeneralPayloadTests
	{
		public GeneralProfilePayloadtests(ITestOutputHelper output) 
			: base(output)
		{

		}

		protected override Type TypeToUseToFindAssembly
		{
			get
			{
				//Return type that allows access to the lobby assembly
				return typeof(UpdateLobbyStatusResponseCode);
			}
		}
	}
}

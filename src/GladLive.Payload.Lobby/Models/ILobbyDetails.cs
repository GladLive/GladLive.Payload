using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Lobby
{
	/// <summary>
	/// Meta-data marker for a lobby details type.
	/// </summary>
	public interface ILobbyDetails//tries to contrain to enum
	{
		/// <summary>
		/// Represents the name of the lobby.
		/// </summary>
		string LobbyName { get; }

		/// <summary>
		/// Indicates the maximum capacity of the lobby.
		/// </summary>
		int MaximumCapacity { get; }

		/// <summary>
		/// Indicates the current used capacity of the lobby.
		/// </summary>
		int UsedCapacity { get; }

		//This marks a type as a type that contains details about the lobby
		//This information could be the GameType or MapType maximum or current capacity
	}
}

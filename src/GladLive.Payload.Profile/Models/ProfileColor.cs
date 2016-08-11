using GladNet.Serializer;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GladLive.Payload.Profile
{
	/// <summary>
	/// Represents the color of the profile.
	/// </summary>
	[GladNetSerializationContract]
	public class ProfileColorModel
	{
		/// <summary>
		/// The red value of the color object.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index1)]
		public byte RedValue { get; }

		/// <summary>
		/// The green value of the color object.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index2)]
		public byte GreenValue { get; }

		/// <summary>
		/// The blue value of the color object.
		/// </summary>
		[GladNetMember(GladNetDataIndex.Index3)]
		public byte BlueValue { get; }

		/// <summary>
		/// Creates a new immmutable color structure.
		/// </summary>
		/// <param name="red">Red value.</param>
		/// <param name="green">Green value.</param>
		/// <param name="blue">Blue value.</param>
		public ProfileColorModel(byte red, byte green, byte blue)
		{
			RedValue = red;
			GreenValue = green;
			BlueValue = blue;
		}

		/// <summary>
		/// Protected serializer ctor.
		/// </summary>
		protected ProfileColorModel()
		{

		}
	}
}

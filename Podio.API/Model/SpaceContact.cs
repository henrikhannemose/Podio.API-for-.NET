using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class SpaceContact 
	{


		[DataMember(Name = "space_id", IsRequired=false)]
		public int SpaceId { get; set; }


		[DataMember(Name = "organization", IsRequired=false)]
		public string Organization { get; set; }


		[DataMember(Name = "avatar", IsRequired=false)]
		public int Avatar { get; set; }


	}
}

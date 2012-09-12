using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class LinkedAccountData 
	{


		[DataMember(Name = "id", IsRequired=false)]
		public int Id { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "info", IsRequired=false)]
		public string Info { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


	}
}

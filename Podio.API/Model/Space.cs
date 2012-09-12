using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class Space 
	{


		[DataMember(Name = "space_id", IsRequired=false)]
		public int SpaceId { get; set; }


		[DataMember(Name = "name", IsRequired=false)]
		public string Name { get; set; }


		[DataMember(Name = "url", IsRequired=false)]
		public string Url { get; set; }


		[DataMember(Name = "url_label", IsRequired=false)]
		public string UrlLabel { get; set; }


		[DataMember(Name = "org_id", IsRequired=false)]
		public int OrgId { get; set; }


		[DataMember(Name = "contact_count", IsRequired=false)]
		public int ContactCount { get; set; }


		[DataMember(Name = "members", IsRequired=false)]
		public int Members { get; set; }


		[DataMember(Name = "role", IsRequired=false)]
		public string Role { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


		[DataMember(Name = "post_on_new_app", IsRequired=false)]
		public bool PostOnNewApp { get; set; }


		[DataMember(Name = "post_on_new_member", IsRequired=false)]
		public bool PostOnNewMember { get; set; }


		[DataMember(Name = "subscribed", IsRequired=false)]
		public bool Subscribed { get; set; }


		[DataMember(Name = "privacy", IsRequired=false)]
		public string Privacy { get; set; }


		[DataMember(Name = "auto_join", IsRequired=false)]
		public bool AutoJoin { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "premium", IsRequired=false)]
		public bool Premium { get; set; }


		[DataMember(Name = "last_activity_on", IsRequired=false)]
		public DateTime LastActivityOn { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


	}
}

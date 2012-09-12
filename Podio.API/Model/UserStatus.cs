using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class UserStatus 
	{


        //[DataMember(Name = "user", IsRequired=false)]
        //public Dictionary<string,string> User { get; set; }


		[DataMember(Name = "profile", IsRequired=false)]
		public Dictionary<string,string> Profile { get; set; }


		[DataMember(Name = "properties", IsRequired=false)]
		public Dictionary<string,string> Properties { get; set; }


		[DataMember(Name = "inbox_new", IsRequired=false)]
		public int InboxNew { get; set; }


		[DataMember(Name = "calendar_code", IsRequired=false)]
		public string CalendarCode { get; set; }


		[DataMember(Name = "task_mail", IsRequired=false)]
		public string TaskMail { get; set; }


		[DataMember(Name = "mailbox", IsRequired=false)]
		public string Mailbox { get; set; }


		[DataMember(Name = "user", IsRequired=false)]
		public User User { get; set; }


		[DataMember(Name = "contact", IsRequired=false)]
		public Contact Contact { get; set; }


		[DataMember(Name = "referral", IsRequired=false)]
		public Referral Referral { get; set; }


	}
}

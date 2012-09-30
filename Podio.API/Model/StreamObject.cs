using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class StreamObject 
	{


		[DataMember(Name = "id", IsRequired=false)]
		public int? Id { get; set; }


		[DataMember(Name = "type", IsRequired=false)]
		public string Type { get; set; }


		[DataMember(Name = "last_update_on", IsRequired=false)]
		public DateTime LastUpdateOn { get; set; }


		[DataMember(Name = "title", IsRequired=false)]
		public string Title { get; set; }


		[DataMember(Name = "link", IsRequired=false)]
		public string Link { get; set; }


		[DataMember(Name = "rights", IsRequired=false)]
		public string[] Rights { get; set; }


		[DataMember(Name = "data", IsRequired=false)]
		public Dictionary<string,object> Data { get; set; }


		[DataMember(Name = "comments_allowed", IsRequired=false)]
		public bool? CommentsAllowed { get; set; }


		[DataMember(Name = "user_ratings", IsRequired=false)]
		public Dictionary<string,object> UserRatings { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


		[DataMember(Name = "app", IsRequired=false)]
		public Application App { get; set; }


		[DataMember(Name = "space", IsRequired=false)]
		public Space Space { get; set; }


		[DataMember(Name = "org", IsRequired=false)]
		public Organization Org { get; set; }


		[DataMember(Name = "comments", IsRequired=false)]
		public List<Comment> Comments { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


		[DataMember(Name = "activity", IsRequired=false)]
		public List<Activity> Activity { get; set; }


	}
}


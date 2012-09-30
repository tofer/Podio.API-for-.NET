using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


/// AUTOGENERATED FROM RUBYSOURCE
namespace Podio.API.Model
{
	[DataContract]
	public partial class ConversationMessage 
	{


		[DataMember(Name = "message_id", IsRequired=false)]
		public int? MessageId { get; set; }


		[DataMember(Name = "embed_id", IsRequired=false)]
		public int? EmbedId { get; set; }


		[DataMember(Name = "embed_file_id", IsRequired=false)]
		public int? EmbedFileId { get; set; }


		[DataMember(Name = "text", IsRequired=false)]
		public string Text { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public DateTime CreatedOn { get; set; }


		[DataMember(Name = "embed", IsRequired=false)]
		public Embed Embed { get; set; }


		[DataMember(Name = "embed_file", IsRequired=false)]
		public FileAttachment EmbedFile { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "files", IsRequired=false)]
		public List<FileAttachment> Files { get; set; }


	}
}


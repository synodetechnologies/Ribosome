namespace PartyOrganiser.API.Objects
{
	using ProtoBuf;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Simple HATEOAS version of the API Object Peoples, contains only non navigation property, and a list of <see cref="ApiHATEOASLink"/>.
	/// </summary>
	[NSwag.Annotations.SwaggerTag("PeoplesV1SimpleHATEOAS", Description ="", DocumentationDescription ="")]
	[ProtoContract]
	public partial class PeoplesV1SimpleHATEOAS : PeoplesV1Simple
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public PeoplesV1SimpleHATEOAS() : base()
		{
			 InitList();
		}

		/// <summary>
		/// Init virtual List(s)
		/// </summary>
		protected virtual void InitList()
		{
			this.Links = new List<ApiHATEOASLink>();
		}

		[ProtoMember(1)]
		[System.Runtime.Serialization.DataMember(Name = "links")]
		public virtual List<ApiHATEOASLink> Links { get; set; }
	}
}

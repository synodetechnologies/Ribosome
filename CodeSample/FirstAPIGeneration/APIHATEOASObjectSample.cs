namespace PartyOrganiser.API.Objects
{
	using ProtoBuf;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// API Object HATEOAS version of Peoples with <see cref="ApiHATEOASLink"/> links.
	/// </summary>
	[NSwag.Annotations.SwaggerTag("PeoplesV1HATEOAS", Description ="", DocumentationDescription ="")]
	[ProtoContract]
	public partial class PeoplesV1HATEOAS : PeoplesV1SimpleHATEOAS
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public PeoplesV1HATEOAS() : base()
		{
		}

		/// <summary>
		/// Init fields with default value and complex type
		/// </summary>
		protected override void InitFields()
		{
		}

		/// <summary>
		/// Init virtual List(s)
		/// </summary>
		protected override void InitList()
		{
			base.InitList();
			this.Parties = new List<PartiesV1SimpleHATEOAS>();
		}
		[ProtoMember(1)]
		[System.Runtime.Serialization.DataMember(Name ="car")]
		public  virtual CarsV1HATEOAS Car {  get;  set; }
		[ProtoMember(2)]
		[System.Runtime.Serialization.DataMember(Name ="parties")]
		public  virtual List<PartiesV1SimpleHATEOAS> Parties {  get;  set; }
	}
}

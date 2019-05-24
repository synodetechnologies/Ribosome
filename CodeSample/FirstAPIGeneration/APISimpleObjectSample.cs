namespace PartyOrganiser.API.Objects
{
	using ProtoBuf;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// Simple version of the API Object Peoples, contains only non navigation property.
	/// </summary>
	[NSwag.Annotations.SwaggerTag("PeoplesV1Simple", Description ="", DocumentationDescription ="")]
	[ProtoContract]
	[ProtoInclude(100, typeof(PeoplesV1))]
	[ProtoInclude(200, typeof(PeoplesV1SimpleHATEOAS))]
	[ProtoInclude(300, typeof(PeoplesV1HATEOAS))]
	public partial class PeoplesV1Simple : IValidatableObject
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public PeoplesV1Simple()
		{
			InitFields();
		}

		/// <summary>
		/// Init fields with default value and complex type
		/// </summary>
		protected virtual void InitFields()
		{
		}
		[ProtoMember(1)]
		[System.Runtime.Serialization.DataMember(Name ="id")]
		public int Id {  get;  set; }
		[ProtoMember(2)]
		[System.Runtime.Serialization.DataMember(Name ="firstName")]
		public string FirstName {  get;  set; }
		[ProtoMember(3)]
		[System.Runtime.Serialization.DataMember(Name ="lastName")]
		public string LastName {  get;  set; }
		[ProtoMember(4)]
		[System.Runtime.Serialization.DataMember(Name ="age")]
		public short Age {  get;  set; }
		[ProtoMember(5)]
		[System.Runtime.Serialization.DataMember(Name ="phone")]
		public string Phone {  get;  set; }
		[ProtoMember(6)]
		[System.Runtime.Serialization.DataMember(Name ="email")]
		public string Email {  get;  set; }

		//Custom validation
		public virtual bool? IsCreationMode(ValidationContext validationContext)
		{
            
			return this.Id == default(int);
		}

		public virtual IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();

			ret.AddRange(ValidateId(validationContext));
			ret.AddRange(ValidateFirstName(validationContext));
			ret.AddRange(ValidateLastName(validationContext));
			ret.AddRange(ValidateAge(validationContext));
			ret.AddRange(ValidatePhone(validationContext));
			ret.AddRange(ValidateEmail(validationContext));
			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidateId(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.id";
			ret.Add(new RequiredAttribute().GetValidationResult(this.Id, validationContext));

			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidateFirstName(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.firstName";
			ret.Add(new RequiredAttribute().GetValidationResult(this.FirstName, validationContext));

			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidateLastName(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.lastName";
			ret.Add(new RequiredAttribute().GetValidationResult(this.LastName, validationContext));

			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidateAge(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.age";
			ret.Add(new RequiredAttribute().GetValidationResult(this.Age, validationContext));

			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidatePhone(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.phone";
			ret.Add(new RequiredAttribute().GetValidationResult(this.Phone, validationContext));

			return ret;
		}
		public virtual IEnumerable<ValidationResult> ValidateEmail(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			validationContext.DisplayName = "PeoplesV1.email";
			ret.Add(new RequiredAttribute().GetValidationResult(this.Email, validationContext));

			return ret;
		}
	}
}

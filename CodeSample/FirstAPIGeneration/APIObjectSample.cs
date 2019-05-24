namespace PartyOrganiser.API.Objects
{
	using ProtoBuf;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	/// <summary>
	/// API Object of Peoples
	/// </summary>
	[NSwag.Annotations.SwaggerTag("PeoplesV1", Description ="", DocumentationDescription ="")]
	[ProtoContract]
	public partial class PeoplesV1 : PeoplesV1Simple
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public PeoplesV1() : base()
		{
			InitList();
		}

		/// <summary>
		/// Init fields with default value and complex type
		/// </summary>
		protected override void InitFields()
		{
			base.InitFields();
		}

		/// <summary>
		/// Init virtual List(s)
		/// </summary>
		protected virtual void InitList()
		{
			this.Parties = new List<PartiesInvolved>();
		}
		[ProtoMember(1)]
		[System.Runtime.Serialization.DataMember(Name ="car")]
		public  virtual CarsV1 Car {  get;  set; }
		[ProtoMember(2)]
		[System.Runtime.Serialization.DataMember(Name ="parties")]
		public  virtual List<PartiesInvolved> Parties {  get;  set; }

		//Customisation Validate
		public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			bool? isCreationMode = this.IsCreationMode(validationContext);
			if(!isCreationMode.HasValue)
			{
				return  new List<ValidationResult>();
			}
			else if(isCreationMode.Value)
			{
				return ValidateCreation(validationContext);
			}
			else
			{
				return ValidateUpdate(validationContext);
			}
		}
		
		public virtual IEnumerable<ValidationResult> ValidateCreation(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();

			ret.AddRange(base.Validate(validationContext));
			return ret;
		}
		
		public virtual IEnumerable<ValidationResult> ValidateUpdate(ValidationContext validationContext)
		{
			List<ValidationResult> ret = new List<ValidationResult>();
			List<string> invalidProps = new List<string>();
			if (this.FirstName != default(string))
			{
				invalidProps.Add(nameof(FirstName));
				ret.Add(new ValidationResult("if this object is used for linking an existing resource then assign only the primaryKeys, do not assign PeoplesV1.firstName.",invalidProps));
			}
			if (this.LastName != default(string))
			{
				invalidProps.Add(nameof(LastName));
				ret.Add(new ValidationResult("if this object is used for linking an existing resource then assign only the primaryKeys, do not assign PeoplesV1.lastName.",invalidProps));
			}
			if (this.Age != default(short))
			{
				invalidProps.Add(nameof(Age));
				ret.Add(new ValidationResult("if this object is used for linking an existing resource then assign only the primaryKeys, do not assign PeoplesV1.age.",invalidProps));
			}
			if (this.Phone != default(string))
			{
				invalidProps.Add(nameof(Phone));
				ret.Add(new ValidationResult("if this object is used for linking an existing resource then assign only the primaryKeys, do not assign PeoplesV1.phone.",invalidProps));
			}
			if (this.Email != default(string))
			{
				invalidProps.Add(nameof(Email));
				ret.Add(new ValidationResult("if this object is used for linking an existing resource then assign only the primaryKeys, do not assign PeoplesV1.email.",invalidProps));
			}
			return ret;
		}
	}
}

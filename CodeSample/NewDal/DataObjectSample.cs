using System;
using System.Collections.Generic;

namespace PartyOrganiser.DataObjects
{

	/// <summary>
	/// Data Object PartyOrganiser.DataObjects.People
	/// </summary>
	public partial class People 
	{
		// Attribute for Many#TO#Many relation
		public ICollection<PeoplesParties> PeoplesParties { get; set; }
		// Attribute for Many#TO#Many relation
		public ICollection<PassengersStop> PassengersStop { get; set; }

		/// <summary>
		/// Constructor
		/// </summary>
		public People()
		{
			this.Galleries = new HashSet<Gallery>();
			this.Votes = new HashSet<Vote>();
			this.ContributionPart = new HashSet<ContributionPart>();
			this.PeoplesParties = new HashSet<PeoplesParties>();
			this.PassengersStop = new HashSet<PassengersStop>();
		}

		public int Id {  get;  set; }

		public string FirstName {  get;  set; }

		public string LastName {  get;  set; }

		public short Age {  get;  set; }

		public string Phone {  get;  set; }

		public string Email {  get;  set; }

		public  virtual ICollection<Gallery> Galleries {  get;  set; }

		public  virtual Car Car {  get;  set; }

		public  virtual ICollection<Vote> Votes {  get;  set; }

		public  virtual ICollection<ContributionPart> ContributionPart {  get;  set; }
	}
}

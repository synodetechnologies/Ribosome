namespace PartyOrganiser.BusinessObjects
{
	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Business object for People
	/// </summary>
	public partial class People 
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public People()
		{
			InitFields();
		}

		/// <summary>
		/// Init Fields
		/// </summary>
		protected virtual void InitFields()
		{
			this.Parties = new HashSet<Party>();
			this.Galleries = new HashSet<Gallery>();
			this.Stop = new HashSet<Stop>();
			this.Votes = new HashSet<Vote>();
			this.ContributionPart = new HashSet<ContributionPart>();
		}

		public int Id {  get;  set; }

		public string FirstName {  get;  set; }

		public string LastName {  get;  set; }

		public short Age {  get;  set; }

		public string Phone {  get;  set; }

		public string Email {  get;  set; }
		public  virtual ICollection<Party> Parties {  get;  set; }
		public  virtual ICollection<Gallery> Galleries {  get;  set; }
		public  virtual Car Car {  get;  set; }
		public  virtual ICollection<Stop> Stop {  get;  set; }
		public  virtual ICollection<Vote> Votes {  get;  set; }
		public  virtual ICollection<ContributionPart> ContributionPart {  get;  set; }
	}
}

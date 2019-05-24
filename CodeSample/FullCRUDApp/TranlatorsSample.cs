namespace PartyOrganiser.API.Mappers
{
    using PartyOrganiser.API.Mappers.Bin;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Allow the translation between API Objects and Business Objects, based on the class by the given parameter by mappingClassName.
    /// This class is issued from the dll given by parameter mappingDll.
    /// All parameters come from the file ".syConf" of the translators command
    /// </summary>
    public static class MapperConfigurator
    {
        /// <summary>
        /// Register the translations between API Objects and Business Objects
        /// </summary>
        public static void Initialize()
        {
#region Accessory
            Mapper.Register<PartyOrganiser.BusinessObjects.Accessory,PartyOrganiser.API.Objects.AccessoriesV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Cost = a.Cost;
                b.Name = a.Name;
                b.Description = a.Description;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Cost = b.Cost;
                a.Name = b.Name;
                a.Description = b.Description;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Accessory,PartyOrganiser.API.Objects.AccessoriesV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Cost = a.Cost;
                b.Name = a.Name;
                b.Description = a.Description;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Cost = b.Cost;
                a.Name = b.Name;
                a.Description = b.Description;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Accessory,PartyOrganiser.API.Objects.AccessoriesV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Cost = a.Cost;
                b.Name = a.Name;
                b.Description = a.Description;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Cost = b.Cost;
                a.Name = b.Name;
                a.Description = b.Description;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Accessory,PartyOrganiser.API.Objects.AccessoriesV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Cost = a.Cost;
                b.Name = a.Name;
                b.Description = a.Description;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Cost = b.Cost;
                a.Name = b.Name;
                a.Description = b.Description;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Accessory,PartyOrganiser.API.Objects.ContributionAccessories>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region Car
            Mapper.Register<PartyOrganiser.BusinessObjects.Car,PartyOrganiser.API.Objects.CarsV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Description = a.Description;
                b.Plate = a.Plate;
                b.Model = a.Model;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Description = b.Description;
                a.Plate = b.Plate;
                a.Model = b.Model;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Car,PartyOrganiser.API.Objects.CarsV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Description = a.Description;
                b.Plate = a.Plate;
                b.Model = a.Model;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Description = b.Description;
                a.Plate = b.Plate;
                a.Model = b.Model;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Car,PartyOrganiser.API.Objects.CarsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Description = a.Description;
                b.Plate = a.Plate;
                b.Model = a.Model;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Description = b.Description;
                a.Plate = b.Plate;
                a.Model = b.Model;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Car,PartyOrganiser.API.Objects.CarsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Description = a.Description;
                b.Plate = a.Plate;
                b.Model = a.Model;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Description = b.Description;
                a.Plate = b.Plate;
                a.Model = b.Model;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Car,PartyOrganiser.API.Objects.TripsCars>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region Contribution
            Mapper.Register<PartyOrganiser.BusinessObjects.Contribution,PartyOrganiser.API.Objects.ContributionsV1>((a, b)=>
            {

                b.Accessories = Mapper.MapAll<PartyOrganiser.BusinessObjects.Accessory, PartyOrganiser.API.Objects.ContributionAccessories>(a.Accessories).ToList();
                b.Id = a.Id;
                b.Title = a.Title;
                b.Detail = a.Detail;
                b.ContributionParts = Mapper.MapAll<PartyOrganiser.BusinessObjects.ContributionPart, PartyOrganiser.API.Objects.ContributionPartsV1>(a.ContributionPart).ToList();
            }).Reverse((b,a)=>
            {
                a.Accessories = Mapper.MapAll<PartyOrganiser.API.Objects.ContributionAccessories, PartyOrganiser.BusinessObjects.Accessory>(b.Accessories).ToList();
                a.Id = b.Id;
                a.Title = b.Title;
                a.Detail = b.Detail;
                a.ContributionPart = Mapper.MapAll<PartyOrganiser.API.Objects.ContributionPartsV1, PartyOrganiser.BusinessObjects.ContributionPart>(b.ContributionParts).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Contribution,PartyOrganiser.API.Objects.ContributionsV1HATEOAS>((a, b)=>
            {

                b.Accessories = Mapper.MapAll<PartyOrganiser.BusinessObjects.Accessory, PartyOrganiser.API.Objects.AccessoriesV1SimpleHATEOAS>(a.Accessories).ToList();
                b.Id = a.Id;
                b.Title = a.Title;
                b.Detail = a.Detail;
                b.ContributionParts = Mapper.MapAll<PartyOrganiser.BusinessObjects.ContributionPart, PartyOrganiser.API.Objects.ContributionPartsV1HATEOAS>(a.ContributionPart).ToList();
            }).Reverse((b,a)=>
            {
                a.Accessories = Mapper.MapAll<PartyOrganiser.API.Objects.AccessoriesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Accessory>(b.Accessories).ToList();
                a.Id = b.Id;
                a.Title = b.Title;
                a.Detail = b.Detail;
                a.ContributionPart = Mapper.MapAll<PartyOrganiser.API.Objects.ContributionPartsV1HATEOAS, PartyOrganiser.BusinessObjects.ContributionPart>(b.ContributionParts).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Contribution,PartyOrganiser.API.Objects.ContributionsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Title = a.Title;
                b.Detail = a.Detail;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
                a.Detail = b.Detail;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Contribution,PartyOrganiser.API.Objects.ContributionsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Title = a.Title;
                b.Detail = a.Detail;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
                a.Detail = b.Detail;
            });
#endregion
#region ContributionPart
            Mapper.Register<PartyOrganiser.BusinessObjects.ContributionPart,PartyOrganiser.API.Objects.ContributionPartsV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Amount = a.Amount;
                b.Contributor = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesParty>(a.People);
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Amount = b.Amount;
                a.People = Mapper.Map<PartyOrganiser.API.Objects.PeoplesParty, PartyOrganiser.BusinessObjects.People>(b.Contributor);
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.ContributionPart,PartyOrganiser.API.Objects.ContributionPartsV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Amount = a.Amount;
                b.Contributor = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>(a.People);
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Amount = b.Amount;
                a.People = Mapper.Map<PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.People>(b.Contributor);
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.ContributionPart,PartyOrganiser.API.Objects.ContributionPartsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Amount = a.Amount;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Amount = b.Amount;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.ContributionPart,PartyOrganiser.API.Objects.ContributionPartsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Amount = a.Amount;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Amount = b.Amount;
            });
#endregion
#region Election
            Mapper.Register<PartyOrganiser.BusinessObjects.Election,PartyOrganiser.API.Objects.ElectionsV1>((a, b)=>
            {

                b.Party = Mapper.Map<PartyOrganiser.BusinessObjects.Party, PartyOrganiser.API.Objects.ElectionParty>(a.Party);
                b.ProposedLocalisations = Mapper.MapAll<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.ProposedLocalisation>(a.ProposedLocalisations).ToList();
                b.Id = a.Id;
                b.Votes = Mapper.MapAll<PartyOrganiser.BusinessObjects.Vote, PartyOrganiser.API.Objects.VotesV1>(a.Vote).ToList();
            }).Reverse((b,a)=>
            {
                a.Party = Mapper.Map<PartyOrganiser.API.Objects.ElectionParty, PartyOrganiser.BusinessObjects.Party>(b.Party);
                a.ProposedLocalisations = Mapper.MapAll<PartyOrganiser.API.Objects.ProposedLocalisation, PartyOrganiser.BusinessObjects.Localisation>(b.ProposedLocalisations).ToList();
                a.Id = b.Id;
                a.Vote = Mapper.MapAll<PartyOrganiser.API.Objects.VotesV1, PartyOrganiser.BusinessObjects.Vote>(b.Votes).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Election,PartyOrganiser.API.Objects.ElectionsV1HATEOAS>((a, b)=>
            {

                b.Party = Mapper.Map<PartyOrganiser.BusinessObjects.Party, PartyOrganiser.API.Objects.PartiesV1SimpleHATEOAS>(a.Party);
                b.ProposedLocalisations = Mapper.MapAll<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS>(a.ProposedLocalisations).ToList();
                b.Id = a.Id;
                b.Votes = Mapper.MapAll<PartyOrganiser.BusinessObjects.Vote, PartyOrganiser.API.Objects.VotesV1HATEOAS>(a.Vote).ToList();
            }).Reverse((b,a)=>
            {
                a.Party = Mapper.Map<PartyOrganiser.API.Objects.PartiesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Party>(b.Party);
                a.ProposedLocalisations = Mapper.MapAll<PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Localisation>(b.ProposedLocalisations).ToList();
                a.Id = b.Id;
                a.Vote = Mapper.MapAll<PartyOrganiser.API.Objects.VotesV1HATEOAS, PartyOrganiser.BusinessObjects.Vote>(b.Votes).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Election,PartyOrganiser.API.Objects.ElectionsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Election,PartyOrganiser.API.Objects.ElectionsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region Gallery
            Mapper.Register<PartyOrganiser.BusinessObjects.Gallery,PartyOrganiser.API.Objects.GalleriesV1>((a, b)=>
            {

                b.Medias = Mapper.MapAll<PartyOrganiser.BusinessObjects.Media, PartyOrganiser.API.Objects.MediasV1>(a.Medias).ToList();
                b.Owner = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.Owner>(a.Owner);
                b.Id = a.Id;
                b.Name = a.Name;
            }).Reverse((b,a)=>
            {
                a.Medias = Mapper.MapAll<PartyOrganiser.API.Objects.MediasV1, PartyOrganiser.BusinessObjects.Media>(b.Medias).ToList();
                a.Owner = Mapper.Map<PartyOrganiser.API.Objects.Owner, PartyOrganiser.BusinessObjects.People>(b.Owner);
                a.Id = b.Id;
                a.Name = b.Name;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Gallery,PartyOrganiser.API.Objects.GalleriesV1HATEOAS>((a, b)=>
            {

                b.Medias = Mapper.MapAll<PartyOrganiser.BusinessObjects.Media, PartyOrganiser.API.Objects.MediasV1HATEOAS>(a.Medias).ToList();
                b.Owner = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>(a.Owner);
                b.Id = a.Id;
                b.Name = a.Name;
            }).Reverse((b,a)=>
            {
                a.Medias = Mapper.MapAll<PartyOrganiser.API.Objects.MediasV1HATEOAS, PartyOrganiser.BusinessObjects.Media>(b.Medias).ToList();
                a.Owner = Mapper.Map<PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.People>(b.Owner);
                a.Id = b.Id;
                a.Name = b.Name;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Gallery,PartyOrganiser.API.Objects.GalleriesV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Name = a.Name;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Name = b.Name;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Gallery,PartyOrganiser.API.Objects.GalleriesV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Name = a.Name;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Name = b.Name;
            });
#endregion
#region Localisation
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.LocalisationsV1>((a, b)=>
            {

                b.Id = a.Id;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.ZipCode = a.ZipCode;
                b.Street = a.Street;
                b.City = a.City;
                b.Country = a.Country;
                b.Name = a.Name;
                b.Comment = a.Comment;
                b.Cost = a.Cost;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.ZipCode = b.ZipCode;
                a.Street = b.Street;
                a.City = b.City;
                a.Country = b.Country;
                a.Name = b.Name;
                a.Comment = b.Comment;
                a.Cost = b.Cost;
                a.Capacity = b.Capacity;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.LocalisationsV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.ZipCode = a.ZipCode;
                b.Street = a.Street;
                b.City = a.City;
                b.Country = a.Country;
                b.Name = a.Name;
                b.Comment = a.Comment;
                b.Cost = a.Cost;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.ZipCode = b.ZipCode;
                a.Street = b.Street;
                a.City = b.City;
                a.Country = b.Country;
                a.Name = b.Name;
                a.Comment = b.Comment;
                a.Cost = b.Cost;
                a.Capacity = b.Capacity;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.LocalisationsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.ZipCode = a.ZipCode;
                b.Street = a.Street;
                b.City = a.City;
                b.Country = a.Country;
                b.Name = a.Name;
                b.Comment = a.Comment;
                b.Cost = a.Cost;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.ZipCode = b.ZipCode;
                a.Street = b.Street;
                a.City = b.City;
                a.Country = b.Country;
                a.Name = b.Name;
                a.Comment = b.Comment;
                a.Cost = b.Cost;
                a.Capacity = b.Capacity;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.ZipCode = a.ZipCode;
                b.Street = a.Street;
                b.City = a.City;
                b.Country = a.Country;
                b.Name = a.Name;
                b.Comment = a.Comment;
                b.Cost = a.Cost;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.ZipCode = b.ZipCode;
                a.Street = b.Street;
                a.City = b.City;
                a.Country = b.Country;
                a.Name = b.Name;
                a.Comment = b.Comment;
                a.Cost = b.Cost;
                a.Capacity = b.Capacity;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.ProposedLocalisation>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Localisation,PartyOrganiser.API.Objects.SelectedLocalisationParty>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region Party
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.PartiesV1>((a, b)=>
            {

                b.Galleries = Mapper.MapAll<PartyOrganiser.BusinessObjects.Gallery, PartyOrganiser.API.Objects.GalleriesV1>(a.Galleries).ToList();
                b.Contributions = Mapper.MapAll<PartyOrganiser.BusinessObjects.Contribution, PartyOrganiser.API.Objects.ContributionsV1>(a.Contributions).ToList();
                b.Accessories = Mapper.MapAll<PartyOrganiser.BusinessObjects.Accessory, PartyOrganiser.API.Objects.AccessoriesV1>(a.Accessories).ToList();
                b.Id = a.Id;
                b.StartDate = a.StartDate;
                b.EndDate = a.EndDate;
                b.SelectedLoc = Mapper.Map<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.SelectedLocalisationParty>(a.SelectedLocalisation);
                b.PartyName = a.Name;
                b.Trips = Mapper.MapAll<PartyOrganiser.BusinessObjects.Trip, PartyOrganiser.API.Objects.TripsV1>(a.Trip).ToList();
                b.PeoplesParty = Mapper.MapAll<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesParty>(a.Peoples).ToList();
            }).Reverse((b,a)=>
            {
                a.Galleries = Mapper.MapAll<PartyOrganiser.API.Objects.GalleriesV1, PartyOrganiser.BusinessObjects.Gallery>(b.Galleries).ToList();
                a.Contributions = Mapper.MapAll<PartyOrganiser.API.Objects.ContributionsV1, PartyOrganiser.BusinessObjects.Contribution>(b.Contributions).ToList();
                a.Accessories = Mapper.MapAll<PartyOrganiser.API.Objects.AccessoriesV1, PartyOrganiser.BusinessObjects.Accessory>(b.Accessories).ToList();
                a.Id = b.Id;
                a.StartDate = b.StartDate;
                a.EndDate = b.EndDate;
                a.SelectedLocalisation = Mapper.Map<PartyOrganiser.API.Objects.SelectedLocalisationParty, PartyOrganiser.BusinessObjects.Localisation>(b.SelectedLoc);
                a.Name = b.PartyName;
                a.Trip = Mapper.MapAll<PartyOrganiser.API.Objects.TripsV1, PartyOrganiser.BusinessObjects.Trip>(b.Trips).ToList();
                a.Peoples = Mapper.MapAll<PartyOrganiser.API.Objects.PeoplesParty, PartyOrganiser.BusinessObjects.People>(b.PeoplesParty).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.PartiesV1HATEOAS>((a, b)=>
            {

                b.Galleries = Mapper.MapAll<PartyOrganiser.BusinessObjects.Gallery, PartyOrganiser.API.Objects.GalleriesV1HATEOAS>(a.Galleries).ToList();
                b.Contributions = Mapper.MapAll<PartyOrganiser.BusinessObjects.Contribution, PartyOrganiser.API.Objects.ContributionsV1HATEOAS>(a.Contributions).ToList();
                b.Accessories = Mapper.MapAll<PartyOrganiser.BusinessObjects.Accessory, PartyOrganiser.API.Objects.AccessoriesV1HATEOAS>(a.Accessories).ToList();
                b.Id = a.Id;
                b.StartDate = a.StartDate;
                b.EndDate = a.EndDate;
                b.SelectedLoc = Mapper.Map<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS>(a.SelectedLocalisation);
                b.PartyName = a.Name;
                b.Trips = Mapper.MapAll<PartyOrganiser.BusinessObjects.Trip, PartyOrganiser.API.Objects.TripsV1HATEOAS>(a.Trip).ToList();
                b.PeoplesParty = Mapper.MapAll<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>(a.Peoples).ToList();
            }).Reverse((b,a)=>
            {
                a.Galleries = Mapper.MapAll<PartyOrganiser.API.Objects.GalleriesV1HATEOAS, PartyOrganiser.BusinessObjects.Gallery>(b.Galleries).ToList();
                a.Contributions = Mapper.MapAll<PartyOrganiser.API.Objects.ContributionsV1HATEOAS, PartyOrganiser.BusinessObjects.Contribution>(b.Contributions).ToList();
                a.Accessories = Mapper.MapAll<PartyOrganiser.API.Objects.AccessoriesV1HATEOAS, PartyOrganiser.BusinessObjects.Accessory>(b.Accessories).ToList();
                a.Id = b.Id;
                a.StartDate = b.StartDate;
                a.EndDate = b.EndDate;
                a.SelectedLocalisation = Mapper.Map<PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Localisation>(b.SelectedLoc);
                a.Name = b.PartyName;
                a.Trip = Mapper.MapAll<PartyOrganiser.API.Objects.TripsV1HATEOAS, PartyOrganiser.BusinessObjects.Trip>(b.Trips).ToList();
                a.Peoples = Mapper.MapAll<PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.People>(b.PeoplesParty).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.PartiesV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.StartDate = a.StartDate;
                b.EndDate = a.EndDate;
                b.PartyName = a.Name;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.StartDate = b.StartDate;
                a.EndDate = b.EndDate;
                a.Name = b.PartyName;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.PartiesV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.StartDate = a.StartDate;
                b.EndDate = a.EndDate;
                b.PartyName = a.Name;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.StartDate = b.StartDate;
                a.EndDate = b.EndDate;
                a.Name = b.PartyName;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.ElectionParty>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Party,PartyOrganiser.API.Objects.PartiesInvolved>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region People
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.PeoplesV1>((a, b)=>
            {

                b.Car = Mapper.Map<PartyOrganiser.BusinessObjects.Car, PartyOrganiser.API.Objects.CarsV1>(a.Car);
                b.Parties = Mapper.MapAll<PartyOrganiser.BusinessObjects.Party, PartyOrganiser.API.Objects.PartiesInvolved>(a.Parties).ToList();
                b.Id = a.Id;
                b.FirstName = a.FirstName;
                b.LastName = a.LastName;
                b.Age = a.Age;
                b.Phone = a.Phone;
                b.Email = a.Email;
            }).Reverse((b,a)=>
            {
                a.Car = Mapper.Map<PartyOrganiser.API.Objects.CarsV1, PartyOrganiser.BusinessObjects.Car>(b.Car);
                a.Parties = Mapper.MapAll<PartyOrganiser.API.Objects.PartiesInvolved, PartyOrganiser.BusinessObjects.Party>(b.Parties).ToList();
                a.Id = b.Id;
                a.FirstName = b.FirstName;
                a.LastName = b.LastName;
                a.Age = b.Age;
                a.Phone = b.Phone;
                a.Email = b.Email;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.PeoplesV1HATEOAS>((a, b)=>
            {

                b.Car = Mapper.Map<PartyOrganiser.BusinessObjects.Car, PartyOrganiser.API.Objects.CarsV1HATEOAS>(a.Car);
                b.Parties = Mapper.MapAll<PartyOrganiser.BusinessObjects.Party, PartyOrganiser.API.Objects.PartiesV1SimpleHATEOAS>(a.Parties).ToList();
                b.Id = a.Id;
                b.FirstName = a.FirstName;
                b.LastName = a.LastName;
                b.Age = a.Age;
                b.Phone = a.Phone;
                b.Email = a.Email;
            }).Reverse((b,a)=>
            {
                a.Car = Mapper.Map<PartyOrganiser.API.Objects.CarsV1HATEOAS, PartyOrganiser.BusinessObjects.Car>(b.Car);
                a.Parties = Mapper.MapAll<PartyOrganiser.API.Objects.PartiesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Party>(b.Parties).ToList();
                a.Id = b.Id;
                a.FirstName = b.FirstName;
                a.LastName = b.LastName;
                a.Age = b.Age;
                a.Phone = b.Phone;
                a.Email = b.Email;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.PeoplesV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.FirstName = a.FirstName;
                b.LastName = a.LastName;
                b.Age = a.Age;
                b.Phone = a.Phone;
                b.Email = a.Email;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.FirstName = b.FirstName;
                a.LastName = b.LastName;
                a.Age = b.Age;
                a.Phone = b.Phone;
                a.Email = b.Email;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.FirstName = a.FirstName;
                b.LastName = a.LastName;
                b.Age = a.Age;
                b.Phone = a.Phone;
                b.Email = a.Email;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.FirstName = b.FirstName;
                a.LastName = b.LastName;
                a.Age = b.Age;
                a.Phone = b.Phone;
                a.Email = b.Email;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.Owner>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.PeoplesParty>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.People,PartyOrganiser.API.Objects.Voter>((a, b)=>
            {
                b.Id = a.Id;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
            });
#endregion
#region Stop
            Mapper.Register<PartyOrganiser.BusinessObjects.Stop,PartyOrganiser.API.Objects.StopsV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Arrival = a.Arrival;
                b.Departure = a.Departure;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.Title = a.Title;
                b.Comment = a.Comment;
                b.PeoplesParty = Mapper.MapAll<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesParty>(a.Passengers).ToList();
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Arrival = b.Arrival;
                a.Departure = b.Departure;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.Title = b.Title;
                a.Comment = b.Comment;
                a.Passengers = Mapper.MapAll<PartyOrganiser.API.Objects.PeoplesParty, PartyOrganiser.BusinessObjects.People>(b.PeoplesParty).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Stop,PartyOrganiser.API.Objects.StopsV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Arrival = a.Arrival;
                b.Departure = a.Departure;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.Title = a.Title;
                b.Comment = a.Comment;
                b.PeoplesParty = Mapper.MapAll<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>(a.Passengers).ToList();
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Arrival = b.Arrival;
                a.Departure = b.Departure;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.Title = b.Title;
                a.Comment = b.Comment;
                a.Passengers = Mapper.MapAll<PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.People>(b.PeoplesParty).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Stop,PartyOrganiser.API.Objects.StopsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Arrival = a.Arrival;
                b.Departure = a.Departure;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.Title = a.Title;
                b.Comment = a.Comment;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Arrival = b.Arrival;
                a.Departure = b.Departure;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.Title = b.Title;
                a.Comment = b.Comment;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Stop,PartyOrganiser.API.Objects.StopsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Arrival = a.Arrival;
                b.Departure = a.Departure;
                b.GpsLatitude = a.GpsLatitude;
                b.GpsLongitude = a.GpsLongitude;
                b.Title = a.Title;
                b.Comment = a.Comment;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Arrival = b.Arrival;
                a.Departure = b.Departure;
                a.GpsLatitude = b.GpsLatitude;
                a.GpsLongitude = b.GpsLongitude;
                a.Title = b.Title;
                a.Comment = b.Comment;
            });
#endregion
#region Trip
            Mapper.Register<PartyOrganiser.BusinessObjects.Trip,PartyOrganiser.API.Objects.TripsV1>((a, b)=>
            {

                b.Car = Mapper.Map<PartyOrganiser.BusinessObjects.Car, PartyOrganiser.API.Objects.TripsCars>(a.Car);
                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Stops = Mapper.MapAll<PartyOrganiser.BusinessObjects.Stop, PartyOrganiser.API.Objects.StopsV1>(a.Stop).ToList();
            }).Reverse((b,a)=>
            {
                a.Car = Mapper.Map<PartyOrganiser.API.Objects.TripsCars, PartyOrganiser.BusinessObjects.Car>(b.Car);
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Stop = Mapper.MapAll<PartyOrganiser.API.Objects.StopsV1, PartyOrganiser.BusinessObjects.Stop>(b.Stops).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Trip,PartyOrganiser.API.Objects.TripsV1HATEOAS>((a, b)=>
            {

                b.Car = Mapper.Map<PartyOrganiser.BusinessObjects.Car, PartyOrganiser.API.Objects.CarsV1SimpleHATEOAS>(a.Car);
                b.Id = a.Id;
                b.Capacity = a.Capacity;
                b.Stops = Mapper.MapAll<PartyOrganiser.BusinessObjects.Stop, PartyOrganiser.API.Objects.StopsV1HATEOAS>(a.Stop).ToList();
            }).Reverse((b,a)=>
            {
                a.Car = Mapper.Map<PartyOrganiser.API.Objects.CarsV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Car>(b.Car);
                a.Id = b.Id;
                a.Capacity = b.Capacity;
                a.Stop = Mapper.MapAll<PartyOrganiser.API.Objects.StopsV1HATEOAS, PartyOrganiser.BusinessObjects.Stop>(b.Stops).ToList();
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Trip,PartyOrganiser.API.Objects.TripsV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Trip,PartyOrganiser.API.Objects.TripsV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Capacity = a.Capacity;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Capacity = b.Capacity;
            });
#endregion
#region Vote
            Mapper.Register<PartyOrganiser.BusinessObjects.Vote,PartyOrganiser.API.Objects.VotesV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Order = a.Order;
                b.Voter = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.Voter>(a.People);
                b.ProposedLocalisation = Mapper.Map<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.ProposedLocalisation>(a.Localisation);
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Order = b.Order;
                a.People = Mapper.Map<PartyOrganiser.API.Objects.Voter, PartyOrganiser.BusinessObjects.People>(b.Voter);
                a.Localisation = Mapper.Map<PartyOrganiser.API.Objects.ProposedLocalisation, PartyOrganiser.BusinessObjects.Localisation>(b.ProposedLocalisation);
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Vote,PartyOrganiser.API.Objects.VotesV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Order = a.Order;
                b.Voter = Mapper.Map<PartyOrganiser.BusinessObjects.People, PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS>(a.People);
                b.ProposedLocalisation = Mapper.Map<PartyOrganiser.BusinessObjects.Localisation, PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS>(a.Localisation);
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Order = b.Order;
                a.People = Mapper.Map<PartyOrganiser.API.Objects.PeoplesV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.People>(b.Voter);
                a.Localisation = Mapper.Map<PartyOrganiser.API.Objects.LocalisationsV1SimpleHATEOAS, PartyOrganiser.BusinessObjects.Localisation>(b.ProposedLocalisation);
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Vote,PartyOrganiser.API.Objects.VotesV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Order = a.Order;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Order = b.Order;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Vote,PartyOrganiser.API.Objects.VotesV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Order = a.Order;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Order = b.Order;
            });
#endregion
#region Media
            Mapper.Register<PartyOrganiser.BusinessObjects.Media,PartyOrganiser.API.Objects.MediasV1>((a, b)=>
            {

                b.Id = a.Id;
                b.Title = a.Title;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Media,PartyOrganiser.API.Objects.MediasV1HATEOAS>((a, b)=>
            {

                b.Id = a.Id;
                b.Title = a.Title;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Media,PartyOrganiser.API.Objects.MediasV1Simple>((a, b)=>
            {
                b.Id = a.Id;
                b.Title = a.Title;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.Media,PartyOrganiser.API.Objects.MediasV1SimpleHATEOAS>((a, b)=>
            {
                b.Id = a.Id;
                b.Title = a.Title;
            }).Reverse((b,a)=>
            {
                a.Id = b.Id;
                a.Title = b.Title;
            });
#endregion
#region LinkMedia
            Mapper.Register<PartyOrganiser.BusinessObjects.LinkMedia,PartyOrganiser.API.Objects.MediasV1>((a, b)=>
            {

                b.Href = a.Href;
            }).Reverse((b,a)=>
            {
                a.Href = b.Href;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.LinkMedia,PartyOrganiser.API.Objects.MediasV1HATEOAS>((a, b)=>
            {

                b.Href = a.Href;
            }).Reverse((b,a)=>
            {
                a.Href = b.Href;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.LinkMedia,PartyOrganiser.API.Objects.MediasV1Simple>((a, b)=>
            {
                b.Href = a.Href;
            }).Reverse((b,a)=>
            {
                a.Href = b.Href;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.LinkMedia,PartyOrganiser.API.Objects.MediasV1SimpleHATEOAS>((a, b)=>
            {
                b.Href = a.Href;
            }).Reverse((b,a)=>
            {
                a.Href = b.Href;
            });
#endregion
#region RawMedia
            Mapper.Register<PartyOrganiser.BusinessObjects.RawMedia,PartyOrganiser.API.Objects.RawMediasV1>((a, b)=>
            {

                b.Raw = a.Raw;
                b.Raw = a.Raw;
            }).Reverse((b,a)=>
            {
                a.Raw = b.Raw;
                a.Raw = b.Raw;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.RawMedia,PartyOrganiser.API.Objects.RawMediasV1HATEOAS>((a, b)=>
            {

                b.Raw = a.Raw;
                b.Raw = a.Raw;
            }).Reverse((b,a)=>
            {
                a.Raw = b.Raw;
                a.Raw = b.Raw;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.RawMedia,PartyOrganiser.API.Objects.RawMediasV1Simple>((a, b)=>
            {
                b.Raw = a.Raw;
                b.Raw = a.Raw;
            }).Reverse((b,a)=>
            {
                a.Raw = b.Raw;
                a.Raw = b.Raw;
            });
            Mapper.Register<PartyOrganiser.BusinessObjects.RawMedia,PartyOrganiser.API.Objects.RawMediasV1SimpleHATEOAS>((a, b)=>
            {
                b.Raw = a.Raw;
                b.Raw = a.Raw;
            }).Reverse((b,a)=>
            {
                a.Raw = b.Raw;
                a.Raw = b.Raw;
            });
#endregion
        }
    }
}

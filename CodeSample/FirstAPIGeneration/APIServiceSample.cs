namespace PartyOrganiser.API.Services.Abstracts
{
	using System.Collections.Generic;
	using PartyOrganiser.API.Objects;
	using PartyOrganiser.API.Common;
	using System.Threading.Tasks;
	using System.Threading;

	/// <summary>
	/// Interface for api object <see cref="PeoplesV1"/>, contains needed declarations of api services methods for the default and dummy behavior of the API
	/// </summary>
	public partial interface IDefaultPeoplesV1APIService
	{
		/// <summary>
		/// Have to return the <see cref="PeoplesV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS"/>) from the DB with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1"/></returns>
		Task<PeoplesV1HATEOAS> GetAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all <see cref="PeoplesV1"/> in their simple HATEOAS type form (<see cref="PeoplesV1SimpleHATEOAS"/>) from the DB
		/// </summary>
		/// <param name="listRequestParameters"><see cref="ApiListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="ApiPaginateResponse"/> for <see cref="PeoplesV1Simple"/></returns>
		Task<ApiPaginateResponse<PeoplesV1SimpleHATEOAS>> ListAsync(ApiListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to create a <see cref="PeoplesV1"/> with given parameters in the DB
		/// </summary>
		/// <param name="item"><see cref="PeoplesV1/"></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> CreateAsync(PeoplesV1 item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to update the <see cref="PeoplesV1Simple"/> with given parameters in the DB
		/// </summary>
		/// <param name="item"><see cref="PeoplesV1Simple"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1Simple"/></returns>
		Task<PeoplesV1Simple> UpdateAsync(PeoplesV1Simple item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to delete the <see cref="PeoplesV1"/> in the DB with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task DeleteAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the Owner for a <see cref="GalleriesV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS") from the DB with given parameters
		/// </summary>
		/// <param name="ownerId"><see cref="int"/></param>
		/// <param name="galleriesId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> GetOwnerFromGalleriesV1Async(int partiesId, int galleriesId, int ownerId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the Contributor for a <see cref="ContributionPartsV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS") from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="contributionPartsId"><see cref="int"/></param>
		/// <param name="contributionsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> GetContributorFromContributionPartsV1Async(int partiesId, int contributionsId, int contributionPartsId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the PeoplesParty for a <see  cref="StopsV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS") from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> GetPeoplesPartyFromStopsV1Async(int partiesId, int tripsId, int stopsId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all PeoplesParty for a <see cref="StopsV1"/> in their simple HATEOAS type form (<see cref="PeoplesV1SimpleHATEOAS"/>) from the DB
		/// </summary>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="ApiListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="ApiPaginateResponse"/> for <see cref="PeoplesV1SimpleHATEOAS"/></returns>
		Task<ApiPaginateResponse<PeoplesV1SimpleHATEOAS>> ListPeoplesPartyFromStopsV1Async(int partiesId, int tripsId, int stopsId, ApiListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the PeoplesParty for a <see  cref="PartiesV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS") from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> GetPeoplesPartyFromPartiesV1Async(int partiesId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all PeoplesParty for a <see cref="PartiesV1"/> in their simple HATEOAS type form (<see cref="PeoplesV1SimpleHATEOAS"/>) from the DB
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="ApiListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="ApiPaginateResponse"/> for <see cref="PeoplesV1SimpleHATEOAS"/></returns>
		Task<ApiPaginateResponse<PeoplesV1SimpleHATEOAS>> ListPeoplesPartyFromPartiesV1Async(int partiesId, ApiListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the Voter for a <see cref="VotesV1"/> in his HATEOAS form (<see cref="PeoplesV1HATEOAS") from the DB with given parameters
		/// </summary>
		/// <param name="voterId"><see cref="int"/></param>
		/// <param name="votesId"><see cref="int"/></param>
		/// <param name="electionsId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PeoplesV1HATEOAS"/></returns>
		Task<PeoplesV1HATEOAS> GetVoterFromVotesV1Async(int electionsId, int votesId, int voterId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to add a Parties to a <see cref="PeoplesV1"/> in the DB with given parameters
		/// </summary>
		/// <param name="partiesInvolvedId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task AddPartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to remove a Parties to a <see cref="PeoplesV1"/> in the DB with given parameters
		/// </summary>
		/// <param name="partiesInvolvedId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task RemovePartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken);

  
		/// <summary>
		/// Have to translate api properties, contained in sortProp, to business properties
		/// </summary>
		/// <param name="sortProp">String array of properties to sort</param>
		/// <param name="dico">Dictionnary of translated properties</param>
		/// <param name="entityName">API entity name</param>
		/// <returns>Translated properties</returns>
		string[] TranslateSortingProperties(string[] sortProp, Dictionary<string, string> dico, string entityName);
	}
}

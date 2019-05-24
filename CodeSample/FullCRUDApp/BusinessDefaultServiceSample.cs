namespace PartyOrganiser.BusinessLayer.Abstracts
{
	using PartyOrganiser.BusinessObjects;
	using PartyOrganiser.Business.Common;
	using System.Threading.Tasks;
	using System.Threading;

	/// <summary>
	/// Interface for business object <see cref="People"/>, contains needed declarations of business services methods for the default behavior of the API
	/// </summary>
	public partial interface IDefaultPeopleBusinessService
	{
		/// <summary>
		/// Have to return the <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to list all <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="listRequestParameters"><see cref="BusinessListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="BusinessPaginateResult"/> for <see cref="People"/></returns>
		Task<BusinessPaginateResult<People>> ListAsync(BusinessListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to create a <see cref="People"/> with the given parameters
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> CreateAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to update the <see cref="People"/> with the given parameters (only scalar properties)
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> UpdateAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to update the <see cref="People"/> with the given parameters
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> UpdateClusterAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to delete the <see cref="People"/> with given key(s) paramter(s)
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task DeleteAsync(int peoplesId, CancellationToken cancellationToken);
		/// <summary>
		/// Have to return the Owner of the <see cref="Gallery"/> from the DB with given parameters
		/// </summary>
		/// <param name="ownerId"><see cref="int"/></param>
		/// <param name="galleriesId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetOwnerFromGalleryAsync(int partiesId, int galleriesId, int ownerId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the People of the <see cref="ContributionPart"/> from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="contributionPartsId"><see cref="int"/></param>
		/// <param name="contributionsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetPeopleFromContributionPartAsync(int partiesId, int contributionsId, int contributionPartsId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the Passengers for the <see cref="Stop"/> from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetPassengersFromStopAsync(int partiesId, int tripsId, int stopsId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all Passengers for the <see cref="Stop"/> from the DB with given parameters
		/// </summary>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="BusinessListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="BusinessPaginateResult"/> of <see cref="People"/></returns>
		Task<BusinessPaginateResult<People>> ListPassengersFromStopAsync(int partiesId, int tripsId, int stopsId, BusinessListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the Peoples for the <see cref="Party"/> from the DB with given parameters
		/// </summary>
		/// <param name="peoplesPartyId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetPeoplesFromPartyAsync(int partiesId, int peoplesPartyId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all Peoples for the <see cref="Party"/> from the DB with given parameters
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="BusinessListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="BusinessPaginateResult"/> of <see cref="People"/></returns>
		Task<BusinessPaginateResult<People>> ListPeoplesFromPartyAsync(int partiesId, BusinessListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the People of the <see cref="Vote"/> from the DB with given parameters
		/// </summary>
		/// <param name="voterId"><see cref="int"/></param>
		/// <param name="votesId"><see cref="int"/></param>
		/// <param name="electionsId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetPeopleFromVoteAsync(int electionsId, int votesId, int voterId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to add a Parties to <see cref="People"/> in the DB with given parameters
		/// </summary>
		/// <param name="partiesInvolvedId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task AddPartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to remove a Parties to <see cref="People"/> in the DB with given parameters
		/// </summary>
		/// <param name="partiesInvolvedId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task RemovePartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken);

	}
}

namespace PartyOrganiser.DataLayer.Services.Abstracts
{
	using PartyOrganiser.DataLayer.Modelers.Abstracts;
	using PartyOrganiser.BusinessObjects;
	using PartyOrganiser.DataLayer.Common;
	using System.Threading.Tasks;
	using System.Threading;

	/// <summary>
	/// Interface declaration for People, contains needed declarations of dao methods for the default behavior of the API
	/// </summary>
	public partial interface IDefaultPeopleDaoService
	{

		/// <summary>
		/// Have to return true if a <see cref="People"/> with given parameters exist
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistWithKeysAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return the <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> GetWithKeysAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="listRequestParameters"><see cref="DaoListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PaginateResult"/> for <see cref="People"/></returns>
		Task<PaginateResult<People>> ListAsync(DaoListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to create a <see cref="People"/> with the given item, use the includesManager.CreatePeople
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> CreateClusterAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to update the <see cref="People"/> with the given item, does not use the includesManager
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> UpdateAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to update the <see cref="People"/> with the given item, use the IncludesManager.CreatePeople
		/// </summary>
		/// <param name="item"><see cref="People"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="People"/></returns>
		Task<People> UpdateClusterAsync(People item, CancellationToken cancellationToken);

		/// <summary>
		/// Have to delete the <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task DeleteWithKeysAsync(int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to add the Party to the <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task AddPartiesAsync(int peoplesId, int partiesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to remove the Party from the <see cref="People"/> with given parameters
		/// </summary>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/></returns>
		Task RemovePartiesAsync(int peoplesId, int partiesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return true if the Owner from the <see cref="Gallery"/> with given parameters exist
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="galleriesId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistOwnerFromGalleryAsync(int partiesId, int galleriesId, int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return true if the People from the <see cref="ContributionPart"/> with given parameters exist
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="contributionsId"><see cref="int"/></param>
		/// <param name="contributionPartsId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistPeopleFromContributionPartAsync(int partiesId, int contributionsId, int contributionPartsId, int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return true if the Passengers from the <see cref="Stop"/> with given parameters exist
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistPassengersFromStopAsync(int partiesId, int tripsId, int stopsId, int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all People from the <see cref="Stop"/> with given parameters
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="tripsId"><see cref="int"/></param>
		/// <param name="stopsId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="DaoListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PaginateResult"/> for <see cref="People"/></returns>
		Task<PaginateResult<People>> ListPassengersFromStopAsync(int partiesId, int tripsId, int stopsId, DaoListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return true if the Peoples from the <see cref="Party"/> with given parameters exist
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistPeoplesFromPartyAsync(int partiesId, int peoplesId, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return all People from the <see cref="Party"/> with given parameters
		/// </summary>
		/// <param name="partiesId"><see cref="int"/></param>
		/// <param name="listRequestParameters"><see cref="DaoListRequestParameters"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of <see cref="PaginateResult"/> for <see cref="People"/></returns>
		Task<PaginateResult<People>> ListPeoplesFromPartyAsync(int partiesId, DaoListRequestParameters listRequestParameters, CancellationToken cancellationToken);

		/// <summary>
		/// Have to return true if the People from the <see cref="Vote"/> with given parameters exist
		/// </summary>
		/// <param name="electionsId"><see cref="int"/></param>
		/// <param name="votesId"><see cref="int"/></param>
		/// <param name="peoplesId"><see cref="int"/></param>
		/// <param name="cancellationToken"><see cref="CancellationToken"/></param>
		/// <returns><see cref="Task"/> of bool</returns>
		Task<bool> ExistPeopleFromVoteAsync(int electionsId, int votesId, int peoplesId, CancellationToken cancellationToken);
	}
}

namespace PartyOrganiser.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Net;
    using System;
    using PartyOrganiser.API.Controllers.Exceptions;
    using PartyOrganiser.API.Services.Exceptions;
    using PartyOrganiser.API.Services.Abstracts;
    using PartyOrganiser.API.Objects;
    using PartyOrganiser.API.Common.Controller.Abstracts;
    using PartyOrganiser.API.Common;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// API Controller for the entity Peoples
    /// </summary>
    [Route("api/v1")]
    public partial class PeoplesV1Controller : Controller
    {

        /// <summary>
        /// APIService for API controller <see cref="PeoplesV1Controller"/>
        /// </summary>
        private readonly IDefaultPeoplesV1APIService APIService;

        /// <summary>
        /// Logger for API controller <see cref="PeoplesV1Controller"/>
        /// </summary>
        private readonly ILogger Logger;

        /// <summary>
        /// Helper for API controller <see cref="PeoplesV1Controller"/>
        /// </summary>
        private readonly IApiControllerHelper Helper;


        /// <summary>
        /// Constructor with the API services interfaces needed
        /// </summary>
        /// <param name="apiService"><see cref="IDefaultPeoplesV1APIService"/> instance</param>
        /// <param name="helper"><see cref="IApiControllerHelper"/> instance</param>
        /// <param name="logger"><see cref="ILogger"/> instance</param>
        public PeoplesV1Controller(IDefaultPeoplesV1APIService apiService, IApiControllerHelper helper, ILogger<PeoplesV1Controller> logger)
        {
            this.APIService = apiService;
            this.Helper = helper;
            this.Logger = logger;
        }

        /// <summary>
        /// Route name for getting a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLES_BY_ID_CONST = "GetPeoplesByID";
        public static readonly string GET_PEOPLES_BY_ID = GET_PEOPLES_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Peoples/{peoplesId:int}", Name = GET_PEOPLES_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetAsync(int peoplesId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetAsync(peoplesId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {	  
                        item = WriteHATEOASLinks(this.Url, item);
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for listing all <see cref="PeoplesV1Simple"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLES_LIST_CONST = "GetPeoplesList";
        public static readonly string GET_PEOPLES_LIST = GET_PEOPLES_LIST_CONST;

        /// <summary>
        /// Return the response for listing all <see cref="PeoplesV1Simple"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Peoples",Name = GET_PEOPLES_LIST_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.PartialContent, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> ListAsync(string range = null, string sort = null, string desc = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    ApiListRequestParameters parameters = Helper.ParseApiListRequestParameters(range, sort, desc);
                    ApiPaginateResponse<PeoplesV1SimpleHATEOAS> response = await APIService.ListAsync(parameters, cancellationToken);
                    if(response.Content == null || response.Content.Count == 0)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "No resources", "No resources founds for this get-list request."));
                    }
                    foreach(PeoplesV1SimpleHATEOAS data in response.Content)
                    {  
                        WriteSimpleHATEOASLinks(this.Url, data);
                    }
                    response.Links.Add(new ApiHATEOASLink("create, don't forget to put the item to create in the body", "POST", this.Url.Link(CREATE_PEOPLES_ITEM, null)));
                    if (!response.IsMonoPage)
                    {
                        int prevStart = parameters.Offset - (parameters.Limit + 1);
                        int nextEnd = parameters.Offset + (2 * parameters.Limit) + 1;
                        if (prevStart>=0)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-prev", "GET", this.Url.Link(GET_PEOPLES_LIST, new { range = $"{prevStart}-{prevStart + parameters.Limit}", sort, desc })));
                        }
                        if (nextEnd <= response.TotalRows)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-next", "GET", this.Url.Link(GET_PEOPLES_LIST, new { range = $"{nextEnd - parameters.Limit}-{nextEnd}", sort, desc })));
                        }
                        response.Links.Add(new ApiHATEOASLink("list-first", "GET", this.Url.Link(GET_PEOPLES_LIST, new { range = $"0-{parameters.Limit}", sort, desc })));
                        response.Links.Add(new ApiHATEOASLink("list-last", "GET", this.Url.Link(GET_PEOPLES_LIST, new { range = $"{response.TotalRows - parameters.Limit}-{response.TotalRows}", sort, desc })));
                    }
                    if(response.IsMonoPage)
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.OK
                        };
                        if (!string.IsNullOrEmpty(range))
                        {
                            Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        }
                        return result;
                    }
                    else
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.PartialContent
                        };
                        Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        return result;
                    }
                    
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for creating a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string CREATE_PEOPLES_ITEM_CONST = "CreatePeoplesItem";
        public static readonly string CREATE_PEOPLES_ITEM = CREATE_PEOPLES_ITEM_CONST;


        /// <summary>
        /// Return the response for creating a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="item"><see cref="PeoplesV1"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpPost("Peoples",Name = CREATE_PEOPLES_ITEM_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.Conflict, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> CreateAsync([FromBody] PeoplesV1 item, CancellationToken cancellationToken = default(CancellationToken))
        {			
            using (Logger.Perfs())
            {
                try
                {
                    if (item == null || !ModelState.IsValid)
                    {
                         return BadRequest(Helper.FormatModelStateError(ModelState));
                    }
                    PeoplesV1HATEOAS itemCreated = await APIService.CreateAsync(item, cancellationToken);   
                    itemCreated = WriteHATEOASLinks(this.Url, itemCreated);
                    return Ok(itemCreated);
                }
                catch (APIObjAlreadyExistException e)
                {
                    return Conflict(Helper.FormatExceptionError(e));
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for updating a <see cref="PeoplesV1Simple"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string UPDATE_PEOPLES_ITEM_CONST = "UpdatePeoplesItem";
        public static readonly string UPDATE_PEOPLES_ITEM = UPDATE_PEOPLES_ITEM_CONST;
        
        /// <summary>
        /// Return the response for updating a <see cref="PeoplesV1Simple"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="item"><see cref="PeoplesV1Simple"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        /// <exception cref="PayloadPKAndRoutingException"/>
        [HttpPut("Peoples/{peoplesId:int}", Name = UPDATE_PEOPLES_ITEM_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiDefaultResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> UpdateAsync(int peoplesId, [FromBody] PeoplesV1Simple item, CancellationToken cancellationToken = default(CancellationToken))
        {			
            using (Logger.Perfs())
            {
                try
                {
                    if (item == null || !ModelState.IsValid)
                    {
                         return BadRequest(Helper.FormatModelStateError(ModelState));
                    }
                    if(!CheckIds(peoplesId, item))
                    {
                        throw new PayloadPKAndRoutingException("Payload key and routing are different");
                    }
                    await APIService.UpdateAsync(item, cancellationToken);
                    return Ok(Helper.FormatDefaultResponse(true,"Update done", $"Resource PeoplesV1 updated."));
                }
                catch (APIObjNotFoundException e)
                {
                    return NotFound(Helper.FormatExceptionError(e));
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for deleting a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string DELETE_PEOPLES_BY_ID_CONST = "DeletePeoplesByID";
        public static readonly string DELETE_PEOPLES_BY_ID = DELETE_PEOPLES_BY_ID_CONST;

        /// <summary>
        /// Return response for deleting a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpDelete("Peoples/{peoplesId:int}", Name = DELETE_PEOPLES_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiDefaultResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> DeleteAsync(int peoplesId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    await APIService.DeleteAsync(peoplesId, cancellationToken);
                    return Ok(Helper.FormatDefaultResponse(true,"Delete done", $"Resource PeoplesV1 deleted."));
                }
                catch (APIObjNotFoundException e)
                {
                    return NotFound(Helper.FormatExceptionError(e));
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }
        /// <summary>
        /// Patch a <see cref="PeoplesV1HATEOAS"/> with needed HATEOAS links
        /// </summary>
        /// <param name="urlHelper">Instance of <see cref="IUrlHelper"/></param>
        /// <param name="item"><see cref="PeoplesV1HATEOAS"/>Item to patch</param>
        /// <returns><see cref="PeoplesV1HATEOAS"/>Patched item</returns>
        [NonAction]
        public static PeoplesV1HATEOAS WriteHATEOASLinks(IUrlHelper urlHelper, PeoplesV1HATEOAS item)
        {
            item.Links.Clear();
            item.Links.Add(new ApiHATEOASLink("detail", "GET", urlHelper.Link(GET_PEOPLES_BY_ID, new { peoplesId = item.Id })));
            item.Links.Add(new ApiHATEOASLink("update, don't forget to put the item to update in the body", "PUT", urlHelper.Link(UPDATE_PEOPLES_ITEM, new { peoplesId = item.Id })));
            item.Links.Add(new ApiHATEOASLink("delete", "DELETE", urlHelper.Link(DELETE_PEOPLES_BY_ID, new { peoplesId = item.Id})));
            item.Links.Add(new ApiHATEOASLink("list, you can ask a range and/or sorting the result (ie : [link]/?range=0-10&sort=property1&desc=property2)", "GET", urlHelper.Link(GET_PEOPLES_LIST, null)));
            if(item.Car != null)
            {
                item.Car = CarsV1Controller.WriteCarHATEOASLinksFromPeoplesV1(urlHelper, item.Car, item.Id);
            }
            item.Links.Add(new ApiHATEOASLink("Car-create, don't forget to put the item to create in the body", "POST", urlHelper.Link(CarsV1Controller.CREATE_CAR_FROM_PEOPLESV1_ITEM, new { peoplesId = item.Id })));
            foreach(var childData in item.Parties)
            {
                childData.Links.Add(new ApiHATEOASLink("Parties-remove, remove the Parties from collection", "DELETE", urlHelper.Link(REMOVE_PARTIES_BY_ID, new { peoplesId = item.Id, partiesInvolvedId = childData.Id })));
            }
            item.Links.Add(new ApiHATEOASLink("Parties-add, add the Parties from collection, replace 0 by the id you want to add", "POST", urlHelper.Link(ADD_PARTIES_BY_ID, new { peoplesId = item.Id, partiesInvolvedId = 0 })));
    
            return item;
        }

        /// <summary>
        /// Patch a <see cref="PeoplesV1SimpleHATEOAS"/> with needed HATEOAS links
        /// </summary>
        /// <param name="urlHelper">Instance of <see cref="IUrlHelper"/></param>
        /// <param name="item"><see cref="PeoplesV1SimpleHATEOAS"/>Item to patch</param>
        /// <returns><see cref="PeoplesV1SimpleHATEOAS"/>Patched item</returns>
        [NonAction]
        public static PeoplesV1SimpleHATEOAS WriteSimpleHATEOASLinks(IUrlHelper urlHelper, PeoplesV1SimpleHATEOAS item)
        {
            item.Links.Clear();
            item.Links.Add(new ApiHATEOASLink("detail", "GET", urlHelper.Link(GET_PEOPLES_BY_ID, new { peoplesId = item.Id })));
            item.Links.Add(new ApiHATEOASLink("update, don't forget to put the item to update in the body", "PUT", urlHelper.Link(UPDATE_PEOPLES_ITEM, new { peoplesId = item.Id })));
            item.Links.Add(new ApiHATEOASLink("delete", "DELETE", urlHelper.Link(DELETE_PEOPLES_BY_ID, new { peoplesId = item.Id})));
            return item;
        }

        /// <summary>
        /// Route name for getting a Owner from a <see cref="GalleriesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_OWNER_FROM_GALLERIESV1_BY_ID_CONST = "GetOwnerFromGalleriesV1ByID";
        public static readonly string GET_OWNER_FROM_GALLERIESV1_BY_ID = GET_OWNER_FROM_GALLERIESV1_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a Owner from a <see cref="GalleriesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="galleriesId"><see cref="int"/></param>
        /// <param name="ownerId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/Galleries/{galleriesId:int}/Owner/{ownerId:int}", Name = GET_OWNER_FROM_GALLERIESV1_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetOwnerFromGalleriesV1Async(int partiesId, int galleriesId, int ownerId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetOwnerFromGalleriesV1Async(partiesId, galleriesId, ownerId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for getting a Contributor from a <see cref="ContributionPartsV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_CONTRIBUTOR_FROM_CONTRIBUTIONPARTSV1_BY_ID_CONST = "GetContributorFromContributionPartsV1ByID";
        public static readonly string GET_CONTRIBUTOR_FROM_CONTRIBUTIONPARTSV1_BY_ID = GET_CONTRIBUTOR_FROM_CONTRIBUTIONPARTSV1_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a Contributor from a <see cref="ContributionPartsV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="contributionsId"><see cref="int"/></param>
        /// <param name="contributionPartsId"><see cref="int"/></param>
        /// <param name="peoplesPartyId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/Contributions/{contributionsId:int}/ContributionParts/{contributionPartsId:int}/Contributor/{peoplesPartyId:int}", Name = GET_CONTRIBUTOR_FROM_CONTRIBUTIONPARTSV1_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetContributorFromContributionPartsV1Async(int partiesId, int contributionsId, int contributionPartsId, int peoplesPartyId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetContributorFromContributionPartsV1Async(partiesId, contributionsId, contributionPartsId, peoplesPartyId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for getting a PeoplesParty from a <see cref="StopsV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLESPARTY_FROM_STOPSV1_BY_ID_CONST = "GetPeoplesPartyFromStopsV1ByID";
        public static readonly string GET_PEOPLESPARTY_FROM_STOPSV1_BY_ID = GET_PEOPLESPARTY_FROM_STOPSV1_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a PeoplesParty from a <see cref="StopsV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="tripsId"><see cref="int"/></param>
        /// <param name="stopsId"><see cref="int"/></param>
        /// <param name="peoplesPartyId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/Trips/{tripsId:int}/Stops/{stopsId:int}/PeoplesParty/{peoplesPartyId:int}", Name = GET_PEOPLESPARTY_FROM_STOPSV1_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetPeoplesPartyFromStopsV1Async(int partiesId, int tripsId, int stopsId, int peoplesPartyId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetPeoplesPartyFromStopsV1Async(partiesId, tripsId, stopsId, peoplesPartyId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }
        /// <summary>
        /// Route name for listing all PeoplesParty from a <see cref="StopsV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLESPARTY_FROM_STOPSV1_LIST_CONST = "GetPeoplesPartyFromStopsV1List";
        public static readonly string GET_PEOPLESPARTY_FROM_STOPSV1_LIST = GET_PEOPLESPARTY_FROM_STOPSV1_LIST_CONST;

        /// <summary>
        /// Return the response for listing all PeoplesParty from a <see cref="StopsV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="tripsId"><see cref="int"/></param>
        /// <param name="stopsId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/Trips/{tripsId:int}/Stops/{stopsId:int}/PeoplesParty",Name = GET_PEOPLESPARTY_FROM_STOPSV1_LIST_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.PartialContent, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> ListPeoplesPartyFromStopsV1Async(int partiesId, int tripsId, int stopsId, string range = null, string sort = null, string desc = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    ApiListRequestParameters parameters = Helper.ParseApiListRequestParameters(range, sort, desc);
                    ApiPaginateResponse<PeoplesV1SimpleHATEOAS> response = await APIService.ListPeoplesPartyFromStopsV1Async(partiesId, tripsId, stopsId, parameters, cancellationToken);
                    if(response.Content == null || response.Content.Count == 0)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "No resources", "No resources founds for this get-list request."));
                    }
                    foreach(PeoplesV1SimpleHATEOAS data in response.Content)
                    {
                    }
                    if (!response.IsMonoPage)
                    {
                        int prevStart = parameters.Offset - (parameters.Limit + 1);
                        int nextEnd = parameters.Offset + (2 * parameters.Limit) + 1;
                        if (prevStart>=0)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-prev", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_STOPSV1_LIST, new { range = $"{prevStart}-{prevStart + parameters.Limit}", sort, desc })));
                        }
                        if (nextEnd <= response.TotalRows)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-next", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_STOPSV1_LIST, new { range = $"{nextEnd - parameters.Limit}-{nextEnd}", sort, desc })));
                        }
                        response.Links.Add(new ApiHATEOASLink("list-first", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_STOPSV1_LIST, new { range = $"0-{parameters.Limit}", sort, desc })));
                        response.Links.Add(new ApiHATEOASLink("list-last", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_STOPSV1_LIST, new { range = $"{response.TotalRows - parameters.Limit}-{response.TotalRows}", sort, desc })));					}
                    if(response.IsMonoPage)
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.OK
                        };
                        if (!string.IsNullOrEmpty(range))
                        {
                            Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        }
                        return result;
                    }
                    else
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.PartialContent
                        };
                        Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        return result;
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for getting a PeoplesParty from a <see cref="PartiesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLESPARTY_FROM_PARTIESV1_BY_ID_CONST = "GetPeoplesPartyFromPartiesV1ByID";
        public static readonly string GET_PEOPLESPARTY_FROM_PARTIESV1_BY_ID = GET_PEOPLESPARTY_FROM_PARTIESV1_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a PeoplesParty from a <see cref="PartiesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="peoplesPartyId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/PeoplesParty/{peoplesPartyId:int}", Name = GET_PEOPLESPARTY_FROM_PARTIESV1_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetPeoplesPartyFromPartiesV1Async(int partiesId, int peoplesPartyId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetPeoplesPartyFromPartiesV1Async(partiesId, peoplesPartyId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }
        /// <summary>
        /// Route name for listing all PeoplesParty from a <see cref="PartiesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_PEOPLESPARTY_FROM_PARTIESV1_LIST_CONST = "GetPeoplesPartyFromPartiesV1List";
        public static readonly string GET_PEOPLESPARTY_FROM_PARTIESV1_LIST = GET_PEOPLESPARTY_FROM_PARTIESV1_LIST_CONST;

        /// <summary>
        /// Return the response for listing all PeoplesParty from a <see cref="PartiesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        /// <param name="partiesId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Parties/{partiesId:int}/PeoplesParty",Name = GET_PEOPLESPARTY_FROM_PARTIESV1_LIST_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.PartialContent, typeof(ApiPaginateResponse<PeoplesV1SimpleHATEOAS>))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> ListPeoplesPartyFromPartiesV1Async(int partiesId, string range = null, string sort = null, string desc = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    ApiListRequestParameters parameters = Helper.ParseApiListRequestParameters(range, sort, desc);
                    ApiPaginateResponse<PeoplesV1SimpleHATEOAS> response = await APIService.ListPeoplesPartyFromPartiesV1Async(partiesId, parameters, cancellationToken);
                    if(response.Content == null || response.Content.Count == 0)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "No resources", "No resources founds for this get-list request."));
                    }
                    foreach(PeoplesV1SimpleHATEOAS data in response.Content)
                    {
                    }
                    if (!response.IsMonoPage)
                    {
                        int prevStart = parameters.Offset - (parameters.Limit + 1);
                        int nextEnd = parameters.Offset + (2 * parameters.Limit) + 1;
                        if (prevStart>=0)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-prev", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_PARTIESV1_LIST, new { range = $"{prevStart}-{prevStart + parameters.Limit}", sort, desc })));
                        }
                        if (nextEnd <= response.TotalRows)
                        {
                            response.Links.Add(new ApiHATEOASLink("list-next", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_PARTIESV1_LIST, new { range = $"{nextEnd - parameters.Limit}-{nextEnd}", sort, desc })));
                        }
                        response.Links.Add(new ApiHATEOASLink("list-first", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_PARTIESV1_LIST, new { range = $"0-{parameters.Limit}", sort, desc })));
                        response.Links.Add(new ApiHATEOASLink("list-last", "GET", this.Url.Link(GET_PEOPLESPARTY_FROM_PARTIESV1_LIST, new { range = $"{response.TotalRows - parameters.Limit}-{response.TotalRows}", sort, desc })));					}
                    if(response.IsMonoPage)
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.OK
                        };
                        if (!string.IsNullOrEmpty(range))
                        {
                            Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        }
                        return result;
                    }
                    else
                    {
                        ObjectResult result = new ObjectResult(response)
                        {
                            StatusCode = (int)HttpStatusCode.PartialContent
                        };
                        Request.HttpContext.Response.Headers.Add("Content-Range", $"{range}/{response.TotalRows}");
                        return result;
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for getting a Voter from a <see cref="VotesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string GET_VOTER_FROM_VOTESV1_BY_ID_CONST = "GetVoterFromVotesV1ByID";
        public static readonly string GET_VOTER_FROM_VOTESV1_BY_ID = GET_VOTER_FROM_VOTESV1_BY_ID_CONST;

        /// <summary>
        /// Return the response for getting a Voter from a <see cref="VotesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="electionsId"><see cref="int"/></param>
        /// <param name="votesId"><see cref="int"/></param>
        /// <param name="voterId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpGet("Elections/{electionsId:int}/Votes/{votesId:int}/Voter/{voterId:int}", Name = GET_VOTER_FROM_VOTESV1_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(PeoplesV1HATEOAS))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> GetVoterFromVotesV1Async(int electionsId, int votesId, int voterId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    PeoplesV1HATEOAS item = await APIService.GetVoterFromVotesV1Async(electionsId, votesId, voterId, cancellationToken);
                    if(item==null)
                    {
                        return NotFound(Helper.FormatErrorResponse(false, "Resource not found", $"Resource PeoplesV1 not found for this get request."));
                    }
                    else
                    {
                        return Ok(item);
                    }
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }


        /// <summary>
        /// Route name for adding a Parties to a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string ADD_PARTIES_BY_ID_CONST = "AddPartiesForPeoplesV1ById";
        public static readonly string ADD_PARTIES_BY_ID = ADD_PARTIES_BY_ID_CONST;

        /// <summary>
        /// Return the response for adding a Parties to a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="partiesInvolvedId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpPost("Peoples/{peoplesId:int}/Parties/{partiesInvolvedId:int}", Name = ADD_PARTIES_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiDefaultResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.Conflict, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> AddPartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(Helper.FormatModelStateError(ModelState));
                    }
                    await APIService.AddPartiesAsync(peoplesId, partiesInvolvedId, cancellationToken);
                    return Ok(Helper.FormatDefaultResponse(true,"Resource added", $"Resource Parties added to parent resource."));
                }
                catch (APIObjToAddNotFoundException e)
                {
                    return NotFound(Helper.FormatExceptionError(e));
                }
                catch (APIObjToAddAlreadyInCollectionException e)
                {
                    return Conflict(Helper.FormatExceptionError(e));
                }
                catch (APIObjNotFoundException e)
                {
                    return NotFound(Helper.FormatExceptionError(e));
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Route name for removing a Parties to a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/>
        /// </summary>
        private const string REMOVE_PARTIES_BY_ID_CONST = "RemovePartiesForPeoplesV1ById";
        public static readonly string REMOVE_PARTIES_BY_ID = REMOVE_PARTIES_BY_ID_CONST;

        /// <summary>
        /// Return the response for removing a Parties to a <see cref="PeoplesV1"/> for API controller of <see cref="PeoplesV1"/> with given parameters
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="partiesInvolvedId"><see cref="int"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/></param>
        /// <returns><see cref="Task"/> of <see cref="IActionResult"/></returns>
        [HttpDelete("Peoples/{peoplesId:int}/Parties/{partiesInvolvedId:int}", Name = REMOVE_PARTIES_BY_ID_CONST)]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.OK, typeof(ApiDefaultResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.NotFound, typeof(ApiErrorResponse))]
        [NSwag.Annotations.SwaggerResponse(HttpStatusCode.BadRequest, typeof(ApiErrorResponse))]
        public virtual async Task<IActionResult> RemovePartiesAsync(int peoplesId, int partiesInvolvedId, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (Logger.Perfs())
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest(Helper.FormatModelStateError(ModelState));
                    }
                    await APIService.RemovePartiesAsync(peoplesId, partiesInvolvedId, cancellationToken);
                    return Ok(Helper.FormatDefaultResponse(true,"Resource removed", $"Resource Parties removed from her parent."));
                }
                catch (APIObjNotFoundException e)
                {
                    return NotFound(Helper.FormatExceptionError(e));
                }
                catch (Exception e)
                {
                    return BadRequest(Helper.FormatExceptionError(e));
                }
            }
        }

        /// <summary>
        /// Checking that id from item and given ids are the same
        /// </summary>
        /// <param name="peoplesId"><see cref="int"/></param>
        /// <param name="item">Item to check</param>
        /// <returns>bool</returns>
        private bool CheckIds(int peoplesId, PeoplesV1Simple item)
        {
            return peoplesId == item.Id;
        }
    }
}

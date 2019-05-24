
using System;
using System.Linq.Expressions;
using PartyOrganiser.DataLayer.Modelers.Abstracts;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace PartyOrganiser.DataLayer.Abstracts
{
	public partial interface IPeopleDao
	{
		/// <summary>   
		/// Construit une grappe d'include compilée à partir d'une linq expression sur le bo.
		/// S'utilise pour optimiser la construction de grappes d'includes
		/// Ex : entite1 => entite1.Include(e1 => e1.navigation)
		/// </summary>
		/// <param name="includesExpr">la linq expression représentant la grappe d'include</param>
		/// <returns>la grappe compilée</returns>
		IIncludeManager<PartyOrganiser.BusinessObjects.People, PartyOrganiser.DataObjects.People> BuildIncludes(Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>,object> includesExpr);

		Task<bool> ExistAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes, CancellationToken cancellationToken = default(CancellationToken));
		
		Task<bool> ExistAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> GetOneAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes, Expression<Func<IOrderByQueryable<PartyOrganiser.DataObjects.People>,object>> orderByClauses = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> GetOneAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes = null, IOrderByManager<PartyOrganiser.DataObjects.People> orderByManager = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<IList<PartyOrganiser.BusinessObjects.People>> GetManyAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes =null, Expression<Func<IOrderByQueryable<PartyOrganiser.DataObjects.People>,object>> orderByClauses = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<IList<PartyOrganiser.BusinessObjects.People>> GetManyAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, IOrderByManager<PartyOrganiser.DataObjects.People> orderByManager = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PaginateResult<PartyOrganiser.BusinessObjects.People>> GetManyWithPaginateAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, int offset, int limit, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, Expression<Func<IOrderByQueryable<PartyOrganiser.DataObjects.People>,object>> orderByClauses = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PaginateResult<PartyOrganiser.BusinessObjects.People>> GetManyWithPaginateAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, int offset, int limit, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, IOrderByManager<PartyOrganiser.DataObjects.People> orderByManager = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<IList<PartyOrganiser.BusinessObjects.People>> GetAllAsync(Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, Expression<Func<IOrderByQueryable<PartyOrganiser.DataObjects.People>,object>> orderByClauses = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<IList<PartyOrganiser.BusinessObjects.People>> GetAllAsync(IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, IOrderByManager<PartyOrganiser.DataObjects.People> orderByManager = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> SaveAsync(PartyOrganiser.BusinessObjects.People entity, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> SaveAsync(PartyOrganiser.BusinessObjects.People entity, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> CreateAsync(PartyOrganiser.BusinessObjects.People entity, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task<PartyOrganiser.BusinessObjects.People> CreateAsync(PartyOrganiser.BusinessObjects.People entity, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));
   
		Task EntityDeleteAsync(PartyOrganiser.BusinessObjects.People entity, CancellationToken cancellationToken = default(CancellationToken));

		Task DeleteAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, CancellationToken cancellationToken = default(CancellationToken));

		Task EntityDeleteCascadeAsync(PartyOrganiser.BusinessObjects.People entity, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task EntityDeleteCascadeAsync(PartyOrganiser.BusinessObjects.People entity, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));

		Task DeleteCascadeAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task DeleteCascadeAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));

		Task EntityDeleteAllAsync(PartyOrganiser.BusinessObjects.People entity, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes= null, CancellationToken cancellationToken = default(CancellationToken));
		
		Task EntityDeleteAllAsync(PartyOrganiser.BusinessObjects.People entity, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));

		Task DeleteAllAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, Func<IIncludeModeler<PartyOrganiser.BusinessObjects.People>, object> includes = null, CancellationToken cancellationToken = default(CancellationToken));

		Task DeleteAllAsync(Expression<Func<PartyOrganiser.DataObjects.People,bool>> whereClause, IIncludeModeler<PartyOrganiser.BusinessObjects.People> includes, CancellationToken cancellationToken = default(CancellationToken));
	}
}

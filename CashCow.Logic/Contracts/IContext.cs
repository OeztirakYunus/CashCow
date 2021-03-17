using CashCow.Contracts;
using CashCow.Logic.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCow.Logic.Contracts
{
    internal interface IContext : IDisposable
    {
		DbSet<E> Set<C, E>()
	where C : IIdentifiable
	where E : Identity, C;

		Task<int> CountAsync<C, E>()
			where C : IIdentifiable
			where E : Identity, C;

		Task<int> CountByAsync<C, E>(string predicate)
			where C : IIdentifiable
			where E : Identity, C;

		Task<E> GetByIdAsync<C, E>(int id)
			where C : IIdentifiable
			where E : Identity, C;

		Task<IEnumerable<E>> GetAllAsync<C, E>()
			where C : IIdentifiable
			where E : Identity, C;

		Task<IEnumerable<E>> QueryAllAsync<C, E>(string predicate)
			where C : IIdentifiable
			where E : Identity, C;

		Task<E> InsertAsync<C, E>(E entity)
			where C : IIdentifiable
			where E : Identity, C;

		Task<E> UpdateAsync<C, E>(E entity)
			where C : IIdentifiable
			where E : Identity, C;

		Task DeleteAsync<C, E>(int id)
			where C : IIdentifiable
			where E : Identity, C;

		Task<int> SaveChangesAsync();
	}
}

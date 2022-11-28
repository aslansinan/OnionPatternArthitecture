using OnionPatternDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern.Application.Interface.Repository
{
    public interface IGenericRepositoryAsync<T> where T : BaseEntity
    {
        Task<List<T>> GerAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
    }
}

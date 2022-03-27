using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UdemyRealWorldUnitTest.Web.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}

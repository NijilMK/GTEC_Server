using DataAccessLayer;
using System.Linq.Expressions;

namespace  Repository
{
    public interface IGenericBaseRepository<T> where T : Base
    {
        IQueryable<T> GetAll();
        IEnumerable<T> GetAllEnu();
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Insert(T obj);
        void ExecuteSqlRaw(string qry);
        void Update(T obj);
        void Delete(object id);
        void start();
        void Save();
        List<T> Execute(string qry);
        void DeleteAll(FormattableString qry);
        Task SaveAsync();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        IQueryable<T> Filter(Expression<Func<T, bool>> filter = null, int skip = 0, int take = int.MaxValue, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                          IList<string> incudes = null);
    }
}

using DataAccessLayer;
using Microsoft.EntityFrameworkCore;  
using System.Linq.Expressions;

namespace Repository
{
    public class GenericBaseRepository<T> : IGenericBaseRepository<T> where T : Base
    {
        private ApplicationDBContext _context = null;
        private DbSet<T> table = null;

        public GenericBaseRepository()
        {
            table = _context.Set<T>();
        }
        public void start()
        {
            _context.Database.BeginTransaction();
        }
        public GenericBaseRepository(ApplicationDBContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return table.AsQueryable().Where(x => x.IsDeleted == false);
        }
        public IEnumerable<T> GetAllEnu()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }
        public async Task<T> GetByIdAsync(object id)
        {
            return await table.FindAsync(id);
        }
        public void Insert(T obj)
        {
            //obj.MainId = Guid.NewGuid();
            //obj.CreatedDate = DateTime.Now;
            //obj.UpdatedDate = obj.CreatedDate;
            //table.Add(obj);
        }

        public void Update(T obj)
        {
            //obj.UpdatedDate = DateTime.Now;
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public virtual IQueryable<T> Filter(Expression<Func<T, bool>> filter = null,
                                               int skip = 0,
                                               int take = int.MaxValue,
                                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                               IList<string> incudes = null)
        {
            var _resetSet = filter != null ? table.AsNoTracking().Where(filter).AsQueryable() : table.AsNoTracking().AsQueryable();

            if (incudes != null)
            {
                foreach (var incude in incudes)
                {
                    _resetSet = _resetSet.Include(incude);
                }
            }
            if (orderBy != null)
            {
                _resetSet = orderBy(_resetSet).AsQueryable();
            }
            _resetSet = skip == 0 ? _resetSet.Take(take) : _resetSet.Skip(skip).Take(take);

            return _resetSet.AsQueryable().Where(x => x.IsDeleted == false);
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public List<T> Execute(string qry)
        {
            return _context.Set<T>().FromSqlRaw(qry).ToList();
        }
        public void ExecuteSqlRaw(string qry)
        {
            _context.Database.ExecuteSqlRaw(qry);
        }
        public void DeleteAll(FormattableString qry)
        {
            _context.Database.ExecuteSql(qry);
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

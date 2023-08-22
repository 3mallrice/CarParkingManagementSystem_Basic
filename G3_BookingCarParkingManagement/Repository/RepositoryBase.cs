using DataObject.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly BookingCarParkingManagementContext _context;
        protected readonly DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new BookingCarParkingManagementContext();
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
            return true;
        }
    }
}
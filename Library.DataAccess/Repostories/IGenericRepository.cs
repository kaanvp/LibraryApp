using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.DataAccess.Context;
using Library.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Library.DataAccess.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T Get(int id);
        T GetBySearch(string entity);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
	}

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly LibraryContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(LibraryContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll() => _dbSet.ToList();

        public T Get(int id) => _dbSet.Find(id);

        public T GetBySearch(string entity) => _dbSet.FirstOrDefault(); // Örnek

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}

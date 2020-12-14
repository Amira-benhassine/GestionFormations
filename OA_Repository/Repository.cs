using Microsoft.EntityFrameworkCore;
using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OA_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly GestionPlanFormationsContext _context;
        private readonly DbSet<T> entity;

        public Repository(GestionPlanFormationsContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }

        void IRepository<T>.Add(T t)
        {
             entity.Add(t);
        }

        void IRepository<T>.Delete(T t)
        {
            entity.Remove(t);
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return entity.AsEnumerable();
        }

        T IRepository<T>.GetById(int id)
        {
            return entity.FirstOrDefault(x => x.Id == id);
        }

        void IRepository<T>.Update(T t)
        {
            entity.Update(t);
        }
    }
}

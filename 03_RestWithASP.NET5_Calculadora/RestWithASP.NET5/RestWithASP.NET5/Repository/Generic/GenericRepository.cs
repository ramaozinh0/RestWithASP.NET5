using Microsoft.EntityFrameworkCore;
using RestWithASP.NET5.Model;
using RestWithASP.NET5.Model.Base;
using RestWithASP.NET5.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASP.NET5.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private MySqlContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySqlContext context)
        {
            _context = context;
            dataset = _context.Set<T>();
        }
        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id == id);
            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id == id);
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id == id);
        }

        public T Update(T item)
        {

            var result = dataset.SingleOrDefault(p => p.Id == item.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            else
            {
                return null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWHelper.Infrastructure.DbLayer;
using GWHelper.Infrastructure.Models;
using GWHelper.Infrastructure.Services.Interfaces;

namespace GWHelper.Infrastructure.Services
{
    public class DbService<T> : IDbService<T> where T : class
    {
        public void AddItem(T item)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                dbSet.Add(item);
                context.SaveChanges();
            }
        }

        public T GetItem(string id)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                return dbSet.First(x => (x as BaseStringEntity).id.Equals(id));
            }
        }

        public T GetItem(int id)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                return dbSet.First(x => (x as BaseIntEntity).id.Equals(id));
            }
        }

        public void RemoveItem(string id)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                var items = dbSet.Where(x => (x as BaseStringEntity).id.Equals(id));
                foreach (var item in items)
                    dbSet.Remove(item);
                context.SaveChanges();
            }
        }

        public void RemoveItem(int id)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                var items = dbSet.Where(x => (x as BaseIntEntity).id.Equals(id));
                foreach (var item in items)
                    dbSet.Remove(item);
                context.SaveChanges();
            }
        }

        public void UpdateItem(T item)
        {
            using (var context = new GwContext())
            {
                var dbSet = context.Set<T>();
                dbSet.AddOrUpdate(item);
                context.SaveChanges();
            }
        }
    }
}

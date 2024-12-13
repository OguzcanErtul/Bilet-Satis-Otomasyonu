using BiletSatis.AddDatabase;
using BiletSatis.DataServices.Interfaces;
using BiletSatis.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.DataServices.Concretes
{
    public class BaseDataService<T> : IBaseDataService<T> where T : BaseEntity
    {
        public T Add(T entity)
        {
            var entry = AplicationDatabase.Context.Set<T>().Add(entity);
            AplicationDatabase.Context.SaveChanges();
            return entry.Entity;

        
        }

        public List<T> GetAll(bool tracking = false)
        {
            if (!tracking)
            {
                return AplicationDatabase.Context.Set<T>().Where(x=> x.Status != Enum.Status.Deleted).AsNoTracking().ToList();

            }
            return AplicationDatabase.Context.Set<T>().Where(x => x.Status != Enum.Status.Deleted).ToList();
        }

        public T GetById(Guid id, bool tracking = false)
        {
            if (!tracking)
            {
                return AplicationDatabase.Context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id && x.Status!=Enum.Status.Deleted);
                
            }
            return AplicationDatabase.Context.Set<T>().FirstOrDefault(x => x.Id == id && x.Status != Enum.Status.Deleted);
        }

        public void Remove(Guid id)
        {
            var deletedEntity = GetById(id);
            var entry = AplicationDatabase.Context.Set<T>().Remove(deletedEntity);
            AplicationDatabase.Context.SaveChanges();   

        }

        public T Update(T entity)
        {
            var entry = AplicationDatabase.Context.Set<T>().Update(entity);
            AplicationDatabase.Context.SaveChanges();
            return entry.Entity;
        }
    }
}

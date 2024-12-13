using BiletSatis.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiletSatis.DataServices.Interfaces
{
   public interface IBaseDataService<T> where T : BaseEntity
    {
        T GetById(Guid id, bool tracking = false);
        T Add(T entity);
        T Update(T entity);
        void Remove(Guid id);
        List<T> GetAll(bool tracking = false);

    }
}

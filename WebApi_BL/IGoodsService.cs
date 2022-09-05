using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_DAL.Entities;

namespace WebApi_BL
{
    public interface IGoodsService
    {
        Task<IEnumerable<Good>> GetAll();
        Task<Good> GetById(Guid id);
        Task<Good> DeleteById(Guid id);
        Task<Good> UpdateById(Guid id, Good good);
        Task<Good> Create(Good good);
    }
}

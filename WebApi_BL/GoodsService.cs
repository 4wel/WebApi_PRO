using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DAL;
using WebApi_DAL.Entities;

namespace WebApi_BL
{
    public class GoodsService : IGoodsService
    {
        private readonly IGoodsRepository _goodsRepository;

        public GoodsService(IGoodsRepository goodsRepository)
        {
            _goodsRepository = goodsRepository;
        }

        public Task<Good> Create(Good good)
        {
            return _goodsRepository.Create(good);
        }

        public Task<Good> DeleteById(Guid id)
        {
            return _goodsRepository.DeleteById(id);
        }

        public Task<IEnumerable<Good>> GetAll()
        {
            return _goodsRepository.GetAll();
        }

        public Task<Good> GetById(Guid id)
        {
            return _goodsRepository.GetById(id);
        }

        public Task<Good> UpdateById(Guid id, Good good)
        {
            return _goodsRepository.UpdateById(id, good);
        }
    }
}

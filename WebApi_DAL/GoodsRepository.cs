using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_DAL.Entities;

namespace WebApi_DAL
{
    public class GoodsRepository : IGoodsRepository
    {
        private readonly GWContext _dbContext;

        public GoodsRepository(GWContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Good> Create(Good good)
        {
            _dbContext.Add(good);
            await _dbContext.SaveChangesAsync();

            return good;
        }

        public Task<Good> DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Good>> GetAll()
        {
            return await _dbContext.Goods.ToListAsync();
        }

        public Task<Good> GetById(Guid id)
        {
            return _dbContext.Goods.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Good> UpdateById(Guid id, Good good)
        {
            good.Id = id;
            //_dbContext.Attach(good);
            _dbContext.Entry(good).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();

            return good;
        }
    }
}

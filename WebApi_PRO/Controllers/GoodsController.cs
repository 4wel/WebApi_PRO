using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApi_BL;
using WebApi_DAL.Entities;

namespace WebApi_PRO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsController : ControllerBase
    {
        private readonly IGoodsService _goodsService;

        public GoodsController(IGoodsService goodsService)
        {
            _goodsService = goodsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var goods = await _goodsService.GetAll();

            return Ok(goods);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var good = await _goodsService.GetById(id);

            return good != null ? Ok(good) : NotFound();
        } 

        [HttpDelete]
        public async Task<IActionResult> DeleteById(Guid id)
        {
            var goods = await _goodsService.DeleteById(id);

            return Ok(goods);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Good good)
        {
            var goods = await _goodsService.Create(good);

            return Ok(good);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateById(Guid id, Good good)
        {
            var goods = await _goodsService.UpdateById(id, good);

            return Ok(good);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebApi_BL;

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
    }
}

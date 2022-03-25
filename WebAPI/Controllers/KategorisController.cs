using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KategorisController : ControllerBase
    {
        IKategoriService _kategoriService;
        public KategorisController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kategoriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _kategoriService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Kategori kategori)
        {
            var result = _kategoriService.Add(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Kategori kategori)
        {
            var result = _kategoriService.Delete(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Kategori kategori)
        {
            var result = _kategoriService.Update(kategori);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

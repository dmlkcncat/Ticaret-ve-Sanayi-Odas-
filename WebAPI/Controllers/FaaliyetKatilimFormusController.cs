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
    public class FaaliyetKatilimFormusController : ControllerBase
    {
        IFaaliyetKatilimFormuService _fkfService;
        public FaaliyetKatilimFormusController(IFaaliyetKatilimFormuService fkfService)
        {
            _fkfService = fkfService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fkfService.GetAll();
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
            var result = _fkfService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            var result = _fkfService.Add(faaliyetKalitimFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            var result = _fkfService.Delete(faaliyetKalitimFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("update")]
        public IActionResult Update(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            var result = _fkfService.Update(faaliyetKalitimFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }


}

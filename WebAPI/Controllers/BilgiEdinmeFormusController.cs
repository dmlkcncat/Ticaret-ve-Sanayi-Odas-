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
    public class BilgiEdinmeFormusController : ControllerBase
    {
        IBilgiEdinmeFormuService _bilgiEdinmeService;
        public BilgiEdinmeFormusController(IBilgiEdinmeFormuService bilgiEdinmeService)
        {
            _bilgiEdinmeService = bilgiEdinmeService;
        }
        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bilgiEdinmeService.GetAll();
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
            var result = _bilgiEdinmeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            var result = _bilgiEdinmeService.Add(bilgiEdinmeFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            var result = _bilgiEdinmeService.Delete(bilgiEdinmeFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            var result = _bilgiEdinmeService.Update(bilgiEdinmeFormu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

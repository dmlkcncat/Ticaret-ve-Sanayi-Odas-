using Business.Abstract;
using Core.Services;
using Entities.Concrete;
using Entities.DTOs;
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
    public class HizmetlersController : ControllerBase
    {
        IHizmetlerService _hizmetlerService;
        public HizmetlersController(IHizmetlerService hizmetlerService)
        {
            _hizmetlerService = hizmetlerService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hizmetlerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetHizmetlerDetails()
        {
            var result = _hizmetlerService.GetHizmetlerDetails();
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
            var result = _hizmetlerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Hizmetler hizmetler)
        {
            var result = _hizmetlerService.Add(hizmetler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Hizmetler hizmetler)
        {
            var result = _hizmetlerService.Delete(hizmetler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _hizmetlerService.DeleteDto(new HizmetlerDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Hizmetler hizmetler)
        {
            var result = _hizmetlerService.Update(hizmetler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

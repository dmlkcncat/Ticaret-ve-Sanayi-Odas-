using Business.Abstract;
using Core.Services;
using Core.Utilities.Results;
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
    public class EtkinliklersController : ControllerBase
    {
        IEtkinliklerService _etkinliklerService;
        public EtkinliklersController(IEtkinliklerService etkinliklerService)
        {
            _etkinliklerService = etkinliklerService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _etkinliklerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //[HttpGet("getdetails")]
        //public IActionResult GetEtkinliklerDetails()
        //{
        //    var result = _etkinliklerService.GetEtkinliklerDetails();
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}

        [AllowAnonymous]
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _etkinliklerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Etkinlikler etkinlikler)
        {
            var result = _etkinliklerService.Add(etkinlikler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddDto(
            IFormFile image,
            List<IFormFile> files,
            List<IFormFile> images,
            [FromForm] EtkinliklerDto etkinliklerDto)
        {
            IResult result = await _etkinliklerService.AddDto(etkinliklerDto, image, files, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Etkinlikler etkinlikler)
        {
            var result = _etkinliklerService.Delete(etkinlikler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _etkinliklerService.DeleteDto(new EtkinliklerDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Etkinlikler etkinlikler)
        {
            var result = _etkinliklerService.Update(etkinlikler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

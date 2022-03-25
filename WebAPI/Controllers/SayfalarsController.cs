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
    public class SayfalarsController : ControllerBase
    {
        ISayfalarService _sayfalarService;
        public SayfalarsController(ISayfalarService sayfalarService)
        {
            _sayfalarService = sayfalarService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sayfalarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetSayfalarDetails()
        {
            var result = _sayfalarService.GetSayfalarDetails();
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
            var result = _sayfalarService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Sayfalar sayfalar)
        {
            var result = _sayfalarService.Add(sayfalar);
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
            [FromForm] SayfalarDto sayfalarDto
        )
        {
            IResult result = await _sayfalarService.AddDto(sayfalarDto, image, files, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Sayfalar sayfalar)
        {
            var result = _sayfalarService.Delete(sayfalar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _sayfalarService.DeleteDto(new SayfalarDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Sayfalar sayfalar)
        {
            var result = _sayfalarService.Update(sayfalar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

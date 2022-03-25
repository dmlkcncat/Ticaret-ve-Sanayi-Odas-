using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class HaberlersController : ControllerBase
    {
        IHaberlerService _haberlerService;
        IIceriklerService _iceriklerService;
        public HaberlersController(IHaberlerService haberlerService, IIceriklerService iceriklerService)
        {
            _haberlerService = haberlerService;
            _iceriklerService = iceriklerService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _haberlerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
            var result = _haberlerService.GetDetails();
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
            var result = _haberlerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Haberler haberler)
        {
            var result = _haberlerService.Add(haberler);
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
            [FromForm] HaberlerDto haberlerDto
        )
        {
            IResult result = await _haberlerService.AddDto(haberlerDto, image, files, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(Haberler haberler)
        {
            var result = _haberlerService.Delete(haberler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpDelete("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _haberlerService.DeleteDto(new HaberlerDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Haberler haberler)
        {
            var result = _haberlerService.Update(haberler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

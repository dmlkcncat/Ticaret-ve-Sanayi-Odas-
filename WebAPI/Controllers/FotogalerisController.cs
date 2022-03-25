
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
    public class FotogalerisController : ControllerBase
    {
        IFotogaleriService _fotogaleriService;
        public FotogalerisController(IFotogaleriService fotogaleriService)
        {
            _fotogaleriService = fotogaleriService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fotogaleriService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetFotogaleriDetails()
        {
            var result = _fotogaleriService.GetFotogaleriDetails();
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
            var result = _fotogaleriService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Fotogaleri fotogaleri)
        {
            var result = _fotogaleriService.Add(fotogaleri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddDto(
             List<IFormFile> images,
             [FromForm] FotogaleriDto fotogaleriDto)
        {

            IResult result = await _fotogaleriService.AddDto(fotogaleriDto, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Fotogaleri fotogaleri)
        {
            var result = _fotogaleriService.Delete(fotogaleri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _fotogaleriService.DeleteDto(new FotogaleriDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Fotogaleri fotogaleri)
        {
            var result = _fotogaleriService.Update(fotogaleri);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

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
    public class Icerik_ResimlersController : ControllerBase
    {

        IIcerik_ResimlerService _icerikResimlerService;
        public Icerik_ResimlersController(IIcerik_ResimlerService icerikResimlerService)
        {
            _icerikResimlerService = icerikResimlerService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _icerikResimlerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetIcerikResimlerDetails()
        {
            var result = _icerikResimlerService.GetIcerikResimlerDetails();
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
            var result = _icerikResimlerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Icerik_Resimler icerikResimler)
        {
            var result = _icerikResimlerService.Add(icerikResimler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        public async Task<IActionResult> AddDto(
              IFormFile file,
            [FromForm] Icerik_ResimlerDto icerik_ResimlerDto)
        {
            string uploadedFilePath = await FileService.UploadFile(file);
            if (uploadedFilePath != null)
            {
                icerik_ResimlerDto.Resim_Dizin = uploadedFilePath;
                icerik_ResimlerDto.Tarih = DateTime.Now;
                var result = _icerikResimlerService.AddDto(icerik_ResimlerDto);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Icerik_Resimler icerikResimler)
        {
            var result = _icerikResimlerService.Delete(icerikResimler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(Icerik_ResimlerDto icerikResimlerDto)
        {
            var result = _icerikResimlerService.DeleteDto(icerikResimlerDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Icerik_Resimler icerikResimler)
        {
            var result = _icerikResimlerService.Update(icerikResimler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

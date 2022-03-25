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
    public class Icerik_DosyalarsController : ControllerBase
    {
        IIcerik_DosyalarService _icerikDosyalarService;
        public Icerik_DosyalarsController(IIcerik_DosyalarService icerikDosyalarService)
        {
            _icerikDosyalarService = icerikDosyalarService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _icerikDosyalarService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetIcerikDosyalarDetails()
        {
            var result = _icerikDosyalarService.GetIcerikDosyalarDetails();
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
            var result = _icerikDosyalarService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Icerik_Dosyalar icerikDosyalar)
        {
            var result = _icerikDosyalarService.Add(icerikDosyalar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        public async Task<IActionResult> AddDto(
             IFormFile file,
             [FromForm] Icerik_DosyalarDto icerik_DosyalarDto)
        {

            string uploadedFilePath = await FileService.UploadFile(file);
            if (uploadedFilePath != null)
            {
                icerik_DosyalarDto.Resim_Dizin = uploadedFilePath;
                icerik_DosyalarDto.Tarih = DateTime.Now;
                var result = _icerikDosyalarService.AddDto(icerik_DosyalarDto);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Icerik_Dosyalar icerikDosyalar)
        {
            var result = _icerikDosyalarService.Delete(icerikDosyalar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(Icerik_DosyalarDto icerikDosyalarDto)
        {
            var result = _icerikDosyalarService.DeleteDto(icerikDosyalarDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Icerik_Dosyalar icerikDosyalar)
        {
            var result = _icerikDosyalarService.Update(icerikDosyalar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

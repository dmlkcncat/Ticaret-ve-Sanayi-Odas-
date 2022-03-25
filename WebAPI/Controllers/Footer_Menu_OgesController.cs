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
    public class Footer_Menu_OgesController : ControllerBase
    {
        IFooter_Menu_OgeService _footerMenuOgeService;
        public Footer_Menu_OgesController(IFooter_Menu_OgeService footerMenuOgeService)
        {
            _footerMenuOgeService = footerMenuOgeService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _footerMenuOgeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetFooter_Menu_OgeDetails()
        {
            var result = _footerMenuOgeService.GetFooter_Menu_OgeDetails();
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
            var result = _footerMenuOgeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Footer_Menu_Oge footer_Menu_Oge)
        {
            var result = _footerMenuOgeService.Add(footer_Menu_Oge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        public async Task<IActionResult> AddDto(
            IFormFile file,
            [FromForm] Footer_Menu_OgeDto footerMenuOgeDto)
        {
            string uploadedFilePath = await FileService.UploadFile(file);
            if (uploadedFilePath != null)
            {
                footerMenuOgeDto.Resim_Dizin = uploadedFilePath;
                footerMenuOgeDto.Tarih = DateTime.Now;
                var result = _footerMenuOgeService.AddDto(footerMenuOgeDto);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Footer_Menu_Oge footer_Menu_Oge)
        {
            var result = _footerMenuOgeService.Delete(footer_Menu_Oge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(Footer_Menu_OgeDto footer_Menu_OgeDto)
        {
            var result = _footerMenuOgeService.DeleteDto(footer_Menu_OgeDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Footer_Menu_Oge footer_Menu_Oge)
        {
            var result = _footerMenuOgeService.Update(footer_Menu_Oge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
}
}

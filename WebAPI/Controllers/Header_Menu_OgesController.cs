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
    public class Header_Menu_OgesController : ControllerBase
    {
        IHeader_Menu_OgeService _headerMenuOgeService;
        public Header_Menu_OgesController(IHeader_Menu_OgeService headerMenuOgeService)
        {
            _headerMenuOgeService = headerMenuOgeService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _headerMenuOgeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetHeader_Menu_OgeDetails()
        {
            var result = _headerMenuOgeService.GetHeader_Menu_OgeDetails();
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
            var result = _headerMenuOgeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Header_Menu_Oge headerMenuOge)
        {
            var result = _headerMenuOgeService.Add(headerMenuOge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        public async Task<IActionResult> AddDto(
            IFormFile file,
            [FromForm] Header_Menu_OgeDto headerMenuOgeDto)
        {
            string uploadedFilePath = await FileService.UploadFile(file);
            if (uploadedFilePath != null)
            {
                headerMenuOgeDto.Resim_Dizin = uploadedFilePath;
                headerMenuOgeDto.Tarih = DateTime.Now;
                var result = _headerMenuOgeService.AddDto(headerMenuOgeDto);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(Header_Menu_Oge headerMenuOge)
        {
            var result = _headerMenuOgeService.Delete(headerMenuOge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _headerMenuOgeService.DeleteDto(new Header_Menu_OgeDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Header_Menu_Oge headerMenuOge)
        {
            var result = _headerMenuOgeService.Update(headerMenuOge);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

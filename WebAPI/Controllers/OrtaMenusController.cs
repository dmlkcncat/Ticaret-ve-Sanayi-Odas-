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
    public class OrtaMenusController : ControllerBase
    {
        IOrtaMenuService _ortaMenuService;
        public OrtaMenusController(IOrtaMenuService ortaMenuService)
        {
            _ortaMenuService = ortaMenuService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ortaMenuService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [AllowAnonymous]
        [HttpGet("getdetails")]
        public IActionResult GetOrtaMenuDetails()
        {
            var result = _ortaMenuService.GetOrtaMenuDetails();
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
            var result = _ortaMenuService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(OrtaMenu ortaMenu)
        {
            var result = _ortaMenuService.Add(ortaMenu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addDto")]
        public async Task<IActionResult> AddDto(
            IFormFile file,
            [FromForm] OrtaMenuDto ortaMenuDto)
        {
            string uploadedFilePath = await FileService.UploadFile(file);
            if (uploadedFilePath != null)
            {
                ortaMenuDto.Resim_Dizin = uploadedFilePath;
                var result = _ortaMenuService.AddDto(ortaMenuDto);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }
            return BadRequest();
        }

        [HttpPost("delete")]
        public IActionResult Delete(OrtaMenu ortaMenu)
        {
            var result = _ortaMenuService.Delete(ortaMenu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _ortaMenuService.DeleteDto(new OrtaMenuDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(OrtaMenu ortaMenu)
        {
            var result = _ortaMenuService.Update(ortaMenu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

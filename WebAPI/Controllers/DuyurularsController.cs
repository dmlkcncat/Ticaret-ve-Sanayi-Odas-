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
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DuyurularsController : ControllerBase
    {
        IDuyurularService _duyurularService;
        public DuyurularsController(IDuyurularService duyurularService)
        {
            _duyurularService = duyurularService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _duyurularService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //[HttpGet("getdetails")]
        //public IActionResult GetDuyurularDetails(int count, Expression<Func<DuyurularDto, dynamic>> orderKeySelector, Expression<Func<DuyurularDto, bool>> filter = null)
        //{
        //    var result = _duyurularService.GetDuyurularDetails(count, orderKeySelector, filter);
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
            var result = _duyurularService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Duyurular duyurular)
        {
            var result = _duyurularService.Add(duyurular);
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
            [FromForm] DuyurularDto duyurularDto)
        {
            IResult result = await _duyurularService.AddDto(duyurularDto, image, files, images);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Duyurular duyurular)
        {
            var result = _duyurularService.Delete(duyurular);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _duyurularService.DeleteDto(new DuyurularDto() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Duyurular duyurular)
        {
            var result = _duyurularService.Update(duyurular);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}

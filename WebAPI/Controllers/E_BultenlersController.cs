using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
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
    public class E_BultenlersController : ControllerBase
    {
        IE_BultenlerService _eBultenlerService;
        public E_BultenlersController(IE_BultenlerService eBultenlerService)
        {
            _eBultenlerService = eBultenlerService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _eBultenlerService.GetAll();
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
            var result = _eBultenlerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(E_Bultenler eBultenler)
        {
            var result = _eBultenlerService.Add(eBultenler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addWithImage")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> AddDto(
           IFormFile image,
           [FromForm] E_Bultenler eBultenler)
        {
            IResult result = await _eBultenlerService.AddWithImage(eBultenler, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(E_Bultenler eBultenler)
        {
            var result = _eBultenlerService.Delete(eBultenler);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _eBultenlerService.DeleteDto(new E_Bultenler() { Id = id });
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("update"), AllowAnonymous]
        //public async IActionResult Update(E_Bultenler eBultenler, IFormFile image = null)
        //{
        //    var result = await _eBultenlerService.Update(eBultenler, image);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}
    }
}

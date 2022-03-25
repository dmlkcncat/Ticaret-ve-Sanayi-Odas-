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
    public class ReferanslarsController : ControllerBase
    {
        IReferanslarService _referanslarService;
        public ReferanslarsController(IReferanslarService referanslarService)
        {
            _referanslarService = referanslarService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _referanslarService.GetAll();
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
            var result = _referanslarService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Referanslar referanslar)
        {
            var result = _referanslarService.Add(referanslar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Referanslar referanslar)
        {
            var result = _referanslarService.Delete(referanslar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteDto")]
        public IActionResult DeleteDto(int id)
        {
            var result = _referanslarService.DeleteDto(new Referanslar() { Id = id });
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
        [FromForm] Referanslar referanslar)
        {
            IResult result = await _referanslarService.AddWithImage(referanslar, image);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Referanslar referanslar)
        {
            var result = _referanslarService.Update(referanslar);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

using Business.Abstract;
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
    public class Footer_Menu_BasliksController : ControllerBase
    {
        IFooter_Menu_BaslikService _footerMenuBaslikService;
        public Footer_Menu_BasliksController(IFooter_Menu_BaslikService footerMenuBaslikService)
        {
            _footerMenuBaslikService = footerMenuBaslikService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _footerMenuBaslikService.GetAll();
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
            var result = _footerMenuBaslikService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Footer_Menu_Baslik footerMenuBaslik)
        {
            var result = _footerMenuBaslikService.Add(footerMenuBaslik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Footer_Menu_Baslik footerMenuBaslik)
        {
            var result = _footerMenuBaslikService.Delete(footerMenuBaslik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Footer_Menu_Baslik footerMenuBaslik)
        {
            var result = _footerMenuBaslikService.Update(footerMenuBaslik);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

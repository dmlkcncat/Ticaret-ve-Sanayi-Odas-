using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
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
    public class DashboardsController : ControllerBase
    {
        IEtkinliklerService _etkinliklerService;
        IDuyurularService _duyuruService;
        IHaberlerService _haberlerService;
        IE_BultenlerService _eBultenlerService;
        public DashboardsController(IEtkinliklerService etkinliklerService, 
            IDuyurularService duyurularService,
            IHaberlerService haberlerService,
            IE_BultenlerService ebultenlerService)
        {
            _etkinliklerService = etkinliklerService;
            _duyuruService = duyurularService;
            _haberlerService = haberlerService;
            _eBultenlerService = ebultenlerService;
        }
        [AllowAnonymous]
        [HttpGet("")]
        public IActionResult Get()
        {
            using (var context = new BartınContext())
            {
                var etkinlikcount = context.Etkinlikler.Count();
                var haberlerCount = context.Haberler.Count();
                var duyuruCount = context.Duyurular.Count();
                var ebultenlerCount = context.E_Bultenler.Count();

               
                return Ok(new
                {
                  etkinlikCount = etkinlikcount,
                  haberlerCount = haberlerCount,
                  duyurularCount = duyuruCount,
                  ebultenlerCount = ebultenlerCount
                });
            }
            
        }
    }
}

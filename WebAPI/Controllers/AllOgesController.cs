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
    public class AllOgesController : ControllerBase
    {
        IEtkinliklerService _etkinliklerService;
        IDuyurularService _duyuruService;
        IHaberlerService _haberlerService;
        IE_BultenlerService _eBultenlerService;
        ITopMenuService _topMenuService;
        IHeader_MenuService _headerMenuService;
        IHeader_Menu_OgeService _headerMenu_OgeService;
        IOrtaMenuService _ortaMenuService;
        IHizmetlerService _hizmetlerService;
        IReferanslarService _referanslarService;
        IFooter_Menu_BaslikService _footer_Menu_BaslikService;
        IFooter_Menu_OgeService _footer_Menu_OgeService;
        IModalService _modalService;

        public AllOgesController(IEtkinliklerService etkinliklerService,
            IDuyurularService duyurularService,
            IHaberlerService haberlerService,
            IE_BultenlerService ebultenlerService,
            ITopMenuService topMenuService,
            IHeader_MenuService header_MenuService,
            IHeader_Menu_OgeService header_Menu_OgeService,
            IOrtaMenuService ortaMenuService,
            IHizmetlerService hizmetlerService,
            IReferanslarService referanslarService,
            IFooter_Menu_BaslikService footer_Menu_BaslikService,
            IFooter_Menu_OgeService footer_Menu_OgeService,
            IModalService modalService
            )
        {
            _etkinliklerService = etkinliklerService;
            _duyuruService = duyurularService;
            _haberlerService = haberlerService;
            _eBultenlerService = ebultenlerService;
            _topMenuService = topMenuService;
            _headerMenuService = header_MenuService;
            _headerMenu_OgeService = header_Menu_OgeService;
            _ortaMenuService = ortaMenuService;
            _hizmetlerService = hizmetlerService;
            _referanslarService = referanslarService;
            _footer_Menu_BaslikService = footer_Menu_BaslikService;
            _footer_Menu_OgeService = footer_Menu_OgeService;
            _modalService = modalService;
        }
        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult Get()
        {
            using (var context = new BartınContext())
            {
                return Ok(new
                {
                    etkinliklers = _etkinliklerService.GetEtkinliklerDetails(12, x => x.Id),
                    haberlers = _haberlerService.GetHaberlerDetails(15, x => x.Id),
                    duyurulars = _duyuruService.GetDuyurularDetails(12, x => x.Id),
                    ebultenlers = _eBultenlerService.Take(16, x => x.Id),
                    topMenulers = _topMenuService.Take(5, x => x.Id, x => x.Aktiflik),
                    headerMenus = _headerMenuService.Take(655, x => x.Id),
                    headerMenusOges = _headerMenu_OgeService.GetAll(),
                    ortaMenus = _ortaMenuService.GetOrtaMenuDetails(x => x.Aktiflik),
                    hizmetlers = _hizmetlerService.GetAll(),
                    referanslars = _referanslarService.GetAll(),
                    footerMenuBasliks = _footer_Menu_BaslikService.GetAll(),
                    FooterMenuOges = _footer_Menu_OgeService.GetAll(),
                    modals = _modalService.GetAll(x => x.Aktiflik)
                }); 
            }
        }
    }
}

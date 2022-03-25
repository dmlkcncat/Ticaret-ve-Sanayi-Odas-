using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFooter_Menu_OgeService
    {
        IDataResult<List<Footer_Menu_Oge>> GetAll();
        IDataResult<Footer_Menu_Oge> GetById(int footerMenuOgeId);
        IDataResult<List<Footer_Menu_OgeDto>> GetFooter_Menu_OgeDetails();
        IResult AddDto(Footer_Menu_OgeDto footer_Menu_OgeDto);
        IResult DeleteDto(Footer_Menu_OgeDto footer_Menu_OgeDto);
        IResult Add(Footer_Menu_Oge footer_Menu_Oge);
        IResult Delete(Footer_Menu_Oge footer_Menu_Oge);
        IResult Update(Footer_Menu_Oge footer_Menu_Oge);
    }
}

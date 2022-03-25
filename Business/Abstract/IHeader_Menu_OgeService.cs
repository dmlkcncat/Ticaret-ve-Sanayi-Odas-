using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHeader_Menu_OgeService
    {
        IDataResult<List<Header_Menu_Oge>> GetAll();
        IDataResult<Header_Menu_Oge> GetById(int headerMenuOgeId);
        IDataResult<List<Header_Menu_OgeDto>> GetHeader_Menu_OgeDetails();
        IResult AddDto(Header_Menu_OgeDto headerMenuOgeDto);
        IResult DeleteDto(Header_Menu_OgeDto header_Menu_OgeDto);
        IResult Add(Header_Menu_Oge headerMenuOge);
        IResult Delete(Header_Menu_Oge headerMenuOge);
        IResult Update(Header_Menu_Oge headerMenuOge);
    }
}

using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IHeader_Menu_OgeDal : IEntityRepository<Header_Menu_Oge>
    {
        List<Header_Menu_OgeDto> GetHeader_Menu_OgeDetails();
        void AddDto(Header_Menu_OgeDto header_Menu_OgeDto);
        void DeleteDto(Header_Menu_OgeDto header_Menu_OgeDto);
    }
}

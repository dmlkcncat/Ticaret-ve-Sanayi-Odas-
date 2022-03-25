using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Abstract
{
    public interface IFooter_Menu_OgeDal : IEntityRepository<Footer_Menu_Oge> 
    {
        List<Footer_Menu_OgeDto> GetFooter_Menu_OgeDetails();
        void AddDto(Footer_Menu_OgeDto footer_Menu_OgeDto);
        void DeleteDto(Footer_Menu_OgeDto footer_Menu_OgeDto);
    }
}

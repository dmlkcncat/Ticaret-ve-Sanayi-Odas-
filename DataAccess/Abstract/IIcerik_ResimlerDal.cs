using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Abstract
{
    public interface IIcerik_ResimlerDal : IEntityRepository<Icerik_Resimler> 
    {
        List<Icerik_ResimlerDto> GetIcerikResimlerDetails();
        void AddDto(Icerik_ResimlerDto icerik_resimlerDto);
        void DeleteDto(Icerik_ResimlerDto icerik_ResimlerDto);
    }
}

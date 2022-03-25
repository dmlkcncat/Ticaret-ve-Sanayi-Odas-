using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IIcerik_DosyalarDal : IEntityRepository<Icerik_Dosyalar>
    {
        List<Icerik_DosyalarDto> GetIcerikDosyalarDetails();
        void AddDto(Icerik_DosyalarDto icerik_DosyalarDto);
        void DeleteDto(Icerik_DosyalarDto icerik_DosyalarDto);

    }
}

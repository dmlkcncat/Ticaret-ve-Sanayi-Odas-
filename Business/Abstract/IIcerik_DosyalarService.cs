using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIcerik_DosyalarService
    {
        IDataResult<List<Icerik_Dosyalar>> GetAll();
        IDataResult<Icerik_Dosyalar> GetById(int icerikDosyalarId);
        IDataResult<List<Icerik_DosyalarDto>> GetIcerikDosyalarDetails();
        IResult AddDto(Icerik_DosyalarDto icerik_DosyalarDto);
        IResult DeleteDto(Icerik_DosyalarDto icerik_DosyalarDto);
        IResult Add(Icerik_Dosyalar iceriklerDosyalar);
        IResult Delete(Icerik_Dosyalar iceriklerDosyalar);
        IResult Update(Icerik_Dosyalar iceriklerDosyalar);
    }
}

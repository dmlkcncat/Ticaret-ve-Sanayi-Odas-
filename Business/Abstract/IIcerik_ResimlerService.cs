using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface IIcerik_ResimlerService
    {
        IDataResult<List<Icerik_Resimler>> GetAll();
        IDataResult<Icerik_Resimler> GetById(int icerikResimlerId);
        IDataResult<List<Icerik_ResimlerDto>> GetIcerikResimlerDetails();
        IResult AddDto(Icerik_ResimlerDto icerik_ResimlerDto);
        IResult DeleteDto(Icerik_ResimlerDto icerik_ResimlerDto);
        IResult Add(Icerik_Resimler iceriklerResimler);
        IResult Delete(Icerik_Resimler iceriklerResimler);
        IResult Update(Icerik_Resimler iceriklerResimler);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHizmetlerService
    {
        IDataResult<List<Hizmetler>> GetAll();
        IDataResult<Hizmetler> GetById(int hizmetlerId);
        IDataResult<List<HizmetlerDto>> GetHizmetlerDetails();
        IResult DeleteDto(HizmetlerDto hizmetlerDto);
        IResult Add(Hizmetler hizmetler);
        IResult Delete(Hizmetler hizmetler);
        IResult Update(Hizmetler hizmetler);
    }
}

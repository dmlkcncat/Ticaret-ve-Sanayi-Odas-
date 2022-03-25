using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IVideogaleriService
    {
        IDataResult<List<Videogaleri>> GetAll();
        IDataResult<Videogaleri> GetById(int videogaleriId);
        IResult Add(Videogaleri videogaleri);
        IResult Delete(Videogaleri videogaleri);
        IResult Update(Videogaleri videogaleri);
        IResult DeleteDto(Videogaleri videogaleri);
    }
}

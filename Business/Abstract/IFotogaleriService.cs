using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFotogaleriService
    {
        IDataResult<List<Fotogaleri>> GetAll();
        IDataResult<Fotogaleri> GetById(int fotogaleriId);
        IDataResult<List<FotogaleriDto>> GetFotogaleriDetails();
        Task<IResult> AddDto(FotogaleriDto fotogaleriDto, List<IFormFile> images);
        IResult DeleteDto(FotogaleriDto fotogaleriDto);
        IResult Add(Fotogaleri fotogaleri);
        IResult Delete(Fotogaleri fotogaleri);
        IResult Update(Fotogaleri fotogaleri);
    }
}

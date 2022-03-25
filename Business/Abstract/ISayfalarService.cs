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
    public interface ISayfalarService
    {
        IDataResult<List<Sayfalar>> GetAll();
        IDataResult<SayfalarDto> GetById(int sayfalarId);
        IDataResult<List<SayfalarDto>> GetSayfalarDetails();
        Task<IResult> AddDto(SayfalarDto sayfalarDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        IResult DeleteDto(SayfalarDto sayfalarDto);
        IResult Add(Sayfalar sayfalar);
        IResult Delete(Sayfalar sayfalar);
        IResult Update(Sayfalar sayfalar);
    }
}

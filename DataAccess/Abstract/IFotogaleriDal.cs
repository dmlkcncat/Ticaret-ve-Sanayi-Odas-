using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IFotogaleriDal : IEntityRepository<Fotogaleri>
    {
        List<FotogaleriDto> GetFotogaleriDetails();
        Task<bool> AddDto(FotogaleriDto fotogaleriDto, List<IFormFile> images);
        void DeleteDto(FotogaleriDto fotogaleriDto);
    }
}

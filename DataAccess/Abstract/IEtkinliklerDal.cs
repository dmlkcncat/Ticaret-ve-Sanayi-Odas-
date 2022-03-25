using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEtkinliklerDal : IEntityRepository<Etkinlikler>
    {
        List<EtkinliklerDto> GetEtkinliklerDetails(int count, Expression<Func<EtkinliklerDto, dynamic>> orderKeySelector, Expression<Func<EtkinliklerDto, bool>> filter = null);
        Task<bool> AddDto(EtkinliklerDto etkinliklerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        void DeleteDto(EtkinliklerDto etkinliklerDto);
        EtkinliklerDto GetById(int id);
    }
}

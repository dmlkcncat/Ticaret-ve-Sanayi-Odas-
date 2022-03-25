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
   public interface IDuyurularDal : IEntityRepository<Duyurular>
    {
        List<DuyurularDto> GetDuyurularDetails(int count, Expression<Func<DuyurularDto, dynamic>> orderKeySelector, Expression<Func<DuyurularDto, bool>> filter = null);
        Task<bool> AddDto(DuyurularDto duyurularDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        void DeleteDto(DuyurularDto duyurularDto);
        DuyurularDto GetById(int id);
    }
}

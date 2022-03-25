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
    public interface IHaberlerDal : IEntityRepository<Haberler>
    {
        List<HaberlerDto> GetHaberlerDetails(int count, Expression<Func<HaberlerDto, dynamic>> orderKeySelector, Expression<Func<HaberlerDto, bool>> filter = null);
        List<HaberlerDto> GetDetails();

        HaberlerDto GetById(int id);

        Task<bool> AddDto(HaberlerDto haberlerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        void DeleteDto(HaberlerDto haberlerDto);

    }
}

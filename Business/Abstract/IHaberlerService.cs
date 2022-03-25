using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHaberlerService
    {
        IDataResult<List<Haberler>> GetAll();
        IDataResult<List<Haberler>> Take(int count, Expression<Func<Haberler, dynamic>> orderKeySelector, Expression<Func<Haberler, bool>> filter = null);
        IDataResult<HaberlerDto> GetById(int haberlerDtoId);
        IDataResult<List<HaberlerDto>> GetHaberlerDetails(int count, Expression<Func<HaberlerDto, dynamic>> orderKeySelector, Expression<Func<HaberlerDto, bool>> filter = null);
        IDataResult<List<HaberlerDto>> GetDetails();

        IResult Add(Haberler haberler);
        Task<IResult> AddDto(HaberlerDto haberlerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        IResult DeleteDto(HaberlerDto haberlerDto);
        IResult Delete(Haberler haberler);
        IResult Update(Haberler haberler);
    }
}

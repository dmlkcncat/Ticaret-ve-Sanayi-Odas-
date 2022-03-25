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
    public interface IDuyurularService
    {
        IDataResult<List<Duyurular>> GetAll();
        IDataResult<DuyurularDto> GetById(int duyurularDtoId);
        IDataResult<List<DuyurularDto>> GetDuyurularDetails(int count, Expression<Func<DuyurularDto, dynamic>> orderKeySelector, Expression<Func<DuyurularDto, bool>> filter = null);
        Task<IResult> AddDto(DuyurularDto duyurularDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        IResult DeleteDto(DuyurularDto duyurularDto);
        IResult Add(Duyurular duyurular);
        IResult Delete(Duyurular duyurular);
        IResult Update(Duyurular duyurular);
    }
}

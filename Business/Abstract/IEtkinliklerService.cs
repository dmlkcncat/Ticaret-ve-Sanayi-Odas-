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
    public interface IEtkinliklerService
    {
        IDataResult<List<Etkinlikler>> GetAll();
        IDataResult<EtkinliklerDto> GetById(int etkinliklerId);
        IDataResult<List<EtkinliklerDto>> GetEtkinliklerDetails(int count, Expression<Func<EtkinliklerDto, dynamic>> orderKeySelector, Expression<Func<EtkinliklerDto, bool>> filter = null);
        Task<IResult> AddDto(EtkinliklerDto etkinliklerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images);
        IResult DeleteDto(EtkinliklerDto etkinliklerDto);
        IResult Add(Etkinlikler etkinlikler);
        IResult Delete(Etkinlikler etkinlikler);
        IResult Update(Etkinlikler etkinlikler);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReferanslarService
    {
        IDataResult<List<Referanslar>> GetAll();
        IDataResult<Referanslar> GetById(int referanslarId);
        Task<IResult> AddWithImage(Referanslar referanslar, IFormFile image);
        IResult Add(Referanslar referanslar);
        IResult Delete(Referanslar referanslar);
        IResult Update(Referanslar referanslar);
        IResult DeleteDto(Referanslar referanslar);
    }
}

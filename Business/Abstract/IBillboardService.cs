using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillboardService
    {
        IDataResult<List<Billboard>> GetAll();
        IDataResult<Billboard> GetById(int ebultenId);
        IResult Add(Billboard billboard);
        Task<IResult> AddWithImage(Billboard billboard, IFormFile image);
        IResult Delete(Billboard billboard);
        IResult Update(Billboard billboard);
    }
}

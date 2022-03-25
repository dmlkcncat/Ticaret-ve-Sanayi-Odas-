using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISimgelerService
    {
        IDataResult<List<Simgeler>> GetAll();
        IDataResult<Simgeler> GetById(int simgelerId);
        Task<IResult> AddWithImage(Simgeler simge, IFormFile image);
        IResult Add(Simgeler simgeler);
        IResult Delete(Simgeler simgeler);
        IResult Update(Simgeler simgeler);
    }
}

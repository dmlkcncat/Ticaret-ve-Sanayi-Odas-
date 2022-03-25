using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SimgelerManager : ISimgelerService
    {
        ISimgelerDal _simgelerDal;
        public SimgelerManager(ISimgelerDal simgelerDal)
        {
            _simgelerDal = simgelerDal;
        }

        public IResult Add(Simgeler simgeler)
        {
            _simgelerDal.Add(simgeler);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddWithImage(Simgeler simge, IFormFile image)
        {
            await _simgelerDal.AddWithImage(simge, image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Simgeler simgeler)
        {
            _simgelerDal.Delete(simgeler);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Simgeler>> GetAll()
        {
            return new SuccessDataResult<List<Simgeler>>(_simgelerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Simgeler> GetById(int simgelerId)
        {
            return new SuccessDataResult<Simgeler>(_simgelerDal.Get(p => p.Id == simgelerId));
        }

        public IResult Update(Simgeler simgeler)
        {
            _simgelerDal.Update(simgeler);
            return new SuccessResult(Messages.Updated);
        }
    }
}

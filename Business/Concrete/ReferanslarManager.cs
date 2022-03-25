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
    public class ReferanslarManager : IReferanslarService
    {
        IReferanslarDal _referanslarDal;
        public ReferanslarManager(IReferanslarDal referanslarDal)
        {
            _referanslarDal = referanslarDal;
        }

        public IResult Add(Referanslar referanslar)
        {
            _referanslarDal.Add(referanslar);
            return new SuccessResult(Messages.Added);
        }
        public async Task<IResult> AddWithImage(Referanslar referanslar, IFormFile image)
        {
            await _referanslarDal.AddWithImage(referanslar, image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Referanslar referanslar)
        {
            _referanslarDal.Delete(referanslar);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Referanslar referanslar)
        {
            _referanslarDal.DeleteDto(referanslar);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Referanslar>> GetAll()
        {
            return new SuccessDataResult<List<Referanslar>>(_referanslarDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Referanslar> GetById(int referanslarId)
        {
            return new SuccessDataResult<Referanslar>(_referanslarDal.Get(p => p.Id == referanslarId));
        }

        public IResult Update(Referanslar referanslar)
        {
            _referanslarDal.Update(referanslar);
            return new SuccessResult(Messages.Updated);
        }
    }
}

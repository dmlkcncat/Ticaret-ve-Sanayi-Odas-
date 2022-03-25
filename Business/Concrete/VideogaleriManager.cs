using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class VideogaleriManager : IVideogaleriService
    {
        IVideogaleriDal _videogaleriDal;
        public VideogaleriManager(IVideogaleriDal videogaleriDal)
        {
            _videogaleriDal = videogaleriDal;
        }

        public IResult Add(Videogaleri videogaleri)
        {
            _videogaleriDal.Add(videogaleri);
            return new SuccessResult(Messages.Added);
        }


        public IResult Delete(Videogaleri videogaleri)
        {
            _videogaleriDal.Delete(videogaleri);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Videogaleri videogaleri)
        {
            _videogaleriDal.DeleteDto(videogaleri);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Videogaleri>> GetAll()
        {

            return new SuccessDataResult<List<Videogaleri>>(_videogaleriDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Videogaleri> GetById(int videogaleriId)
        {
            return new SuccessDataResult<Videogaleri>(_videogaleriDal.Get(p => p.Id == videogaleriId));
        }


        public IResult Update(Videogaleri videogaleri)
        {
            _videogaleriDal.Update(videogaleri);
            return new SuccessResult(Messages.Updated);
        }
    }
}

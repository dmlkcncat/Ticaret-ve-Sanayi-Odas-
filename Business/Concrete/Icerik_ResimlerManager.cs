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
    public class Icerik_ResimlerManager : IIcerik_ResimlerService
    {

        IIcerik_ResimlerDal _icerikResimlerDal;
        public Icerik_ResimlerManager(IIcerik_ResimlerDal icerikResimlerDal)
        {
            _icerikResimlerDal = icerikResimlerDal;
        }

        public IResult Add(Icerik_Resimler iceriklerResimler)
        {
            _icerikResimlerDal.Add(iceriklerResimler);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(Icerik_ResimlerDto icerik_ResimlerDto)
        {
            _icerikResimlerDal.AddDto(icerik_ResimlerDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Icerik_Resimler iceriklerResimler)
        {
            _icerikResimlerDal.Delete(iceriklerResimler);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Icerik_ResimlerDto icerik_ResimlerDto)
        {
            _icerikResimlerDal.DeleteDto(icerik_ResimlerDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Icerik_Resimler>> GetAll()
        {

            return new SuccessDataResult<List<Icerik_Resimler>>(_icerikResimlerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Icerik_Resimler> GetById(int icerikResimlerId)
        {
            return new SuccessDataResult<Icerik_Resimler>(_icerikResimlerDal.Get(p => p.Id == icerikResimlerId));
        }

        public IDataResult<List<Icerik_ResimlerDto>> GetIcerikResimlerDetails()
        {
            return new SuccessDataResult<List<Icerik_ResimlerDto>>(_icerikResimlerDal.GetIcerikResimlerDetails(), Messages.Listed);
        }

        public IResult Update(Icerik_Resimler iceriklerResimler)
        {
            _icerikResimlerDal.Update(iceriklerResimler);
            return new SuccessResult(Messages.Updated);
        }
    }
}

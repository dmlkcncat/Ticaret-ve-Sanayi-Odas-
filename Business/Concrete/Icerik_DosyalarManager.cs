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
    public class Icerik_DosyalarManager : IIcerik_DosyalarService
    {

        IIcerik_DosyalarDal _icerikDosyalarDal;
        public Icerik_DosyalarManager(IIcerik_DosyalarDal icerikDosyalarDal)
        {
            _icerikDosyalarDal = icerikDosyalarDal;
        }

        public IResult Add(Icerik_Dosyalar iceriklerDosyalar)
        {
            _icerikDosyalarDal.Add(iceriklerDosyalar);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(Icerik_DosyalarDto icerik_DosyalarDto)
        {
            _icerikDosyalarDal.AddDto(icerik_DosyalarDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Icerik_Dosyalar iceriklerDosyalar)
        {
            _icerikDosyalarDal.Delete(iceriklerDosyalar);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Icerik_DosyalarDto icerik_DosyalarDto)
        {
            _icerikDosyalarDal.DeleteDto(icerik_DosyalarDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Icerik_Dosyalar>> GetAll()
        {
            return new SuccessDataResult<List<Icerik_Dosyalar>>(_icerikDosyalarDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Icerik_Dosyalar> GetById(int icerikDosyalarId)
        {
            return new SuccessDataResult<Icerik_Dosyalar>(_icerikDosyalarDal.Get(p => p.Id == icerikDosyalarId));
        }

        public IDataResult<List<Icerik_DosyalarDto>> GetIcerikDosyalarDetails()
        {
            return new SuccessDataResult<List<Icerik_DosyalarDto>>(_icerikDosyalarDal.GetIcerikDosyalarDetails(), Messages.Listed);
        }

        public IResult Update(Icerik_Dosyalar iceriklerDosyalar)
        {
            _icerikDosyalarDal.Update(iceriklerDosyalar);
            return new SuccessResult(Messages.Updated);
        }
    }
}

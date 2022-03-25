using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }

        public IResult Add(Kullanici kullanici)
        {
            if(kullanici.Mail.Length<10)
            {
                return new ErrorResult(Messages.KullaniciInvalid);
            }
            _kullaniciDal.Add(kullanici);
            return new SuccessResult(Messages.KullaniciAdded);
        }

        public IResult Delete(Kullanici kullanici)
        {
            _kullaniciDal.Delete(kullanici);
            return new SuccessResult(Messages.KullaniciDeleted);
        }

        public IDataResult<List<Kullanici>> GetAll()
        {
            return new SuccessDataResult<List<Kullanici>>(_kullaniciDal.GetAll(), Messages.KullaniciListed);
        }

        public IDataResult<Kullanici> GetById(int kullaniciId)
        {
            return new SuccessDataResult<Kullanici>(_kullaniciDal.Get(p => p.Id == kullaniciId));
        }

        public IResult Update(Kullanici kullanici)
        {
            _kullaniciDal.Update(kullanici);
            return new SuccessResult(Messages.kullaniciUpdated);
        }
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IKullaniciService
    {
        IDataResult<List<Kullanici>> GetAll();
        IResult Add(Kullanici kullanici);
        IResult Delete(Kullanici kullanici);
        IResult Update(Kullanici kullanici);
        IDataResult<Kullanici> GetById(int kullaniciId);
    }
}

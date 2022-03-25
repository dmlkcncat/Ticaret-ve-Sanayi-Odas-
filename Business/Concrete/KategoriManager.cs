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
    public class KategoriManager : IKategoriService
    {
        IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public IResult Add(Kategori kategori)
        {
            _kategoriDal.Add(kategori);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Kategori kategori)
        {
            _kategoriDal.Delete(kategori);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Kategori>> GetAll()
        {
            return new SuccessDataResult<List<Kategori>>(_kategoriDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Kategori> GetById(int kategoriId)
        {
            return new SuccessDataResult<Kategori>(_kategoriDal.Get(p => p.Id == kategoriId));
        }

        public IResult Update(Kategori kategori)
        {
            _kategoriDal.Update(kategori);
            return new SuccessResult(Messages.Updated);
        }
    }
}

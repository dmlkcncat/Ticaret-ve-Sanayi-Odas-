using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategoriService
    {
        IDataResult<List<Kategori>> GetAll();
        IDataResult<Kategori> GetById(int kategoriId);
        IResult Add(Kategori kategori);
        IResult Delete(Kategori kategori);
        IResult Update(Kategori kategori);
    }
}

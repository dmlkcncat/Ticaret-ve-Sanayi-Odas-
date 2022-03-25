using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBilgiEdinmeFormuService
    {
        IDataResult<List<BilgiEdinmeFormu>> GetAll();
        IDataResult<BilgiEdinmeFormu> GetById(int formId);
        IResult Add(BilgiEdinmeFormu bilgiEdinmeFormu);
        IResult Delete(BilgiEdinmeFormu bilgiEdinmeFormu);
        IResult Update(BilgiEdinmeFormu bilgiEdinmeFormu);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFaaliyetKatilimFormuService
    {
        IDataResult<List<FaaliyetKalitimFormu>> GetAll();
        IDataResult<FaaliyetKalitimFormu> GetById(int formId);
        IResult Add(FaaliyetKalitimFormu faaliyetKalitimFormu);
        IResult Delete(FaaliyetKalitimFormu faaliyetKalitimFormu);
        IResult Update(FaaliyetKalitimFormu faaliyetKalitimFormu);
    }
}

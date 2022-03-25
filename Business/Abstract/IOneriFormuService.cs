using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOneriFormuService
    {
        IDataResult<List<OneriFormu>> GetAll();
        IDataResult<OneriFormu> GetById(int formId);
        IResult Add(OneriFormu oneriformu);
        IResult Delete(OneriFormu oneriformu);
        IResult Update(OneriFormu oneriformu);
    }
}

using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFormiletisimService
    {
        IDataResult<List<Formiletisim>> GetAll();
        IDataResult<Formiletisim> GetById(int ebultenId);
        IResult Add(Formiletisim formiletisim);
        IResult Delete(Formiletisim formiletisim);
        IResult Update(Formiletisim formiletisim);
    }
}

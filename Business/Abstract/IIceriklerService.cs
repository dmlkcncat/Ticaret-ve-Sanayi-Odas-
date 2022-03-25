using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIceriklerService 
    {
        IDataResult<List<Icerikler>> GetAll();
        IDataResult<Icerikler> GetById(int iceriklerId);
        IResult Add(Icerikler icerikler);
        IResult Delete(Icerikler icerikler);
        IResult Update(Icerikler icerikler);
    }
}

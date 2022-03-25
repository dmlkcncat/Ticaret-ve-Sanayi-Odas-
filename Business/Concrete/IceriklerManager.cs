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
    public class IceriklerManager : IIceriklerService
    {
        IIceriklerDal _iceriklerDal;
        public IceriklerManager(IIceriklerDal iceriklerDal)
        {
            _iceriklerDal = iceriklerDal;
        }

        public IResult Add(Icerikler icerikler)
        {
            _iceriklerDal.Add(icerikler);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Icerikler icerikler)
        {
            _iceriklerDal.Delete(icerikler);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Icerikler>> GetAll()
        {
            return new SuccessDataResult<List<Icerikler>>(_iceriklerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Icerikler> GetById(int iceriklerId)
        {
            return new SuccessDataResult<Icerikler>(_iceriklerDal.Get(p => p.Id == iceriklerId));
        }

        public IResult Update(Icerikler icerikler)
        {
            _iceriklerDal.Update(icerikler);
            return new SuccessResult(Messages.Updated);
        }
    }
}

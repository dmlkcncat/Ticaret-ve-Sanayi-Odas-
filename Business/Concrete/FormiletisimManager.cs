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
    public class FormiletisimManager : IFormiletisimService
    {
        IFormiletisimDal _formiletisimDal;
        public FormiletisimManager(IFormiletisimDal formiletisimDal)
        {
            _formiletisimDal = formiletisimDal;
        }
        public IResult Add(Formiletisim formiletisim)
        {
            _formiletisimDal.Add(formiletisim);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Formiletisim formiletisim)
        {
            _formiletisimDal.Delete(formiletisim);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Formiletisim>> GetAll()
        {
            return new SuccessDataResult<List<Formiletisim>>(_formiletisimDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Formiletisim> GetById(int ebultenId)
        {
            return new SuccessDataResult<Formiletisim>(_formiletisimDal.Get(p => p.Id == ebultenId));
        }

        public IResult Update(Formiletisim formiletisim)
        {
            _formiletisimDal.Update(formiletisim);
            return new SuccessResult(Messages.Updated);
        }
    }
}

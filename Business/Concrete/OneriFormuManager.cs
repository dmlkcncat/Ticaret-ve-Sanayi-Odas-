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
    public class OneriFormuManager : IOneriFormuService
    {
        IOneriFormuDal _oneriFormuDal;
        public OneriFormuManager(IOneriFormuDal oneriFormuDal)
        {
            _oneriFormuDal = oneriFormuDal;
        }
        public IResult Add(OneriFormu oneriformu)
        {
            _oneriFormuDal.Add(oneriformu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OneriFormu oneriformu)
        {
            _oneriFormuDal.Delete(oneriformu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<OneriFormu>> GetAll()
        {
            return new SuccessDataResult<List<OneriFormu>>(_oneriFormuDal.GetAll(), Messages.Listed);
        }

        public IDataResult<OneriFormu> GetById(int formId)
        {
            return new SuccessDataResult<OneriFormu>(_oneriFormuDal.Get(p => p.Id == formId));
        }

        public IResult Update(OneriFormu oneriformu)
        {
            _oneriFormuDal.Update(oneriformu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

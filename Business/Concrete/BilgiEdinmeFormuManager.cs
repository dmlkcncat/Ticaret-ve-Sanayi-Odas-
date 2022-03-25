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
    public class BilgiEdinmeFormuManager : IBilgiEdinmeFormuService
    {
        IBilgiEdinmeFormuDal _bilgiedinmeDal;
        public BilgiEdinmeFormuManager(IBilgiEdinmeFormuDal bilgiedinmeDal)
        {
            _bilgiedinmeDal = bilgiedinmeDal;
        }

        public IResult Add(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            _bilgiedinmeDal.Add(bilgiEdinmeFormu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            _bilgiedinmeDal.Delete(bilgiEdinmeFormu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<BilgiEdinmeFormu>> GetAll()
        {
            return new SuccessDataResult<List<BilgiEdinmeFormu>>(_bilgiedinmeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<BilgiEdinmeFormu> GetById(int formId)
        {
            return new SuccessDataResult<BilgiEdinmeFormu>(_bilgiedinmeDal.Get(p => p.Id == formId));
        }

        public IResult Update(BilgiEdinmeFormu bilgiEdinmeFormu)
        {
            _bilgiedinmeDal.Update(bilgiEdinmeFormu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

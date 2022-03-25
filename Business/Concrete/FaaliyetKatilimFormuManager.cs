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
    public class FaaliyetKatilimFormuManager : IFaaliyetKatilimFormuService
    {
        IFaaliyetKatilimFormuDal _faaliyetKatilimFormuDal;
        public FaaliyetKatilimFormuManager(IFaaliyetKatilimFormuDal faaliyetKatilimFormuDal)
        {
            _faaliyetKatilimFormuDal = faaliyetKatilimFormuDal;
        }
        public IResult Add(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            _faaliyetKatilimFormuDal.Add(faaliyetKalitimFormu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            _faaliyetKatilimFormuDal.Delete(faaliyetKalitimFormu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<FaaliyetKalitimFormu>> GetAll()
        {
            return new SuccessDataResult<List<FaaliyetKalitimFormu>>(_faaliyetKatilimFormuDal.GetAll(), Messages.Listed);
        }

        public IDataResult<FaaliyetKalitimFormu> GetById(int formId)
        {
            return new SuccessDataResult<FaaliyetKalitimFormu>(_faaliyetKatilimFormuDal.Get(p => p.Id == formId));
        }

        public IResult Update(FaaliyetKalitimFormu faaliyetKalitimFormu)
        {
            _faaliyetKatilimFormuDal.Update(faaliyetKalitimFormu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

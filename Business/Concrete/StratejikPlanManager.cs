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
    public class StratejikPlanManager : IStratejikPlanService
    {

        IStratejikPlanDal _stratejikPlanDal;
        public StratejikPlanManager(IStratejikPlanDal stratejikPlanDal)
        {
            _stratejikPlanDal = stratejikPlanDal;
        }
        public IResult Add(StratejikPlan stratejikPlan)
        {
            _stratejikPlanDal.Add(stratejikPlan);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(StratejikPlan stratejikPlan)
        {
            _stratejikPlanDal.Delete(stratejikPlan);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<StratejikPlan>> GetAll()
        {
            return new SuccessDataResult<List<StratejikPlan>>(_stratejikPlanDal.GetAll(), Messages.Listed);
        }

        public IDataResult<StratejikPlan> GetById(int stratejikPlanId)
        {
            return new SuccessDataResult<StratejikPlan>(_stratejikPlanDal.Get(p => p.Id == stratejikPlanId));
        }

        public IResult Update(StratejikPlan stratejikPlan)
        {
            _stratejikPlanDal.Update(stratejikPlan);
            return new SuccessResult(Messages.Updated);
        }
    }
}

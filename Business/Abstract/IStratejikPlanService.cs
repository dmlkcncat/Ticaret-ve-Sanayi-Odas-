using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IStratejikPlanService
    {
        IDataResult<List<StratejikPlan>> GetAll();
        IDataResult<StratejikPlan> GetById(int stratejikPlanId);
        IResult Add(StratejikPlan stratejikPlan);
        IResult Delete(StratejikPlan stratejikPlan);
        IResult Update(StratejikPlan stratejikPlan);
    }
}

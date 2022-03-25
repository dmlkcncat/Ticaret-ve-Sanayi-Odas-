using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IOrtaMenuService
    {
        IDataResult<List<OrtaMenu>> GetAll(Expression<Func<OrtaMenu, bool>> filter = null);
        IDataResult<List<OrtaMenu>> Take(int count, Expression<Func<OrtaMenu, dynamic>> orderKeySelector, Expression<Func<OrtaMenu, bool>> filter = null);
        IDataResult<OrtaMenu> GetById(int ortaMenuId);
        IDataResult<List<OrtaMenuDto>> GetOrtaMenuDetails(Expression<Func<OrtaMenuDto, bool>> filter = null);
        IResult AddDto(OrtaMenuDto ortaMenuDto);
        IResult DeleteDto(OrtaMenuDto ortaMenuDto);
        IResult Add(OrtaMenu ortaMenu);
        IResult Delete(OrtaMenu ortaMenu);
        IResult Update(OrtaMenu ortaMenu);
    }
}

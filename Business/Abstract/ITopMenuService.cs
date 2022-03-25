using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ITopMenuService 
    {
        IDataResult<List<TopMenu>> GetAll(Expression<Func<TopMenu, bool>> filter = null);
        IDataResult<List<TopMenu>> Take(int count, Expression<Func<TopMenu, dynamic>> orderKeySelector, Expression<Func<TopMenu, bool>> filter = null);
        IDataResult<TopMenu> GetById(int topMenuId);
        IDataResult<List<TopMenuDto>> GetTopMenuDetails();
        IResult AddDto(TopMenuDto topMenuDto);
        IResult DeleteDto(TopMenuDto topMenuDto);
        IResult Add(TopMenu topMenu);
        IResult Delete(TopMenu topMenu);
        IResult Update(TopMenu topMenu);
    }
}

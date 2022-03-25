using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IHeader_MenuService
    {
        IDataResult<List<Header_Menu>> GetAll();
        IDataResult<List<Header_Menu>> Take(int count, Expression<Func<Header_Menu, dynamic>> orderKeySelector, Expression<Func<Header_Menu, bool>> filter = null);
        IDataResult<Header_Menu> GetById(int headerMenuId);
        IResult Add(Header_Menu headerMenu);
        IResult Delete(Header_Menu headerMenu);
        IResult Update(Header_Menu headerMenu);
        IResult DeleteDto(Header_Menu header_Menu);
    }
}

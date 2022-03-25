using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMenuService
    {
        IDataResult<List<Menu>> GetAll();
        IResult Add(Menu menu);
        IResult Delete(Menu menu);
        IResult Update(Menu menu);
        IResult DeleteDto(Menu menu);
        IDataResult<Menu> GetById(int menuId);
    }
}

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
    public class MenuManager : IMenuService
    {
        IMenuDal _menuDal;
        public MenuManager(IMenuDal menuDal)
        {
            _menuDal = menuDal;
        }
        public IResult Add(Menu menu)
        {
            _menuDal.Add(menu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Menu menu)
        {
            _menuDal.Delete(menu);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Menu menu)
        {
            _menuDal.DeleteDto(menu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Menu>> GetAll()
        {
            return new SuccessDataResult<List<Menu>>(_menuDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Menu> GetById(int menuId)
        {
            return new SuccessDataResult<Menu>(
              _menuDal.GetById(menuId),
              Messages.Listed
          );
        }

        public IResult Update(Menu menu)
        {
            _menuDal.Update(menu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

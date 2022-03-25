using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class Header_MenuManager : IHeader_MenuService
    {
        IHeader_MenuDal _headerMenuDal;
        public Header_MenuManager(IHeader_MenuDal headerMenuDal)
        {
            _headerMenuDal = headerMenuDal;
        }

        public IResult Add(Header_Menu headerMenu)
        {
            _headerMenuDal.Add(headerMenu);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Header_Menu headerMenu)
        {
            _headerMenuDal.Delete(headerMenu);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Header_Menu header_Menu)
        {
            _headerMenuDal.DeleteDto(header_Menu);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Header_Menu>> GetAll()
        {
            return new SuccessDataResult<List<Header_Menu>>(_headerMenuDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Header_Menu> GetById(int headerMenuId)
        {
            return new SuccessDataResult<Header_Menu>(_headerMenuDal.Get(p => p.Id == headerMenuId));
        }

        public IDataResult<List<Header_Menu>> Take(int count, Expression<Func<Header_Menu, dynamic>> orderKeySelector, Expression<Func<Header_Menu, bool>> filter = null)
        {
            return new SuccessDataResult<List<Header_Menu>>(_headerMenuDal.Take(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(Header_Menu headerMenu)
        {
            _headerMenuDal.Update(headerMenu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

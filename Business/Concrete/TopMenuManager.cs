using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class TopMenuManager : ITopMenuService
    {
        ITopMenuDal _topMenuDal;
        public TopMenuManager(ITopMenuDal topMenuDal)
        {
            _topMenuDal = topMenuDal;
        }

        public IResult Add(TopMenu topMenu)
        {
            _topMenuDal.Add(topMenu);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(TopMenuDto topMenuDto)
        {
            _topMenuDal.AddDto(topMenuDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(TopMenu topMenu)
        {
            _topMenuDal.Delete(topMenu);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(TopMenuDto topMenuDto)
        {
            _topMenuDal.DeleteDto(topMenuDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<TopMenu>> GetAll(Expression<Func<TopMenu, bool>> filter = null)
        {
            return new SuccessDataResult<List<TopMenu>>(_topMenuDal.GetAll(filter), Messages.Listed);
        }

        public IDataResult<TopMenu> GetById(int topMenuId)
        {
            return new SuccessDataResult<TopMenu>(_topMenuDal.Get(p => p.Id == topMenuId));
        }

        public IDataResult<List<TopMenuDto>> GetTopMenuDetails()
        {
            return new SuccessDataResult<List<TopMenuDto>>(_topMenuDal.GetTopMenuDetails(), Messages.Listed);
        }

        public IDataResult<List<TopMenu>> Take(int count, Expression<Func<TopMenu, dynamic>> orderKeySelector, Expression<Func<TopMenu, bool>> filter = null)
        {
            return new SuccessDataResult<List<TopMenu>>(_topMenuDal.Take(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(TopMenu topMenu)
        {
            _topMenuDal.Update(topMenu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

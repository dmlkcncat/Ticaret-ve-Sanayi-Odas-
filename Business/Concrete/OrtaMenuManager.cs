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
    public class OrtaMenuManager : IOrtaMenuService
    {
        IOrtaMenuDal _ortaMenuDal;
        public OrtaMenuManager(IOrtaMenuDal ortaMenuDal)
        {
            _ortaMenuDal = ortaMenuDal;
        }

        public IResult Add(OrtaMenu ortaMenu)
        {
            _ortaMenuDal.Add(ortaMenu);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(OrtaMenuDto ortaMenuDto)
        {
            _ortaMenuDal.AddDto(ortaMenuDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(OrtaMenu ortaMenu)
        {
            _ortaMenuDal.Delete(ortaMenu);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(OrtaMenuDto ortaMenuDto)
        {
            _ortaMenuDal.DeleteDto(ortaMenuDto);
            return new SuccessResult(Messages.Deleted);
        }

     
        public IDataResult<List<OrtaMenu>> GetAll(Expression<Func<OrtaMenu, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrtaMenu>>(_ortaMenuDal.GetAll(filter), Messages.Listed);
        }

        public IDataResult<OrtaMenu> GetById(int ortaMenuId)
        {
            return new SuccessDataResult<OrtaMenu>(_ortaMenuDal.Get(p => p.Id == ortaMenuId));
        }

        public IDataResult<List<OrtaMenuDto>> GetOrtaMenuDetails(Expression<Func<OrtaMenuDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrtaMenuDto>>(_ortaMenuDal.GetOrtaMenuDetails(filter), Messages.Listed);
        }

        public IDataResult<List<OrtaMenu>> Take(int count, Expression<Func<OrtaMenu, dynamic>> orderKeySelector, Expression<Func<OrtaMenu, bool>> filter = null)
        {
            return new SuccessDataResult<List<OrtaMenu>>(_ortaMenuDal.Take(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(OrtaMenu ortaMenu)
        {
            _ortaMenuDal.Update(ortaMenu);
            return new SuccessResult(Messages.Updated);
        }
    }
}

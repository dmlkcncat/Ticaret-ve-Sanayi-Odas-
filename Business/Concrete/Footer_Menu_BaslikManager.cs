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
    public class Footer_Menu_BaslikManager : IFooter_Menu_BaslikService
    {
        IFooter_Menu_BaslikDal _footerMenuBaslikDal;
        public Footer_Menu_BaslikManager(IFooter_Menu_BaslikDal footerMenuBaslikDal)
        {
            _footerMenuBaslikDal = footerMenuBaslikDal;
        }

        public IResult Add(Footer_Menu_Baslik footer_Menu_Baslik)
        {
            _footerMenuBaslikDal.Add(footer_Menu_Baslik);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Footer_Menu_Baslik footer_Menu_Baslik)
        {
            _footerMenuBaslikDal.Delete(footer_Menu_Baslik);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Footer_Menu_Baslik>> GetAll()
        {
            return new SuccessDataResult<List<Footer_Menu_Baslik>>(_footerMenuBaslikDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Footer_Menu_Baslik> GetById(int footerMenuBaslikId)
        {
            return new SuccessDataResult<Footer_Menu_Baslik>(_footerMenuBaslikDal.Get(p => p.Id == footerMenuBaslikId));
        }

        public IResult Update(Footer_Menu_Baslik footer_Menu_Baslik)
        {
            _footerMenuBaslikDal.Update(footer_Menu_Baslik);
            return new SuccessResult(Messages.Updated);
        }
    }
}

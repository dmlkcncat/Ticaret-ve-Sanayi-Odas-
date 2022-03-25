using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class Footer_Menu_OgeManager : IFooter_Menu_OgeService
    {
        IFooter_Menu_OgeDal _footerMenuOgeDal;
        public Footer_Menu_OgeManager(IFooter_Menu_OgeDal footerMenuOgeDal)
        {
            _footerMenuOgeDal = footerMenuOgeDal;
        }

        public IResult Add(Footer_Menu_Oge footer_Menu_Oge)
        {
            _footerMenuOgeDal.Add(footer_Menu_Oge);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(Footer_Menu_OgeDto footer_Menu_OgeDto)
        {
            _footerMenuOgeDal.AddDto(footer_Menu_OgeDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Footer_Menu_Oge footer_Menu_Oge)
        {
            _footerMenuOgeDal.Delete(footer_Menu_Oge);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Footer_Menu_OgeDto footer_Menu_OgeDto)
        {
            _footerMenuOgeDal.DeleteDto(footer_Menu_OgeDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Footer_Menu_Oge>> GetAll()
        {
            return new SuccessDataResult<List<Footer_Menu_Oge>>(_footerMenuOgeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Footer_Menu_Oge> GetById(int footerMenuOgeId)
        {
            return new SuccessDataResult<Footer_Menu_Oge>(_footerMenuOgeDal.Get(p => p.Id == footerMenuOgeId));
        }

        public IDataResult<List<Footer_Menu_OgeDto>> GetFooter_Menu_OgeDetails()
        {
            return new SuccessDataResult<List<Footer_Menu_OgeDto>>(_footerMenuOgeDal.GetFooter_Menu_OgeDetails(), Messages.Listed);
        }

        public IResult Update(Footer_Menu_Oge footer_Menu_Oge)
        {
            _footerMenuOgeDal.Update(footer_Menu_Oge);
            return new SuccessResult(Messages.Updated);
        }
    }
}

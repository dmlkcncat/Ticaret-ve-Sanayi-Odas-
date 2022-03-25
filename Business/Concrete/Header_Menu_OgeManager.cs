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
    public class Header_Menu_OgeManager : IHeader_Menu_OgeService
    {
        IHeader_Menu_OgeDal _headerMenuOgeDal;
        public Header_Menu_OgeManager(IHeader_Menu_OgeDal headerMenuOgeDal)
        {
            _headerMenuOgeDal = headerMenuOgeDal;
        }

        public IResult Add(Header_Menu_Oge headerMenuOge)
        {
            _headerMenuOgeDal.Add(headerMenuOge);
            return new SuccessResult(Messages.Added);
        }

        public IResult AddDto(Header_Menu_OgeDto headerMenuOgeDto)
        {
            _headerMenuOgeDal.AddDto(headerMenuOgeDto);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Header_Menu_Oge headerMenuOge)
        {
            _headerMenuOgeDal.Delete(headerMenuOge);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Header_Menu_OgeDto header_Menu_OgeDto)
        {
            _headerMenuOgeDal.DeleteDto(header_Menu_OgeDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Header_Menu_Oge>> GetAll()
        {
            return new SuccessDataResult<List<Header_Menu_Oge>>(_headerMenuOgeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Header_Menu_Oge> GetById(int headerMenuOgeId)
        {
            return new SuccessDataResult<Header_Menu_Oge>(_headerMenuOgeDal.Get(p => p.Id == headerMenuOgeId));
        }

        public IDataResult<List<Header_Menu_OgeDto>> GetHeader_Menu_OgeDetails()
        {
            return new SuccessDataResult<List<Header_Menu_OgeDto>>(_headerMenuOgeDal.GetHeader_Menu_OgeDetails(), Messages.Listed);
        }

        public IResult Update(Header_Menu_Oge headerMenuOge)
        {
            _headerMenuOgeDal.Update(headerMenuOge);
            return new SuccessResult(Messages.Updated);
        }
    }
}

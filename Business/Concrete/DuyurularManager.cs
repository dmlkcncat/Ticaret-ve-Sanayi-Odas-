using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DuyurularManager : IDuyurularService
    {
        IDuyurularDal _duyurularDal;
        public DuyurularManager(IDuyurularDal duyurularDal)
        {
            _duyurularDal = duyurularDal;
        }

        public IResult Add(Duyurular duyurular)
        {
            _duyurularDal.Add(duyurular);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddDto(DuyurularDto duyurularDto, IFormFile image, List<IFormFile> files, List<IFormFile> images)
        {
           await _duyurularDal.AddDto(duyurularDto, image, files, images);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Duyurular duyurular)
        {
            _duyurularDal.Delete(duyurular);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(DuyurularDto duyurularDto)
        {
            _duyurularDal.DeleteDto(duyurularDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Duyurular>> GetAll()
        {
            return new SuccessDataResult<List<Duyurular>>(_duyurularDal.GetAll(), Messages.Listed);
        }

        public IDataResult<DuyurularDto> GetById(int duyurularId)
        {
            return new SuccessDataResult<DuyurularDto>(
                _duyurularDal.GetById(duyurularId),
                Messages.Listed
            );
        }

        public IDataResult<List<DuyurularDto>> GetDuyurularDetails(int count, Expression<Func<DuyurularDto, dynamic>> orderKeySelector, Expression<Func<DuyurularDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<DuyurularDto>>(_duyurularDal.GetDuyurularDetails(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(Duyurular duyurular)
        {
            _duyurularDal.Update(duyurular);
            return new SuccessResult(Messages.Updated);
        }
    }
}

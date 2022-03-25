using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HaberlerManager : IHaberlerService
    {
        IHaberlerDal _haberlerDal;
        public HaberlerManager(IHaberlerDal haberlerDal)
        {
            _haberlerDal = haberlerDal;
        }

        public IResult Add(Haberler haberler)
        {
            _haberlerDal.Add(haberler);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddDto(HaberlerDto haberlerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images)
        {
            await _haberlerDal.AddDto(haberlerDto, image, files, images);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Haberler haberler)
        {
            _haberlerDal.Delete(haberler);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(HaberlerDto haberlerDto)
        {
            _haberlerDal.DeleteDto(haberlerDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Haberler>> GetAll()
        {
            return new SuccessDataResult<List<Haberler>>(_haberlerDal.GetAll(), Messages.Listed);
        }

        public IDataResult<HaberlerDto> GetById(int haberlerId)
        {
            return new SuccessDataResult<HaberlerDto>(
                _haberlerDal.GetById(haberlerId),
                Messages.Listed
            );
        }

        public IDataResult<List<HaberlerDto>> GetDetails()
        {
            return new SuccessDataResult<List<HaberlerDto>>(_haberlerDal.GetDetails(), Messages.Listed);

        }

        public IDataResult<List<HaberlerDto>> GetHaberlerDetails(int count, Expression<Func<HaberlerDto, dynamic>> orderKeySelector, Expression<Func<HaberlerDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<HaberlerDto>>(_haberlerDal.GetHaberlerDetails(count, orderKeySelector, filter), Messages.Listed);
        }

        public IDataResult<List<Haberler>> Take(int count, Expression<Func<Haberler, dynamic>> orderKeySelector, Expression<Func<Haberler, bool>> filter = null)
        {
            return new SuccessDataResult<List<Haberler>>(_haberlerDal.Take(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(Haberler haberler)
        {
            _haberlerDal.Update(haberler);
            return new SuccessResult(Messages.Updated);
        }
    }
}

using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FotogaleriManager : IFotogaleriService
    {
        IFotogaleriDal _fotogaleriDal;
        public FotogaleriManager(IFotogaleriDal fotogaleriDal)
        {
            _fotogaleriDal = fotogaleriDal;
        }

        public IResult Add(Fotogaleri fotogaleri)
        {
            _fotogaleriDal.Add(fotogaleri);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddDto(FotogaleriDto fotogaleriDto, List<IFormFile> images)
        {
            await _fotogaleriDal.AddDto(fotogaleriDto, images);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Fotogaleri fotogaleri)
        {
            _fotogaleriDal.Delete(fotogaleri);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(FotogaleriDto fotogaleriDto)
        {
            _fotogaleriDal.DeleteDto(fotogaleriDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Fotogaleri>> GetAll()
        {
            return new SuccessDataResult<List<Fotogaleri>>(_fotogaleriDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Fotogaleri> GetById(int fotogaleriId)
        {
            return new SuccessDataResult<Fotogaleri>(_fotogaleriDal.Get(p => p.Id == fotogaleriId));
        }

        public IDataResult<List<FotogaleriDto>> GetFotogaleriDetails()
        {
            return new SuccessDataResult<List<FotogaleriDto>>(_fotogaleriDal.GetFotogaleriDetails(), Messages.Listed);
        }

        public IResult Update(Fotogaleri fotogaleri)
        {
            _fotogaleriDal.Update(fotogaleri);
            return new SuccessResult(Messages.Updated);
        }
    }
}

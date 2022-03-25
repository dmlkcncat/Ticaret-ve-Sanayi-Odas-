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
    public class SayfalarManager : ISayfalarService
    {
        ISayfalarDal _sayfalarDal;
        public SayfalarManager(ISayfalarDal sayfalarDal)
        {
            _sayfalarDal = sayfalarDal;
        }

        public IResult Add(Sayfalar sayfalar)
        {
            _sayfalarDal.Add(sayfalar);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddDto(SayfalarDto sayfalarDto, IFormFile image, List<IFormFile> files, List<IFormFile> images)
        {
            await _sayfalarDal.AddDto(sayfalarDto, image, files, images);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Sayfalar sayfalar)
        {
            _sayfalarDal.Delete(sayfalar);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(SayfalarDto sayfalarDto)
        {
            _sayfalarDal.DeleteDto(sayfalarDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Sayfalar>> GetAll()
        {
            return new SuccessDataResult<List<Sayfalar>>(_sayfalarDal.GetAll(), Messages.Listed);
        }

        public IDataResult<SayfalarDto> GetById(int sayfalarId)
        {
            return new SuccessDataResult<SayfalarDto>(
                _sayfalarDal.GetById(sayfalarId),
                Messages.Listed
            );
        }

        public IDataResult<List<SayfalarDto>> GetSayfalarDetails()
        {
            return new SuccessDataResult<List<SayfalarDto>>(_sayfalarDal.GetSayfalarDetails(), Messages.Listed);
        }

        public IResult Update(Sayfalar sayfalar)
        {
            _sayfalarDal.Update(sayfalar);
            return new SuccessResult(Messages.Updated);
        }
    }
}

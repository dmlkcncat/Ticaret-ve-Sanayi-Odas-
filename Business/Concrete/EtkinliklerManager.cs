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
    public class EtkinliklerManager : IEtkinliklerService
    {

        IEtkinliklerDal _etkinliklerDal;
        public EtkinliklerManager(IEtkinliklerDal etkinliklerDal)
        {
            _etkinliklerDal = etkinliklerDal;
        }

        public IResult Add(Etkinlikler etkinlikler)
        {
            _etkinliklerDal.Add(etkinlikler);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddDto(EtkinliklerDto etkinliklerDto, IFormFile image, List<IFormFile> files, List<IFormFile> images)
        {
            await _etkinliklerDal.AddDto(etkinliklerDto, image, files, images);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Etkinlikler etkinlikler)
        {
            _etkinliklerDal.Delete(etkinlikler);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(EtkinliklerDto etkinliklerDto)
        {
            _etkinliklerDal.DeleteDto(etkinliklerDto);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Etkinlikler>> GetAll()
        {
            return new SuccessDataResult<List<Etkinlikler>>(_etkinliklerDal.GetAll(), Messages.Listed);
        }


        public IDataResult<EtkinliklerDto> GetById(int etkinliklerId)
        {
            return new SuccessDataResult<EtkinliklerDto>(
                _etkinliklerDal.GetById(etkinliklerId),
                Messages.Listed
            );
        }

        public IDataResult<List<EtkinliklerDto>> GetEtkinliklerDetails(int count, Expression<Func<EtkinliklerDto, dynamic>> orderKeySelector, Expression<Func<EtkinliklerDto, bool>> filter = null)
        {
            return new SuccessDataResult<List<EtkinliklerDto>>(_etkinliklerDal.GetEtkinliklerDetails(count, orderKeySelector, filter), Messages.Listed);
        }

        public IResult Update(Etkinlikler etkinlikler)
        {
            _etkinliklerDal.Update(etkinlikler);
            return new SuccessResult(Messages.Updated);
        }
    }
}

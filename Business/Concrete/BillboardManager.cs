using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillboardManager : IBillboardService
    {
        IBillboardDal _billboardDal;
        public BillboardManager(IBillboardDal billboardDal)
        {
            _billboardDal = billboardDal;
        }
        public IResult Add(Billboard billboard)
        {
            _billboardDal.Add(billboard);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddWithImage(Billboard billboard, IFormFile image)
        {
            await _billboardDal.AddWithImage(billboard, image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Billboard billboard)
        {
            _billboardDal.Delete(billboard);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Billboard>> GetAll()
        {
            return new SuccessDataResult<List<Billboard>>(_billboardDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Billboard> GetById(int ebultenId)
        {
            return new SuccessDataResult<Billboard>(_billboardDal.Get(p => p.Id == ebultenId));
        }

        public IResult Update(Billboard billboard)
        {
            _billboardDal.Update(billboard);
            return new SuccessResult(Messages.Updated);
        }
    }
}

using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class E_BultenlerManager : IE_BultenlerService
    {
        IE_BultenlerDal _eBultenlerDal;
        public E_BultenlerManager(IE_BultenlerDal eBultenlerDal)
        {
            _eBultenlerDal = eBultenlerDal;
        }

        public IResult Add(E_Bultenler ebultenler)
        {
            _eBultenlerDal.Add(ebultenler);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddWithImage(E_Bultenler eBultenler, IFormFile image)
        {
           await _eBultenlerDal.AddWithImage(eBultenler, image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(E_Bultenler ebultenler)
        {
            _eBultenlerDal.Delete(ebultenler);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(E_Bultenler eBultenler)
        {
            _eBultenlerDal.DeleteDto(eBultenler);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<E_Bultenler>> GetAll()
        {
            return new SuccessDataResult<List<E_Bultenler>>(_eBultenlerDal.GetAll(), Messages.Listed);

        }

        public IDataResult<E_Bultenler> GetById(int ebultenId)
        {
            return new SuccessDataResult<E_Bultenler>(
              _eBultenlerDal.GetById(ebultenId),
              Messages.Listed
          );
        }

        public IDataResult<List<E_Bultenler>> Take(int count, Expression<Func<E_Bultenler, dynamic>> orderKeySelector, Expression<Func<E_Bultenler, bool>> filter = null)
        {
            return new SuccessDataResult<List<E_Bultenler>>(_eBultenlerDal.Take(count, orderKeySelector, filter), Messages.Listed);

        }

        public async Task<IResult> Update(E_Bultenler eBultenler, IFormFile image)
        {
            await _eBultenlerDal.Update(eBultenler, image);
            return new SuccessResult(Messages.Updated);
        }
    }
}

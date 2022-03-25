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
    public class ModalManager : IModalService
    {
        IModalDal _modalDal;
        public ModalManager(IModalDal modalDal)
        {
            _modalDal = modalDal;
        }

        public IResult Add(Modal modal)
        {
            _modalDal.Add(modal);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> AddWithImage(Modal modal, IFormFile image)
        {
            await _modalDal.AddWithImage(modal, image);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Modal modal)
        {
            _modalDal.Delete(modal);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult DeleteDto(Modal modal)
        {
            _modalDal.DeleteDto(modal);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Modal>> GetAll(Expression<Func<TopMenu, bool>> filter = null)
        {
            return new SuccessDataResult<List<Modal>>(_modalDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Modal> GetById(int modalId)
        {
            return new SuccessDataResult<Modal>(_modalDal.Get(p => p.Id == modalId));
        }

        public IResult Update(Modal modal)
        {
            _modalDal.Update(modal);
            return new SuccessResult(Messages.Updated);
        }
    }
}

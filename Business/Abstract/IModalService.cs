using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IModalService
    {
        IDataResult<List<Modal>> GetAll(Expression<Func<TopMenu, bool>> filter = null);
        IDataResult<Modal> GetById(int modalId);
        Task<IResult> AddWithImage(Modal modal, IFormFile image);
        IResult Add(Modal modal);
        IResult Delete(Modal modal);
        IResult Update(Modal modal);
        IResult DeleteDto(Modal modal);
    }
}

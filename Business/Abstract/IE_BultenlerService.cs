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
   public interface IE_BultenlerService
    {
        IDataResult<List<E_Bultenler>> GetAll();
        IDataResult<List<E_Bultenler>> Take(int count, Expression<Func<E_Bultenler, dynamic>> orderKeySelector, Expression<Func<E_Bultenler, bool>> filter = null);
        IResult DeleteDto(E_Bultenler eBultenler);
        IResult Add(E_Bultenler ebultenler);
        Task<IResult> AddWithImage(E_Bultenler eBultenler, IFormFile image);
        IResult Delete(E_Bultenler ebultenler);
        Task<IResult> Update(E_Bultenler ebultenler, IFormFile image);
        IDataResult<E_Bultenler> GetById(int menuId);
    }
}

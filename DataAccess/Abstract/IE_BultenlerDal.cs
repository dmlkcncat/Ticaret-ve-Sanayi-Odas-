using Core.DataAccess;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IE_BultenlerDal : IEntityRepository<E_Bultenler>
    {
        Task<bool> AddWithImage(E_Bultenler ebultenlerDto, IFormFile image);
        void DeleteDto(E_Bultenler e_Bultenler);
        E_Bultenler GetById(int id);
        Task<bool> Update(E_Bultenler ebultenlerDto, IFormFile image);
    }
}

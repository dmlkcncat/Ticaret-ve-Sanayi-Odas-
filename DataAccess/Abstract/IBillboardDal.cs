using Core.DataAccess;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBillboardDal : IEntityRepository<Billboard>
    {
        Task<bool> AddWithImage(Billboard billboard, IFormFile image);
    }
}

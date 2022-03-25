using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IHizmetlerDal : IEntityRepository<Hizmetler>
    {
        List<HizmetlerDto> GetHizmetlerDetails();
        void DeleteDto(HizmetlerDto hizmetlerDto);
    }
}

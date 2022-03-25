using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Abstract
{
    public interface IHeader_MenuDal : IEntityRepository<Header_Menu> 
    {
       void DeleteDto (Header_Menu header_Menu);
    }
}

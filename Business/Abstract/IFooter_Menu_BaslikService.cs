using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFooter_Menu_BaslikService 
    {
        IDataResult<List<Footer_Menu_Baslik>> GetAll();
        IDataResult<Footer_Menu_Baslik> GetById(int footerMenuBaslikId);
        IResult Add(Footer_Menu_Baslik footer_Menu_Baslik);
        IResult Delete(Footer_Menu_Baslik footer_Menu_Baslik);
        IResult Update(Footer_Menu_Baslik footer_Menu_Baslik);
    }
}

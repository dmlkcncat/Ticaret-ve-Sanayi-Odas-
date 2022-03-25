using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class E_Bultenler : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Baglanti { get; set; }
        public DateTime Tarih { get; set; }
        public string KapakResim { get; set; }
    }
}

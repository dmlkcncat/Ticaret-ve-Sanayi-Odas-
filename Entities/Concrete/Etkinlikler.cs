using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Etkinlikler : IEntity
    {
        public int Id { get; set; }
        public int IcerikId { get; set; }
        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime Tarih { get; set; }
        public string Baslik { get; set; }
    }
}

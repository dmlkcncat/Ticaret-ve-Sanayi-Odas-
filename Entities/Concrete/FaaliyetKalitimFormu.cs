using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FaaliyetKalitimFormu : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
        public string Tc { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Billboard : IEntity
    {
        public int Id { get; set; }
        public string Dizin { get; set; }
        public string Baglanti { get; set; }
    }
}

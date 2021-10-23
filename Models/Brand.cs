using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.Models
{
    public class Brand
    {
        public int ID { get; set; }
        [DisplayName("Название марки")]
        public string Name { get; set; }
        [DisplayName("Актуальность")]
        public bool Active { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}

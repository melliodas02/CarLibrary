using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CarLib.Models
{
    public class Model
    {
        public int ID { get; set; }
        [DisplayName("Название Модели")]
        public string Name { get; set; }
        [DisplayName("Актуальность")]
        public bool Active { get; set; }
        [DisplayName("Марка")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }
    }
}

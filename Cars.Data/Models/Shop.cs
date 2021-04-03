using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Manager { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}

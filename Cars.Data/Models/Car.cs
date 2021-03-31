using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}

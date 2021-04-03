using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class PaggingViewModel
    {
        public int? Page { get; set; }
        public int? PageSize { get; set; }

    }
}
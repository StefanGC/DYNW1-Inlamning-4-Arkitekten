using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BallongAB.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}

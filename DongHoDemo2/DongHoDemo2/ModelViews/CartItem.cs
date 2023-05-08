using DongHoDemo2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DongHoDemo2.ModelViews
{
    public class CartItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }
        public double total => quantity * product.Price.Value;
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DongHoDemo2.Models
{
    public partial class Promotion
    {
        public Promotion()
        {
            Customers = new HashSet<Customer>();
        }

        public int PromotionId { get; set; }
        public string PromotionName { get; set; }
        public int? PromotionPrice { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}

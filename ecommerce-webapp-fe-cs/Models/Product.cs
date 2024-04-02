﻿using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace ecommerce_webapp_fe_cs.Models
{
 
        public class Product
        {
            public string ProId { get; set; }
            public string ProName { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public int StockQuantity { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }
        }

}
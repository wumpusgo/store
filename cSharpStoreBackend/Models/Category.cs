﻿using System;
using System.Collections.Generic;

#nullable disable

namespace cSharpStoreBackend.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int IdCategory { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

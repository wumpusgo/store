using System;
using System.Collections.Generic;

#nullable disable

namespace cSharpStoreBackend.Models
{
    public partial class Product
    {
        public Product()
        {
            Bills = new HashSet<Bill>();
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double? UnitCost { get; set; }
        public int? IdCategory { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}

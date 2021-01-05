using System;
using System.Collections.Generic;

#nullable disable

namespace cSharpStoreBackend.Models
{
    public partial class Bill
    {
        public int IdBill { get; set; }
        public int? Quantity { get; set; }
        public string Product { get; set; }

        public virtual Product ProductNavigation { get; set; }
    }
}

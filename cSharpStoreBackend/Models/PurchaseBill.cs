using System;
using System.Collections.Generic;

#nullable disable

namespace cSharpStoreBackend.Models
{
    public partial class PurchaseBill
    {
        public int PurchaseIdPurchase { get; set; }
        public int BillIdBill { get; set; }

        public virtual Bill BillIdBillNavigation { get; set; }
        public virtual Purchase PurchaseIdPurchaseNavigation { get; set; }
    }
}

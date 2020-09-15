using System;

namespace RepairsAccounting.Library.Models
{
    public class RepairPrinterModel : IRepair
    {
        public int RepairId { get; set; }
        public DateTime RepairDate { get; set; }
        public string RepairCost { get; set; }
        public string RepairCompany { get; set; }
        public string Comment { get; set; }

        public int PrinterId { get; set; }
    }
}

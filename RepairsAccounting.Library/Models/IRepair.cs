using System;

namespace RepairsAccounting.Library.Models
{
    public interface IRepair
    {
        int RepairId { get; set; }
        DateTime RepairDate { get; set; }
        string RepairCost { get; set; }
        string RepairCompany { get; set; }
        string Comment { get; set; }
    }
}

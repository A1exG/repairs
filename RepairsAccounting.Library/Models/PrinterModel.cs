using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairsAccounting.Library.Models
{
    public class PrinterModel : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string InventoryNumber { get; set; }
        public string VendorName { get; set; }
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
    }
}

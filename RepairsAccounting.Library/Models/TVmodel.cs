
namespace RepairsAccounting.Library.Models
{
    public class TVmodel : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string InventoryNumber { get; set; }
        public string VendorName { get; set; }
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }

    }
}

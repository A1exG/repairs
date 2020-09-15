
namespace RepairsAccounting.Library.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        string DisplayName { get; set; }
        string InventoryNumber { get; set; }
        string VendorName { get; set; }
        string ModelName { get; set; }
        string SerialNumber { get; set; }

    }
}

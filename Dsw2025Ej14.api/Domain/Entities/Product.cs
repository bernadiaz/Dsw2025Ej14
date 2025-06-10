namespace Dsw2025Ej14.api.Domain.Entities
{
    public class Product
    {
        private string Sku { get; set; }
        private string Name { get; set; }
        private decimal CurrentUnitPrice { get; set; }
        private bool IsActive { get; set; }
    }
}

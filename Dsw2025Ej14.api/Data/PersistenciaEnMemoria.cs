using System.Text.Json;
using Dsw2025Ej14.api.Domain.Entities;
using Dsw2025Ej14.api.Domain.Interfaces;

namespace Dsw2025Ej14.api.Data
{
    public class PersistenciaEnMemoria : IPersistencia
    {
        private static PersistenciaEnMemoria _instancia = null;

        private List<Product> productos;

        private PersistenciaEnMemoria()
        {
            productos = new List<>();
            LoadProducts();
        }

        public Product getProducts => throw new NotImplementedException();

        public static PersistenciaEnMemoria getInstance()
        {
            if (_instancia == null)
            {
                _instancia = new PersistenciaEnMemoria();
            }
            return _instancia;
        }

        public void LoadProducts()
        {
            var json = File.ReadAllText("Data\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];
        }
    }
}

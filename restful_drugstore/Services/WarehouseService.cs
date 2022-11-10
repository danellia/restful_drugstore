using MongoDB.Driver;
using restful_drugstore.Models;

namespace restful_drugstore.Services
{
    public class WarehouseService : IService
    {
        IMongoDatabase db;
        private readonly IMongoCollection<Warehouse> collection;
        public WarehouseService(IDatabaseSettings settings, IMongoClient client)
        {
            var db = client.GetDatabase(settings.DatabaseName);
            collection = db.GetCollection<Warehouse>(settings.CollectionName);
        }

        public List<Warehouse> Get(string MedId)
        {
            return collection.Find(warehouse => warehouse.Id == MedId).FirstOrDefault<Warehouse>();
        }
    }
}

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restful_drugstore.Models;

public class Medicine
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public bool NeedPrescription { get; set; }

    public string Application { get; set; } = null!;

    public string Image { get; set; } = null!;

    public double Price { get; set; }

    public List<Warehouse> Warehouses { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Warehouse Warehouse { get; set; } = null!;
}

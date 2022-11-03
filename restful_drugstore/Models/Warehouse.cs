using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restful_drugstore.Models;

public class Warehouse
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string WorkHours { get; set; } = null!;

    public List<Medicine> Medicine { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Medicine Med { get; set; } = null!;

    public double Quantity { get; set; }
}

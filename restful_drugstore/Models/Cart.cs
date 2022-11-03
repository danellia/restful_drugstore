using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restful_drugstore.Models;

public class Cart
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public Customer Customer { get; set; } = null!;

    public List<Medicine> Medicine { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Medicine Med { get; set; } = null!;

    public double Quantity { get; set; }
}
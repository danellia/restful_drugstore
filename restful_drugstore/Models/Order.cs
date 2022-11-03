using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restful_drugstore.Models;

public class Order
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonRepresentation(BsonType.ObjectId)]
    public Customer Customer { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Warehouse Point { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime EstimatedDelivery { get; set; }

    public DateTime RealDelivery { get; set; }

    public List<Medicine> Medicine { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Medicine Med { get; set; } = null!;

    public double Quantity { get; set; }
}

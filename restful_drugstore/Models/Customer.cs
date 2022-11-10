using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace restful_drugstore.Models;

public class Customer
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string AccountType { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    [BsonRepresentation(BsonType.ObjectId)]
    public Warehouse DefaultPoint { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

}

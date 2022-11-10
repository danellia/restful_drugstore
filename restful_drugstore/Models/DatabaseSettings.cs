namespace restful_drugstore.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DatabaseName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string CollectionName { get; set; } = String.Empty;
    }
}

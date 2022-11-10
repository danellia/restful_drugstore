using restful_drugstore.Models;

namespace restful_drugstore.Services
{
    public interface IService
    {
        List<Warehouse> Get(String MedId);
    }
}

using DataLayer.Dtos;
using DataLayer.Entities;
namespace DataLayer.Mapping
{
    public static class ServicesMappingExtensions
    {
        public static ServiceDto ToServiceDto(this Service service)
        {
            if (service == null) return null;
            
            var result = new ServiceDto
            {
                Provider = service.Provider,
                Name = service.Name,
                Description = service.Description
            };

            return result;
        }
    }
}

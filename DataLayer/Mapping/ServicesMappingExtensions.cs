using DataLayer.Dtos;
using DataLayer.Entities;
namespace DataLayer.Mapping
{
    public static class ServicesMappingExtensions
    {
        public static List<ServiceDto> ToServiceDtos(this List<Service> services)
        {
            if (services == null) return null;

            var results = services.Select(e => e.ToServiceDto()).ToList();

            return results;
        }
        public static ServiceDto ToServiceDto(this Service service)
        {
            if (service == null) return null;
            
            var result = new ServiceDto
            {
                Provider = service.Provider.ToProviderDto(),
                Name = service.Name,
                Description = service.Description
            };

            return result;
        }
    }
}

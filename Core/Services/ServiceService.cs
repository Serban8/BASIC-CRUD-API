using DataLayer.Dtos;
using DataLayer.Entities;
using DataLayer.Mapping;
using DataLayer.Repositories;

namespace Core.Services
{
    public class ServiceService
    {
        private ServicesRepository servicesRepository { get; set; }

        public ServiceService(ServicesRepository servicesRepository)
        {
            this.servicesRepository = servicesRepository;
        }

        public List<ServiceDto> GetAll()
        {
            var services = servicesRepository.GetAll();

            return services.ToServiceDtos();
        }

        public ServiceDto GetById(int serviceId)
        {
            var service = servicesRepository.GetById(serviceId);

            return service.ToServiceDto();
        }

        public bool EditDescription(ServicedDescriptionUpdateDto payload)
        {
            if (payload == null || payload.Id == null || payload.Description == null) return false;

            var serviceToUpdate = servicesRepository.GetById(payload.Id);
            if (serviceToUpdate == null) return false;

            serviceToUpdate.Description = payload.Description;

            return true;
        }
    }
}
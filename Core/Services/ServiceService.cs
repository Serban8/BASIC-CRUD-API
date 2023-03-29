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

        public List<Service> GetAll()
        {
            return servicesRepository.GetAll();
        }

        public ServiceDto GetById(int serviceId)
        {
            var service = servicesRepository.GetById(serviceId);

            var result = service.ToServiceDto();

            return result;
        }
    }
}
using DataLayer.Entities;

namespace DataLayer.Repositories
{
    public class ServicesRepository
    {
        public List<Service> GetAll()
        {
            var results = AppDbContext.Services;

            return results;
        }

        public Service GetById(int serviceId)
        {
            var result = AppDbContext.Services
                .Where(e => e.Id == serviceId)
                .FirstOrDefault();

            return result;
        }

        public bool Delete(int serviceId)
        {
            var serviceToDelete = GetById(serviceId);

            if (serviceToDelete == null) return false;

            AppDbContext.Services.Remove(serviceToDelete);

            return true;
        }
    }
}

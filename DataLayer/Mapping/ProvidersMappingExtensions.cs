using DataLayer.Entities;
using DataLayer.Dtos;

namespace DataLayer.Mapping
{
    public static class ProvidersMappingExtensions
    {
        public static ProviderDto ToProviderDto(this Provider provider)
        {
            if (provider == null) return null;

            var result = new ProviderDto
            {
                Id = provider.Id,
                Name = provider.Name,
                Email = provider.Email,
                Phone = provider.Phone,
                Description = provider.Description,
                Rating = provider.Rating
            };

            return result;
        }
    }
}

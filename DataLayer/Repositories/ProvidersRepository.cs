using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class ProvidersRepository
    {
        public List<Provider> GetAll()
        {
            var results = AppDbContext.Providers;

            return results;
        }

        public Provider GetById(int providerId)
        {
            var result = AppDbContext.Providers
                .Where(e => e.Id == providerId)
                .FirstOrDefault();

            return result;
        }
    }
}

using DataLayer.Entities;
using System.Diagnostics;

namespace DataLayer
{
    public class AppDbContext
    {
        public static List<Provider> Providers = new List<Provider>
        {
            new Provider {
                Id = 1,
                Name = "GigelFix",
                Email = "support@gigelfix.com",
                Password = "1234",
                Phone = "0711111111",
                Address = "Strada 1, nr. 1, Brasov",
                Description = "GigelFix repara orice",
                Rating = 4.5f
            },
            new Provider {
                Id = 2,
                Name = "MarcelInstal",
                Email = "support@marcelinstal.com",
                Password = "1234",
                Phone = "0722222222",
                Address = "Strada 2, nr. 2, Brasov",
                Description = "MarcelInstal te scapa din belele",
                Rating = 4.1f
            },
            new Provider {
                Id = 3,
                Name = "IonelService",
                Email = "support@ionelservice.com",
                Password = "1234",
                Phone = "0733333333",
                Address = "Strada 3, nr. 3, Brasov",
                Description = "IonelService te ajuta sa nu faci accident",
                Rating = 3.9f
            }
        };

        public static List<Service> Services = new List<Service>
        {
            new Service {
                Id = 1,
                ProviderId = 1,
                Provider = Providers[0],
                Name = "Montat usa",
                Description = "Montez usi ieftin",
                Price = 200,
                Duration = new TimeSpan(1, 30, 0)
            },
            new Service {
                Id = 2,
                ProviderId = 3,
                Provider = Providers[2],
                Name = "Schimbat cauciucuri",
                Description = "E vara sau iarna??",
                Price = 70,
                Duration = new TimeSpan(1, 0, 0)
            },
            new Service {
                Id = 3,
                ProviderId = 2,
                Provider = Providers[1],
                Name = "Reperat teava",
                Description = "Curatam balta din baie",
                Price = 180,
                Duration = new TimeSpan(2, 0, 0)
            },
            new Service {
                Id = 4,
                ProviderId = 3,
                Provider = Providers[2],
                Name = "Schimb ulei",
                Description = "Fa-ti masina sa mearga ca unsa",
                Price = 150,
                Duration = new TimeSpan(2, 0, 0)
            }
        };
    }
}
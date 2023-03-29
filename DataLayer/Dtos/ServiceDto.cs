using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Dtos
{
    public class ServiceDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ProviderDto Provider { get; set; }
    }
}

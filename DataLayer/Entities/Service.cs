using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public TimeSpan Duration { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
    }
}

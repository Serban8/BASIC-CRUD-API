using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ServicedDescriptionUpdateDto
    {
        public int Id { get; set; } //poate trb adaugat required si aici

        [Required, MaxLength(300)]
        public string Description { get; set; }
    }
}
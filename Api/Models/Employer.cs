using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Employer:BaseEntity
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        public string BookName { get; set; }
        public int BookPrice { get; set; }
        public int BookID { get; set; }
    }
}

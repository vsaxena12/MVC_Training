using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace consumeAPI.Models
{
    public class Employees
    {
        [Required]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string designation { get; set; }
    }
}

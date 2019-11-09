﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIConsuming.Models
{
    public class Employee
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string designation { get; set; }
        [Required]
        public DateTime DOJ { get; set; }
        [Required]
        public int salary { get; set; }
        [Required]
        public int bonus { get; set; }
    }
}

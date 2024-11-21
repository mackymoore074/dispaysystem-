﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } // Employee's first name
        [Required]
        [StringLength(100)]
        public string LastName { get; set; } // Employee's last name
        [Required]
        [EmailAddress]
        public string Email { get; set; } // Employee's email address
        public DateTime DateCreated { get; set; }
        public List<Department> Departments { get; set; } // Departments the employee is associated with
    }
}

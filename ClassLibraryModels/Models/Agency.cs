using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassLibraryModels.Models
{
    public class Agency
    {
        public Agency()
        {
            Departments = new List<Department>();
            Locations = new List<Location>();
            Admins = new List<Admin>();
            NewsItems = new List<NewsItem>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<Location> Locations { get; set; }
        public ICollection<Admin> Admins { get; set; }
        public ICollection<NewsItem> NewsItems { get; set; }
        public DateTime DateCreated { get; internal set; }
    }
}

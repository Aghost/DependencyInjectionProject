using System;
using System.Linq;
using System.Collections.Generic;
using DependancyInjectionProject.Data;
using DependancyInjectionProject.Data.Models;
// Id
// Name
// Data
namespace DependancyInjectionProject.Data.Models {
    public class Movie {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }

        public List<Review> Review { get; set; }
    }
}

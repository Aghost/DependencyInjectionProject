using System.Collections.Generic;
using DependancyInjectionProject.Data;
using DependancyInjectionProject.Data.Models;

namespace DependancyInjectionProject.Services {
    public interface IMovieService {
        public List<Movie> GetAll();
        public Movie Get(int Id);
        public Movie Get(string Name);
        public void Add(Movie movie);
        public void Delete(int Id);
    }
}

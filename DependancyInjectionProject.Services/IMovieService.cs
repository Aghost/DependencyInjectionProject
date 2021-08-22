using System.Collections.Generic;
using DependancyInjectionProject.Data;
using DependancyInjectionProject.Data.Models;

namespace DependancyInjectionProject.Services {
    public interface IMovieService {
        public List<Movie> GetAllMovies();
        public Movie GetMovie(int Id);
        public void AddMovie(Movie movie);
        public void DeleteMovie(int Id);
    }
}

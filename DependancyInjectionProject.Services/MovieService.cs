using System;
using System.Linq;
using System.Collections.Generic;
using DependancyInjectionProject.Data;
using DependancyInjectionProject.Data.Models;

namespace DependancyInjectionProject.Services
{
    public class MovieService : IMovieService
    {
        private readonly DependancyInjectionProjectDbContext _db;

        public MovieService(DependancyInjectionProjectDbContext db) {
            _db = db;
        }

        public List<Movie> GetAllMovies() {
            return _db.Movies.ToList();
        }

        public Movie GetMovie(int Id) {
            //OR var Movie = _db.Movies.FirstOrDefault(movie => movie.Id == Id);
            return _db.Movies.Find(Id);
        }

        public void AddMovie(Movie movie) {
            _db.Add(movie);
            _db.SaveChanges();
        }

        public void DeleteMovie(int Id) {
            var movieToDelete = _db.Movies.Find(Id);
            if (movieToDelete != null) {
                _db.Remove(movieToDelete);
            }
            throw new InvalidOperationException("no movies exists");
        }
    }
}

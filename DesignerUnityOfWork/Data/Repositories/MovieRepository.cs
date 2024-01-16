using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignerUnityOfWork.Interfaces;
using DesignerUnityOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignerUnityOfWork.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly AppDbContext _context;

        public MovieRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Movie?> Create(Movie entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Movie entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Movie?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetTopMovieInYear(int year, int count)
        {
            return _context.Movies.Where(x => x.ReleaseDate.Year == year)
                .Include(x => x.Genre)
                    .Include(x => x.Director)
                        .OrderByDescending(x => x.ReleaseDate.Year)
                            .Take(count).ToList();
        }

        public void Update(Movie entity)
        {
            throw new NotImplementedException();
        }
    }
}
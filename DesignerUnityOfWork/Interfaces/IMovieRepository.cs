using DesignerUnityOfWork.Interfaces.Repositories;
using DesignerUnityOfWork.Models;

namespace DesignerUnityOfWork.Interfaces;
public interface IMovieRepository : IRepository<Movie>
{
    IEnumerable<Movie> GetTopMovieInYear(int year, int count);
}
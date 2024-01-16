namespace DesignerUnityOfWork.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Language { get; set; }
    public int Rating { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int GenreId { get; set; }
    public int DirectorId { get; set; }
    public required virtual Director Director { get; set; }
    public required virtual Genre Genre { get; set; }
}
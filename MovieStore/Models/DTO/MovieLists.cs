using MovieStore.Models.DataDB;

namespace MovieStore.Models.DTO
{
    public class MovieLists 
    { 
    public IQueryable<Movie> MovieList { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
    public string? Term { get; set; }


    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    [Range(0.01, 999.99, ErrorMessage = "Price must be between £0.01 to £999.99")]
    public decimal Price { get; set; }
    public string? Rating { get; set; }
}

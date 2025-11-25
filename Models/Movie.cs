namespace CinemaApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Genre { get; set; } = string.Empty;

        public int ReleaseYear { get; set; }

        public string Country { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public decimal BoxOfficeReceipts { get; set; }

    }
}

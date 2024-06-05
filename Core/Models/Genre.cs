﻿namespace Core.Models
{
    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; } = null!;

        public ICollection<BookGenre>? BookGenres { get; set; }
    }
}

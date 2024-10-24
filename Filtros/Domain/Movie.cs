﻿namespace Domain
{
    public class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public List<string> Genres { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Movie movie &&
                   Title == movie.Title;
        }
    }
}

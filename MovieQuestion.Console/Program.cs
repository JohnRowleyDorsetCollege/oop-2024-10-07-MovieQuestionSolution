// See https://aka.ms/new-console-template for more information
using MovieQuestion.Domain;

Console.WriteLine("Movie Question");

Movie m = new Movie() { Director = "Director 1", RunningTime = 0, Rating = "PG" };
m.SetRunningTime(150);
m.SetRating("PG");

Console.WriteLine(m);

Movie m1 = new Movie() { Director = "Director 2", RunningTime = 0, Rating = "PG" };
m1.SetRunningTime(190);
m1.SetRating("PG-13");

Console.WriteLine(m1);

Movie m2 = new Movie() { Director = "Director 3", RunningTime = 0, Rating = "PG" };
m2.SetRunningTime(190);
m2.SetRating("NC_17");

Console.WriteLine(m2);

List<Movie> listOfMovies = new() { m, m1, m2 };

foreach(Movie movie in listOfMovies)
{
    Console.WriteLine(movie);
}

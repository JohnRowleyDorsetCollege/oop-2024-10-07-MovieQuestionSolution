using MovieQuestion.Domain;

namespace MovieQuestion.Tests
{
    public class MovieUnitTests
    {
        [Fact]
        public void MovieSetRating_Sets_The_Correct_Rating()
        {
            Movie testMovie = new Movie();

            testMovie.SetRating("PG");

            Assert.Equal("PG", testMovie.Rating);
        }

        [Fact]
        public void MovieSetRating_Throws_Exception_When_Rating_Is_Incorrect()
        {
            Movie testMovie = new Movie();

            Assert.Throws<InvalidDataException>(() => testMovie.SetRating("INVALIDRATING"));


        }
    }
}
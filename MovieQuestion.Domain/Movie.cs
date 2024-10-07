namespace MovieQuestion.Domain
{

    public abstract class BaseMovie {

    }
    public class Movie : BaseMovie
    {
        public string Director { get; set; }
        public int RunningTime { get; set; }
        public string Rating { get; set; }
        public Movie()
        {
                
        }

        public void SetRunningTime(int _runningTime)
        {
            RunningTime = _runningTime;
        }

        public void SetRating(string _rating)
        {
            List<string> validRatings = new List<string>()
            {
                "G",
                "PG",
                "PG-13",
                "R",
                "NC_17"

            };

            if (validRatings.Contains(_rating) ) {
                Rating = _rating;
            } else
            {
                throw new InvalidDataException();
            }

        }

        public override string ToString() {
            return $"{Rating}:{RunningTime}";
        }

    }
}

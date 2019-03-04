namespace Brainzzler.Models
{
    public class Score
    {
        public int Id { get; set; }
        public double CurrentScore { get; set; }
        public double MaxScore { get; set; }
        public string Note { get; set; } //възможност за рецензия
    }
}
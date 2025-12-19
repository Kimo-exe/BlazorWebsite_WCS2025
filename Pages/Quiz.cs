namespace Blazor.Models
{
    public class Quiz
    {
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public bool Answer { get; set; }
        public int QuestionCounter { get; set; }

        public int AddScore(int counter)
        {
            counter++;

            return counter;
        }
    }
}

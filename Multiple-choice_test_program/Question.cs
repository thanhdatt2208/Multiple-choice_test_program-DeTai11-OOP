public class Question
    {
        public int Id { get; set;}
        public string QuestionText { get; set; }
        public Question(int id,string questionText)
        {
            Id = id;
            QuestionText = questionText;
        }
        public virtual void DisplayQuestion()
        {
            Console.WriteLine(QuestionText);
        }
    }
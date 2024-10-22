public class MultipleChoiceQuestion : Question
{
    public List<string> Choices { get; set; }
    public Answer CorrectAnswer { get; set; }

    public MultipleChoiceQuestion(int id, string questionText, List<string> choices, string correctAnswer)
        : base(id, questionText)
    {
        Choices = choices;
        CorrectAnswer = new Answer(correctAnswer);
    }
    public override void DisplayQuestion()
    {
        base.DisplayQuestion();
        for (int i = 0; i < Choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[i]}");
        }
    }
}
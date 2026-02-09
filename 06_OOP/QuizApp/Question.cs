namespace _06_OOP.QuizApp;

internal class Question
{
    // read-only properties
    public string QuestionText { get; }
    public string[] Answers { get; }
    public int CorrectAnswerIndex { get; set; }

    public Question(string questionText, string[] answers, int correctAnswerIndex)
    {
        QuestionText = questionText;
        Answers = answers;
        CorrectAnswerIndex = correctAnswerIndex;
    }

    public bool IsCorrectAnswer(int choice)
    {
        return CorrectAnswerIndex == choice;
    }
}
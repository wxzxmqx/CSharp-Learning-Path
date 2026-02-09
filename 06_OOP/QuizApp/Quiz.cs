namespace _06_OOP.QuizApp;

internal class Quiz
{
    private Question[] _questions;
    private int _score;
    
    public Quiz(Question[] questions)
    {
        this._questions = questions;
        _score = 0;
    }

    public void StartQuiz()
    {
        Console.WriteLine("Welcome to the Quiz!");
        int questionNumber = 1; // display question number

        foreach (Question question in _questions)
        {
            Console.WriteLine($"Question #{questionNumber++}:");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();

            if (question.IsCorrectAnswer(userChoice))
            {
                SetColor(ConsoleColor.Green);
                Console.WriteLine("\nCorrect!\n");
                ResetColor();
                _score++;
            }
            else
            {
                SetColor(ConsoleColor.Red);
                Console.Write($"\nWrong! ");
                ResetColor();
                Console.Write($"The correct answer was: ");
                SetColor(ConsoleColor.DarkBlue);
                Console.WriteLine($"{question.Answers[question.CorrectAnswerIndex]}\n");
                ResetColor();

            }
        }
        
        DisplayResults();
    }

    private void DisplayResults()
    {
        SetColor(ConsoleColor.Magenta);
        Console.WriteLine("=============================");
        Console.WriteLine("||          RESULTS        ||");
        Console.WriteLine("=============================");
        Console.ResetColor();

        Console.WriteLine($"Quiz finished. Your score is {_score} out of {_questions.Length}");
        double percentage = (double)_score / _questions.Length;
        if (percentage >= 0.8)
        {
            SetColor(ConsoleColor.Green);
            Console.Write("Excellent work!");
        } else if (percentage >= 0.5)
        {
            SetColor(ConsoleColor.Yellow);
            Console.Write("Good effort!");
        }
        else
        {
            SetColor(ConsoleColor.Red);
            Console.Write("Keep practicing!");
        }
    }

    public void DisplayQuestion(Question question)
    {
        SetColor(ConsoleColor.Yellow);
        Console.WriteLine("===================================");
        Console.WriteLine("||            Question           ||");
        Console.WriteLine("===================================");
        Console.ResetColor();
        
        Console.WriteLine(question.QuestionText);

        for (int i = 0; i < question.Answers.Length; i++)
        {
            // Setting the color to DarkBlue
            SetColor(ConsoleColor.DarkBlue);
            Console.Write("     ");
            Console.Write(i + 1);
            ResetColor();
            Console.WriteLine($". {question.Answers[i]}");
        }
    }

    public int GetUserChoice()
    {
        Console.Write("Your answer (number): ");
        string? input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice) || (choice < 1 || choice > 4))
        {
            SetColor(ConsoleColor.Red);
            Console.WriteLine("\nInvalid choice.");
            ResetColor();
            Console.Write("Please enter a number between 1 and 4: ");
            input = Console.ReadLine();
        }

        return choice -1;

    }

    void ResetColor() => Console.ResetColor();
    void SetColor(ConsoleColor color) => Console.ForegroundColor = color;
}
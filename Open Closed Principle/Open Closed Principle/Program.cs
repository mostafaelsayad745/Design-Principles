namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quiz = new SOLID.OCP.After.Quiz(SOLID.OCP.After.QuestionBank.Generate());
            quiz.Print();

        }
    }
}
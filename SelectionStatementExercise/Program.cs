namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess the number I'm thinking of, 1 through 1000.");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            bool incorrect = true;
            while (incorrect)
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("too low, guess again");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high, guess again");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}

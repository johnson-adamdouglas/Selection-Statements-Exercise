namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess the number I'm thinking of, 1 through 100.");
            var r = new Random();
            var favNumber = r.Next(1, 100);
            bool incorrect = true;
            while (incorrect)
            {
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}

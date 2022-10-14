namespace SelectionStatementExercise
{
    internal class Program
    {
        
       static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the number guessing game");
            Console.WriteLine("To continue please enter an upper limit number for the app.");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);
            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Now enter your guess and see below what you win.");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)
            {
                Console.WriteLine("Your guess is to high.");
            }
            if (guess < number)
            {
                Console.WriteLine("Your guess is to low!");

            }
             
            else 
            {
                Console.WriteLine("You're Correct");
            }
        }
    }
}
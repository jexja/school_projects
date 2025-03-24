namespace INFO2200_Participation1_CSharp_JexJacob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the title text
            Console.WriteLine("Welcome to Jacob's State Capital Lookup Application");
            Console.WriteLine();
            // Grab the user's input
            Console.Write("Please enter a state and I will return the capital! (x to exit): ");
            string userInput = Console.ReadLine();

            // Load up all the states and capitals
            Dictionary<string, string> stateCapitalDictionary = new Dictionary<string, string>();
            StreamReader reader = new StreamReader("statecaps.txt");
            while (reader.EndOfStream != true) 
            {
                // Read the current line
                string line = reader.ReadLine();
                string[] tempStateCap = line.Split(",");
                string state = tempStateCap[0];
                string capital = tempStateCap[1];
                stateCapitalDictionary.Add(state.ToUpper(), capital.ToUpper());
            }
            reader.Close();

            // Check the user's input against the states and capitals
            while (userInput != "x")
            {

                // Display the state and capital
                if (stateCapitalDictionary.TryGetValue(userInput.ToUpper(), out string cap)) 
                {
                    Console.WriteLine($"State: {userInput.ToUpper()}");
                    Console.WriteLine($"Capital: {cap}");
                }
                else
                {
                    Console.WriteLine($"Could not find {userInput} in the text file! Please try again.");
                }
                // Prompt the user again
                Console.WriteLine("Please enter a state and I will return a capital! (x to exit): ");
                userInput = Console.ReadLine();
            }

            // Goodbye message
            Console.WriteLine("Thank you for playing!");


        }
    }
}
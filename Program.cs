namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "IfElse";
            Console.Write("Please enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now enter a letter:");
            char letter = Convert.ToChar(Console.ReadLine());

            if(num>=6)
            { Console.WriteLine("\nNumber exceeds 5");
                if(letter == 'C')
                { Console.WriteLine("Letter is 'C'");
                }
            }
            else
            { Console.WriteLine("\nNumber is 5 or less");
            }
            Console.ReadKey();

        }
    }
}
// See https://aka.ms/new-console-template for more information
//-----------------------------------------------------------------
//ForExercise
//
// Name: David Zientara
// Date: 7-4-2022
// Comments: Made a simple loop 
// Note the $ at the beginning of the line; means the string following
// it is an interpolated string
//-----------------------------------------------------------------

namespace ForExercise
{
    class Program
    {
        public static void Main(String[] args)
        {
            for (int i = 0; i < 15; i++)
                Console.WriteLine($"{i}");
        }
    }
}

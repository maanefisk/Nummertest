using System;

namespace Nummertest
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                string pinCodeSelection = Console.ReadLine();
                int n;
                bool isNumeric = Int32.TryParse(pinCodeSelection, out n);

                if (isNumeric == false)
                {
                    Console.WriteLine("Please enter a valid numerical 4 digit value!");
                }
                else { Console.WriteLine("Your PIN is" + "\n" + pinCodeSelection + "\n" + n); }
            }


            // CTRL + K + D = Retter opp
        }
    }
}

using System;

namespace lucky7
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumberOfSevens = 0;
            Random rng = new Random();

            int dice1;
            int dice2;

            for(int i = 1; i <= 100; i++)
            {
                dice1 = rng.Next(1, 7);
                dice2 = rng.Next(1, 7);

                if(dice1 + dice2 == 7)
                totalNumberOfSevens++;
            }

            Console.WriteLine("Out of 100 rolls, you rolled {0} sevens ", totalNumberOfSevens);
            Console.ReadLine();
        }
    }
}

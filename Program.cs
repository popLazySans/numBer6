using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            string prefab = Console.ReadLine();
            int Lenge = int.Parse(Console.ReadLine());
            int high = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            for (int i =1;i <= num; i++)
            {
                for(int j = 1; j <= high; j++)
                {
                    for (int k = 1; k<=Lenge*i; k++)
                    {
                        Console.Write(prefab);
                    }
                    Console.WriteLine("");
                }
                
            }
        }
    }
}

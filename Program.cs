using System;

namespace Ucgen
{
    class Program
    {
        static void Main(string[] args)
        {
            int  size;
            Console.WriteLine("Lütfen Boyut giriniz");
            size=int.Parse(Console.ReadLine());
            Console.WriteLine();
            Ucgen(size);
        }
        static void Ucgen(int x)
        {
            i:
            Console.WriteLine("Lütfen üçgeninizi Seçiniz. (1 veya 2)");
            int choice=int.Parse(Console.ReadLine());
            if (choice==1)
            {
                for (int i = 1; i <= x; i++)
                {
                    for (int k = 0; k < 2*i-1; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (choice==2)
            {
                int a=0;
               for (int i = 0; i < x; i++)
               {
                for (int j = 1; j <= x-a; j++)
                {
                    Console.Write(" ");
                }
                a++;
                
                for (int k = 0; k <2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               }
            }
            else
            {
                Console.WriteLine("Böyle bir seçenek yok");
                 goto i ;
            }
        }


    }
}
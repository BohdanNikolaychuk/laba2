using System;

namespace oopLaba2_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть номер прізвища в списку");
           
            int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("Б");
                    break;
                case 3:
                    Console.WriteLine("В");
                    break;
                case 4:
                    Console.WriteLine("Г");
                    break;
                case 5:
                    Console.WriteLine("Д");
                    break;
                default:
                    Console.WriteLine("не введений номер");
                    break;
            }

        }
    }
}

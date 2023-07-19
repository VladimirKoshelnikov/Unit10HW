using System;
using System.IO;

namespace Task2{
    class Program{
        static Logger logger{get; set;}

        static void Main(){
            logger = new Logger(); 
            Calculate calculate = new Calculate(logger);
            int num1, num2;
            try{
                Console.WriteLine("Введите число 1");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                num2 = int.Parse(Console.ReadLine());

                Console.WriteLine($"Сумма чисел {num1} и {num2} = {calculate.Add(num1, num2)}" );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           

            Console.ReadKey();
        }
    }
}
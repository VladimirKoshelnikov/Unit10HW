using System;
using System.IO;

namespace Task1{
    class Program{

        static void Main(){
            Calculate calculate = new Calculate();
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

            Console.ReadLine();
        }
    }
}
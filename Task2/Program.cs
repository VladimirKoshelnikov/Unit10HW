using System;
using System.IO;

namespace Task2{
    class Program{
        static Logger logger{get; set;}

        static void Main(){
            logger = new Logger(); 
            bool isCalculationOk = true;
            int num1, num2, result = 0;
            Calculate calculate = new Calculate(logger);
            try{
                Console.WriteLine("Введите число 1");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                num2 = int.Parse(Console.ReadLine());
                result = calculate.Add(num1, num2);
                Console.WriteLine($"Сумма чисел {num1} и {num2} = {result}" );  
            }
            catch(Exception ex){
                logger.Error(ex.Message);
            }            
            Console.ReadKey();

            /*Не получилось вызвать OverflowException
            Произошло событие: Калькулятор начал работу
            Вывод программы:
            Введите число 1
            2000000000
            Введите число 2 
            2000000000
            Произошло событие: Калькулятор запустил метод Add
            Сумма чисел 2000000000 и 2000000000 = -294967296
            */
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    public class Logger:ILogger{
        public void Event(string _event){
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Произошло событие: {_event}");
            Console.ForegroundColor = defaultColor;
        }
        public void Error(string _error){            
            var defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Произошла ошибка: {_error}");
            Console.ForegroundColor =defaultColor;
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    public class Logger:ILogger{
        public void Event(string _event){
            Console.WriteLine($"Произошло событие: {_event}");
        }
        public void Error(string _error){
            
            Console.WriteLine($"Произошла ошибка: {_error}");
        }
    }

}
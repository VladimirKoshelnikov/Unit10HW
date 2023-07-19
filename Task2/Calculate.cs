using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{

    class Calculate:ICalculate{
        ILogger Logger{set; get;}

        public int Add(int num1, int num2)
        {
            Logger.Event("Калькулятор запустил метод Add");
            return num1 + num2; 
        }
            
        public Calculate(Logger logger){
            Logger = logger;
            Logger.Event("Калькулятор начал работу");
        }

    }
        
}
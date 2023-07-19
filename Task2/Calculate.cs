using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{

    class Calculate:ICalculate{
        ILogger Logger{set; get;}
        public int Add(int num1, int num2){
                
            Logger.Event($"На вход подано два числа: {num1} и {num2}");
            int result = 0;
            try{
                result = num1 + num2;
            }
            catch(Exception ex){
                Logger.Error(ex.Message);
            }
                
            return result;
                
        }
            
        public Calculate(Logger logger){
            Logger = logger;
            Logger.Event("Калькулятор начал работу");
        }

    }
        
}
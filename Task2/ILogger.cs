using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    public interface ILogger
    {
        public void Event(string _event);
        public void Error(string _error);
    }
}
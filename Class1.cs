using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_ВОТ
{


    public class Calculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subract(int a, int b)
        {
            return a - b;
        }
    }
}

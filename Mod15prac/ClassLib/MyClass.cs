using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class MyClass
    {
        private int privateF;
        public string publicF;

        private string PrivateProp { get; set; }
        public int PublicProp { get; set; }



        public MyClass()
        {
        }

        private MyClass(int value)
        {
            PublicProp = value;
        }

        private string PrivateMethod()
        {
            return "Приватный метод";
        }

        public void PublicMethod()
        {
            Console.WriteLine("Публичный метод");
        }

        private void PrivateMethod2()
        {
            Console.WriteLine("Второй приватный метод");
        }
    }
}
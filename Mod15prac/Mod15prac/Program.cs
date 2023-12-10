using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLib;



namespace prak15cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type classType = typeof(MyClass);
            object obj = Activator.CreateInstance(classType);

            // Accessing and modifying the PublicProp property
            var publicProp = classType.GetProperty("PublicProp");
            Console.WriteLine($"Значение PublicProp до изменений: {publicProp.GetValue(obj)}");
            publicProp.SetValue(obj, 10);
            Console.WriteLine($"Значение PublicProp после изменений: {publicProp.GetValue(obj)}");

            // Invoking the PublicMethod
            classType.GetMethod("PublicMethod").Invoke(obj, null);

            // Invoking the PrivateMethod with BindingFlags
            var privateMethod = classType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            string result = (string)privateMethod.Invoke(obj, null);

            // Invoking the PrivateMethod2 with BindingFlags
            var privateMethod2 = classType.GetMethod("PrivateMethod2", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod2.Invoke(obj, null);
        }
    }
}

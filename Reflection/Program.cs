using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2()); //constructordan gelen parametreleri kullanır
            //Console.WriteLine(dortIslem.Topla(3, 6));

            // ÇAlışma anında yapmak istiyorsak Reflectionla yapabiliriz, ama performansı iyi değil
            var type = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 3,4);
            //Console.WriteLine(dortIslem.Carp(3, 4));
            //Console.WriteLine(dortIslem.Carp2());

            var instance = Activator.CreateInstance(type, 3, 4);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");

            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.WriteLine("----------------------------");
            var methods = type.GetMethods();

            //DortIslem in tüm method ve parametrelerine ulaştık
            foreach (var info in methods)
            {
                Console.WriteLine("Method: {0}", info.Name);
                foreach (var parametersInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parametersInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute : {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }
    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        [MethodName("Parametresiz 2 sayıyı çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }
    [AttributeUsage(AttributeTargets.Method)]
    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); //parametre almayan ve void döndüren operasyonlara delegelik yapar
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; //yapılacak işleri belli şartlara göre toplayabiliriz

            myDelegate = myDelegate - customerManager.SendMessage;


            MyDelegate2 myDelegate2 = customerManager.SendMessage;

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;

            myDelegate();
            myDelegate2("naber");
            var sonuc = myDelegate3(5, 2);
            Console.WriteLine(sonuc);

            

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void SendMessage(string message)
        {
            Console.WriteLine("Selam " + message);
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful!");
        }

        
    }
    public class Matematik
    {
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); //parametre almayan ve void döndüren operasyonlara delegelik yapar
    public delegate void MyDelegate2(string text);
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; //yapılacak işleri belli şartlara göre toplayabiliriz

            myDelegate = myDelegate - customerManager.SendMessage;

            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage;
            myDelegate2("naber");

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
}

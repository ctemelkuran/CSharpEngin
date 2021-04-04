using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate(); //parametre almayan ve void döndüren operasyonlara delegelik yapar
    class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert; //yapılacak işleri belli şartlara göre toplayabiliriz
            myDelegate();

            Console.ReadLine();
        }
    }
    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Alert!");
        }
    }
}

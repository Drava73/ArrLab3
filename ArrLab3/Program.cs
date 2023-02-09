using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            KreditCard card1 = new KreditCard();
            try {
                Console.Write("Введите имя владельца карты:");
                card1.Name = Console.ReadLine();
                if(card1.Name == "" || card1.Name == "Name" || card1.Name =="admin") {
                    throw new Exception("Введите имя владельца карты!");
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);

            }
            Console.Write(card1);
            card1.Endcard = "24/12";
            Console.ReadLine();
        }
    }
}

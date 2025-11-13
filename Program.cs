using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                if (num % 2 == 0)
                    Console.WriteLine("The number is even");
                else
                    Console.WriteLine("The number is odd");
            }
            else if (num < 0)
                Console.WriteLine("The number is negative");
            else Console.WriteLine("0");

        }
        static void Task2()
        {
            Console.WriteLine("How much is the usage");
            int usage;
            double price;
            bool isBusiness;
            usage =int.Parse(Console.ReadLine());           
            if (usage > 0 && usage < 300)
                price = 0.5 * usage;
            else if (usage > 301 && usage < 600)
                price = 0.7 * usage;
            else
                price = 1 * usage;
            Console.WriteLine("Is it business");
            isBusiness = bool.Parse(Console.ReadLine());
            if (isBusiness == true)
                price = price+price * 0.15;
            else
                price = price+price * 0.05;
            Console.WriteLine("The price is: " + price);


        }
        static void Task3()
        {
            double cardPrice;
            bool inCityDrive, student, pensioner;
            Console.WriteLine("The drive is in city");
            inCityDrive = bool.Parse(Console.ReadLine());
            if (inCityDrive == true)
                cardPrice = 6;
            else
                cardPrice = 12;
            Console.WriteLine("Student?");
            student = bool.Parse(Console.ReadLine());
            if (student == true)
                cardPrice = cardPrice - cardPrice * 0.20;
            else
            {
                Console.WriteLine("Pensioner?");
                pensioner = bool.Parse(Console.ReadLine());
                if (pensioner == true)
                    cardPrice = cardPrice - cardPrice * 0.30;
                else
                    cardPrice = cardPrice;
            }
            Console.WriteLine("The final price is: " + cardPrice);
        }
        static void Task4()
        {
            int age;
            double price;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 18)
            {
                price = 120;
                Console.WriteLine("Are you in school");
                bool school = bool.Parse(Console.ReadLine());
                if (school == true)
                    price = price - price * 0.20;
                else price = price;
            }
            else if (age > 19 && age < 60)
            {
                price = 180;
                Console.WriteLine("Is it VIP");
                bool vip = bool.Parse(Console.ReadLine());
                if (vip == true)
                    price = price + price * 0.30;
                else
                    price = price;
            }
            else
            {
                price = 150;
                Console.WriteLine("IDF pensioner?");
                bool IDF = bool.Parse(Console.ReadLine());
                if (IDF == true)
                    price = price - price * 0.15;
                else
                    price = price;
            }
            Console.WriteLine("The final price is: " + price);

        }
        static void Main(string[] args)
        {
           
        }
    }
}

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
            usage = int.Parse(Console.ReadLine());
            if (usage > 0 && usage < 300)
                price = 0.5 * usage;
            else if (usage > 301 && usage < 600)
                price = 0.7 * usage;
            else
                price = 1 * usage;
            Console.WriteLine("Is it business");
            isBusiness = bool.Parse(Console.ReadLine());
            if (isBusiness == true)
                price = price + price * 0.15;
            else
                price = price + price * 0.05;
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
            }
            else if (age > 19 && age < 60)
            {
                price = 180;
                Console.WriteLine("Is it VIP");
                bool vip = bool.Parse(Console.ReadLine());
                if (vip == true)
                    price = price + price * 0.30;
            }
            else
            {
                price = 150;
                Console.WriteLine("IDF pensioner?");
                bool IDF = bool.Parse(Console.ReadLine());
                if (IDF == true)
                    price = price - price * 0.15;
            }
            Console.WriteLine("The final price is: " + price);

        }
        static void Task5()
        {
            string roomType;
            double price;
            bool weekEnd, clubMember;
            Console.WriteLine("Is the room normal or suite");
            roomType = Console.ReadLine();
            if (roomType == "normal")
                price = 400;
            else
                price = 700;
            Console.WriteLine("Is the order in the weekend");
            weekEnd = bool.Parse(Console.ReadLine());
            if (weekEnd == true)
                price = price + price * 0.1;
            Console.WriteLine("Are you a club member");
            clubMember = bool.Parse(Console.ReadLine());
            if (clubMember == true)
                price = price - price * 0.15;
            Console.WriteLine("The price is: " + price);
        }
        static void Task6()
        {
            int age;
            double price;
            Console.WriteLine("Enter your age:");
            age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 12)
            {
                price = 50;
                Console.WriteLine("Is it shabat");
                bool shabat = bool.Parse(Console.ReadLine());
                if (shabat == true)
                    price = price + 10;
            }
            else if (age > 13 && age < 17)
            {
                price = 70;
                Console.WriteLine("club member?");
                bool clubMember = bool.Parse(Console.ReadLine());
                if (clubMember == true)
                    price = price - price * 0.20;
            }
            else
            {
                price = 100;
                Console.WriteLine("VIP member?");
                bool isVIP = bool.Parse(Console.ReadLine());
                if (isVIP == true)
                    price = price + price * 0.30;
            }
            Console.WriteLine("The price is: " + price);


        }
        static void Task7()
        {
            int age;
            double price;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            if (age <= 24)
            {
                price = 600;
                Console.WriteLine("Sport car?");
                bool isSport = bool.Parse(Console.ReadLine());
                if (isSport == true)
                    price = price + price * 0.25;
            }
            else if (age >= 25 && age <= 50)
            {
                price = 450;
                Console.WriteLine("Accidant last year?");
                bool accidantLastYear = bool.Parse(Console.ReadLine());
                if (accidantLastYear == true)
                    price = price + price * 0.20;
            }
            else
            {
                price = 400;
                Console.WriteLine("Is the car normal");
                bool carNormal = bool.Parse(Console.ReadLine());
                if (carNormal == true)
                    price = price - price * 0.1;
            }
            Console.WriteLine("The price is: " + price);


        }
        static void Task8()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                if (num % 4 == 0)
                    Console.WriteLine("The number can be divided by 4");
                else
                    Console.WriteLine("Even but cant be divided by 4");
            }
            else
                Console.WriteLine("The number is odd");
        }
        static void Task9()
        {
            bool admin;
            Console.WriteLine("Are you admin");
            admin = bool.Parse(Console.ReadLine());
            if (admin == true)
            {
                Console.WriteLine("What is the password:");
                int password = int.Parse(Console.ReadLine());
                if (password == 1234)
                    Console.WriteLine("Acsess approved");
                else
                    Console.WriteLine("Wrong password");
            }
            else
                Console.WriteLine("User doesnt exist");
        }
        static void Task10()
        {
            Console.WriteLine("Enter temp:");
            int temp = int.Parse(Console.ReadLine());
            if (temp > 0)
            {
                if (temp > 100)
                    Console.WriteLine("boiling");
                else
                    Console.WriteLine("drippy");
            }
            else
                Console.WriteLine("ice");
        }
        static void Task11()
        {
            Console.WriteLine("Enter the blah: ");
            char x = char.Parse(Console.ReadLine());
            if (x == 97 || x == 101 || x == 105 || x == 111 || x == 117 || x == 65 || x == 69 || x == 73 || x == 79 || x == 85)
            {
                if (x > 64 && x < 91)
                    Console.WriteLine("capital letter");
                else
                    Console.WriteLine("small letter");
            }
            else
                Console.WriteLine("regular letter");
        }
        static void Task12()
        {
            Console.WriteLine("Enter the hour: ");
            int hour = int.Parse(Console.ReadLine());
            if (hour < 12)
            {
                if (hour < 6)
                    Console.WriteLine("night");
                else
                    Console.WriteLine("morning");
            }
            else
            {
                if (hour < 18)
                    Console.WriteLine("day");
                else
                    Console.WriteLine("mid night");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz01_03
{
    interface IPlay
    {
        void EnterPlay();
        void PrintPlay();
    }
    interface IShop
    {
        void EnterShop();
        void PrintShop();
    }

    class Play : IPlay, IDisposable
    {
        private string name;
        private string FullName;
        private string genre;
        private int year;

        public Play() { }
        public Play(string name, string fullName, string genre, int year)
        {
            this.name = name;
            FullName = fullName;
            this.genre = genre;
            this.year = year;
        }

        public void EnterPlay()
        {
            Console.Write("Enter name of play: ");
            name = Console.ReadLine();
            Console.Write("Enter authors full name: ");
            FullName = Console.ReadLine();
            Console.Write("Enter playes genre: ");
            genre = Console.ReadLine();
            Console.Write("Enter year of issue: ");
            year = Console.Read();
        }
        public void PrintPlay()
        {
            Console.WriteLine($"Name of play: {name}");
            Console.WriteLine($"Authors full name: {FullName}");
            Console.WriteLine($"Playes genre: {genre}");
            Console.WriteLine($"Year of issue: {year}");
        }

        public void Dispose()
        {
            Console.WriteLine("Object has been deleted by Dispose!");
        }

        ~Play()
        {
            Console.WriteLine("\nObject has been deleted");
            Console.Beep();
        }
    }

    class Shop : IShop, IDisposable
    {
        private string name;
        private string adress;

        public Shop() { }
        public Shop(string name, string adress)
        {
            this.name = name;
            this.adress = adress;
        }

        public void EnterShop()
        {
            Console.Write("Enter shop's name: ");
            name = Console.ReadLine();
            Console.Write("Enter shop's adress: ");
            adress = Console.ReadLine();
        }
        public void PrintShop()
        {
            Console.WriteLine($"Shop's name: {name}");
            Console.WriteLine($"Shop's adress: {adress}");
        }
        public void Dispose()
        {
            Console.WriteLine("Object has been deleted");
            Console.Beep();
        }
        ~Shop()
        {
            Console.WriteLine("Object has been delete by Destructor!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           

            Shop shop = new Shop();
            shop.EnterShop();
            shop.PrintShop();
            shop.Dispose();
        }
    }
}

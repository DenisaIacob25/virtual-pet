using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet myPenguin = new VirtualPet();

            Console.WriteLine("Welcome to PengiPet, meet your pet, which happens to be a penguin!.");

            //insert image 
            myPenguin.PenguinArt();

            Console.WriteLine("What would you like to name your penguin?");
            myPenguin.Name = Console.ReadLine();
            Console.WriteLine(myPenguin.Name + ", has several needs for surival. " + myPenguin.Name + " will need to be fed, taken care of if sick, and entertained.");

            do
            {
                Console.WriteLine("From the options below please select what you'd like to do for your pet.");

                //menu for user
                List<string> menu = new List<string>();
                menu.Add("1.Feed");//affects hunger level
                menu.Add("2.Heal");//affects sick level
                menu.Add("3.Play");//affects bordom level
                menu.Add("4.Exit");//exits game
                menu.ForEach(Console.WriteLine);
                int menuResponse = int.Parse(Console.ReadLine());

                myPenguin.PenguinHealth();

                switch (menuResponse)
                {

                    case 1:

                        myPenguin.HungerLevel();          
                        Console.WriteLine(myPenguin.Name + " is very happy it was fed!");
                        continue;

                    case 2:

                        myPenguin.SickLevel();
                        Console.WriteLine(myPenguin.Name + " feels much better after that medicated fish!");
                        continue;

                    case 3:

                        myPenguin.BoredLevel();
                        Console.WriteLine(myPenguin.Name + " says \"thanks for playing with me\" I feel even healthier after swimming with Pengi friends!");
                        continue;

                    case 4:

                        Console.WriteLine("Thank you for playing with " +myPenguin.Name);
                        Console.ReadLine();
                        myPenguin.QuitGame();
                        break;
                }

                Console.ReadKey();

            } while (true);

                //myPenguin.Tick();
                //Console.Clear();
                //Console.WriteLine(myPenguin.Name + " thinks you no longer don't love your PengiPet :(");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //Declaring fields
        private string name;
        private int hunger;
        private int sick;
        private int bored;

        //Properties 
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Sick
        {
            get { return this.sick; }
            set { this.sick = value; }
        }

        public int Bored
        {
            get { return this.bored; }
            set { this.bored = value; }

        }

        //Constructors
        public VirtualPet(string name, int hunger, int sick, int bored)
        {

        }

        public VirtualPet()
        {
            this.name = Name;
            this.hunger = 40;
            this.sick = 20;
            this.bored = 60;

        }

        //Methods

        //hunger - feed
        public void HungerLevel()//if feed is selected from menu
        {
            this.Hunger = this.hunger + 5;
        }

        //sick - heal
        public void SickLevel()//if heal is selected from menu
        {
            this.Sick = this.sick + 5;
            this.Hunger = this.hunger + 4;
        }

        //bored - play
        public void BoredLevel()//if play is selected from menu
        {
            this.Bored = this.bored - 6;
        }

        //method for stats of virtual pet
        public void PenguinHealth()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Hunger: " + Hunger);
            Console.WriteLine("Health: " + Sick);
            Console.WriteLine("Boredom: " + Bored);
        }

        //method exit game
        public void QuitGame()
        {

            Console.Clear();
            Environment.Exit(0);
        }

        //method for tick
        public void Tick()
        {
            hunger = hunger + 2;
            sick = sick + 2;
            bored = bored + 2;
        }

        //ascii art
        public void PenguinArt()
        {
            Console.WriteLine("\n");
            Console.WriteLine("(o_");
            Console.WriteLine("//\\");
            Console.WriteLine("V_/_");
            Console.WriteLine("\n");
        }
        
        
    }
}

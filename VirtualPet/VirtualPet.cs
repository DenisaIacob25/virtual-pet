using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //declaring fields
        private string name;
        private int hunger;
        private int sick;
        private int bored;

        //properties 
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

        //constructors
        //public VirtualPet()
        //{

        //}

        public VirtualPet ()
        {
            this.name = Name;
            this.hunger = 40;
            this.sick = 20;
            this.bored = 60;
            
        }

        //methods

        //hunger
        public void HungerLevel()//if feed is selected from menu
        {
            hunger=hunger+5;
        }
        //public int HungryPet()
        //{
        //    return hunger;
        //}
        //public void SetHappyPet(int Hunger)
        //{
        //    hunger = Hunger;
        //}

        //sick
        public void SickLevel()//if heal is selected from menu
        {
            sick=sick+5;
        }
        //public int SickPet()
        //{
        //    return sick;
        //}
        //public void SetSickPet(int Sick)
        //{
        //    sick = Sick;
        //}

        //method bored
        public void BoredLevel()//if play is selected from menu
        {
            bored = bored -6;
        }
        //public int BoredPet()
        //{
        //    return bored;
        //}
        //public void SetBoredPet(int Bored)
        //{
        //    bored = Bored;
        //}

        //method for health
        public void PenguinHealth()
        {
            Console.WriteLine(Name);
            Console.WriteLine("Hunger: " + this.bored);
            Console.WriteLine("Health: " + this.sick);
            Console.WriteLine("Boredom: " + this.bored);
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

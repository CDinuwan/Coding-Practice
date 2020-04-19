using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPAllInOne
{
    public abstract class Creator
    {
        private int creativitylevel = 100;//Encapsulation
        private int energy = 100;

        public abstract void Create();
        public int CreativityLevel
        {
            get
            {
                return creativitylevel;
            }
            set
            {
                if(value>=0&&value<=100)
                {
                    creativitylevel = value;
                }
                else
                {
                    //throw new Exception("Creativity level must be between 0 and 100");
                }
            }
        }
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                if(value<=100 && value>=100)
                {
                    energy = value;
                }
                else
                {
                   // throw new Exception("Energy level must be between 0 and 100");
                }
            }
        }
    }
    public class programmer:Creator
    {
        
        public override void Create()
        {
            if (base.CreativityLevel>=70 && base.Energy>=80)
            {
                this.BrainStormSolution();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                throw new Exception("Cannot create a program out of ideas");
            }
            
        }
        private void BrainStormSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.CreativityLevel = 10;
            Console.WriteLine("BrainStorming solution..........");
        }
        private void PickMostOptimalSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 5;
            base.Energy = base.CreativityLevel - 5;
            Console.WriteLine("Picking most optimal solution............");
        }
        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 7;
            base.Energy = base.CreativityLevel - 5;
            Console.WriteLine("Writing Code............");
        }
        private void TestCode()
        {
            base.CreativityLevel = base.CreativityLevel - 3;
            base.Energy = base.CreativityLevel - 3;
            Console.WriteLine("Testing code............");
        }
    }
    public class Hacker : Creator
    {
        public override void Create()
        {
            this.BrainStormSolution();
            this.FindBug();
            this.WriteCode();
            this.CheckingValnerabilities();
        }
        private void BrainStormSolution()
        {
            base.CreativityLevel = base.CreativityLevel - 25;
            base.Energy = base.CreativityLevel = 10;
            Console.WriteLine("BrainStorming Hacking..........");
        }
        private void FindBug()
        {
            base.CreativityLevel = base.CreativityLevel - 15;
            base.Energy = base.CreativityLevel - 10;
            Console.WriteLine("Fixing Bugs............");
        }
        private void WriteCode()
        {
            base.CreativityLevel = base.CreativityLevel - 10;
            base.Energy = base.CreativityLevel - 5;
            Console.WriteLine("Writing Code for Hacking............");
        }
        private void CheckingValnerabilities()
        {
            base.CreativityLevel = base.CreativityLevel - 3;
            base.Energy = base.CreativityLevel - 3;
            Console.WriteLine("Checking Valnerabilities............");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Creator hacker = new Hacker();
            Creator programmer = new programmer();

            Console.WriteLine();
            Console.WriteLine("Hacker");
            hacker.Create();
            Console.WriteLine();
            Console.WriteLine("Programmer");
            programmer.Create();

            Console.ReadLine();
        }
    }
}

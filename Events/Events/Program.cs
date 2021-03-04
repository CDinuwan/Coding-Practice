using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Person
    {
        private string _name;
        private ClockTower _tower;
        public Person(string name,ClockTower tower)
        {
            _name = name;
            _tower = tower;
        }
    }
    public class ClockTower
    {
        public event ChimeEventHandler Chime;
        
        public void ChimeFivePM()
        {
            Chime();
        }
        public void chimeSixAM()
        {
            Chime();
        }
    }

    public delegate void ChimeEventHandler();
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

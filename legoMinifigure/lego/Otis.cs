using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legoMinifigure.lego
{
    class Otis
    {
        public string Name { get; set; }
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public short Legs { get; set; }
        public string Accessories { get; set; }

        public void Jump(int howMany)
        {
            Console.WriteLine($"{Name} is casually using his {Legs} legs to jump {howMany} inches off the ground. ");
        }
    }
}

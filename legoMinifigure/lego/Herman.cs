using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legoMinifigure.lego
{
    class Herman
    {
       public string Name { get; set; }
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public short Legs { get; set; }
        public string Accessories { get; set; }

        public void Walk(string pace)
        {
            Console.WriteLine($"{Name} uses his {Legs} legs to walk {pace} toward his opponent.");
        }
    }
}

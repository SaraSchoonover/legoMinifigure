using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legoMinifigure.lego
{
    class Sally
    {
        public string Name { get; set; }
        public string Hair { get; set; }
        public string Head { get; set; }
        public string Torso { get; set; }
        public short Legs { get; set; }
        public string Accessories { get; set; }

        public void HeadButt(int numberOfTimes)
        {
            Console.WriteLine($"{Name}'s {Head} head headbutts Herman {numberOfTimes} times. ");
        }
    }
}

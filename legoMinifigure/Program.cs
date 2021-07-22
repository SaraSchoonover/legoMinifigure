using System;
using legoMinifigure.lego;

namespace legoMinifigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var legoHerman = new Herman
            {
                Name = "Herman",
                Hair = "white",
                Head = "square",
                Torso = "short",
                Legs = 2,
                Accessories = "hat"
            };
            legoHerman.Walk("slowly");

            var legoOtis = new Otis
            {
                Name = "Otis",
                Hair = "black",
                Head = "square",
                Torso = "medium",
                Legs = 2,
                Accessories = "microphone"
            };
            legoOtis.Jump(3);

            var legoSally = new Sally
            {
                Name = "Sally",
                Hair = "Blonde",
                Head = "square",
                Torso = "extra long",
                Legs = 2,
                Accessories = "glasses"
            };
            legoSally.HeadButt(4);
        }
    }
}

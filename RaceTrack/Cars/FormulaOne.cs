using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class FormulaOne : RaceCar
    {
        public FormulaOne()
        {
            Name = "Formula One";
            TopSpeed = 230;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} sputters and turns over!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} spins out of control and crashes through the finish line!");
            base.Brake();
        }

    }
}

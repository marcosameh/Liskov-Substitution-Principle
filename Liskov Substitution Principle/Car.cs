using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    public class Car :MotorVehicle
    {
        public override void Move()
        {
            Console.WriteLine("Car Start Moving");
        }

        public override void StartEngine()
        {
            Console.WriteLine("car Engine Started");
        }
    }
}

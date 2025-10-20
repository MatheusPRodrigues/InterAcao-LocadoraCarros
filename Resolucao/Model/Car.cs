using Resolucao.Abstract;
using Resolucao.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class Car : Vehicle
    {
        private bool ManualGearBox { get; set; }
        private int NumberOfPassengers { get; set; }


        public Car(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color,
            int year,
            bool isAvailable,
            double dailyCost,
            bool gearBox,
            int passengers
        ) : base(
            model,
            brand,
            licensePlate,
            kind,
            color,
            year,
            isAvailable,
            dailyCost
        )
        {
            this.ManualGearBox = gearBox;
            this.NumberOfPassengers = passengers;
        }
    }
}

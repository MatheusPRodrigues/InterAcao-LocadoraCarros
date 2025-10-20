using Resolucao.Abstract;
using Resolucao.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class Motorcycle : Vehicle
    {
        private int EngineCapacity { get; set; }
        private int NumberOfPassengers { get; set; }

        public Motorcycle(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color,
            int year,
            bool isAvailable,
            double dailyCost,
            int engineCapacity,
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
            this.EngineCapacity = engineCapacity;
            this.NumberOfPassengers = passengers;
        }


    }
}

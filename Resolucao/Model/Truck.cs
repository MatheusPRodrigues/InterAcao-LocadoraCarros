using Resolucao.Abstract;
using Resolucao.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        public int Axies { get; set; }

        public Truck(
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color, 
            int year,
            bool isAvailable, 
            double dailyCost,
            int load,
            int axies
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
            this.LoadCapacity = load;
            this.Axies = axies;
        }
    }
}

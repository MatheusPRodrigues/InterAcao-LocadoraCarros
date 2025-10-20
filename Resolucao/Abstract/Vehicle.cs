using Resolucao.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Abstract
{
    public abstract class Vehicle
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string Model { get; set; }
        private string Brand { get; set; }
        private string LicensePlate { get; set; }
        private Kind Kind { get; set; }
        private string Color { get; set; }
        private int Year { get; set; }
        private bool IsAvailable { get; set; }
        private double DailyCost { get; set; }

        public Vehicle (
            string model,
            string brand,
            string licensePlate,
            Kind kind,
            string color,
            int year,
            bool isAvailable,
            double dailyCost
        )
        {
            this.Model = model;
            this.Brand = brand;
            this.LicensePlate = licensePlate;
            this.Kind = kind;
            this.Color = color;
            this.Year = year;
            this.IsAvailable = isAvailable;
            this.DailyCost = dailyCost;
        }
    }
}

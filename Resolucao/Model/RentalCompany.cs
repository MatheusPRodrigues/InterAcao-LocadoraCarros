using Resolucao.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class RentalCompany
    {
        public List<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
        public List<Person> Customers { get; set; } = new List<Person>();
        public List<Rental> Rentals { get; set; } = new List<Rental>();
    }
}

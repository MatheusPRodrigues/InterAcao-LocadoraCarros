using Resolucao.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class CustomerPJ : Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Cnpj { get; set; }

        public CustomerPJ(
            string name,
            DateOnly birthDate,
            Contact contact,
            Address address,
            string cnpj
        ) : base(
            name,
            birthDate,
            contact,
            address
        )
        {
            this.Cnpj = cnpj;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"{base.ToString()}\n" +
                $"CNPJ: {this.Cnpj}";
        }
    }
}

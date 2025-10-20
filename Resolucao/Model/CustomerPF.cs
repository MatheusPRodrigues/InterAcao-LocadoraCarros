using Resolucao.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Model
{
    public class CustomerPF : Person
    {
        private Guid Id { get; set; } = Guid.NewGuid();
        private string Cnh { get; set; }
        private string Cpf { get; set; }

        public CustomerPF(
            string name,
            DateOnly birthDate,
            Contact contact,
            Address address,
            string cpf,
            string cnh
        ): base(
            name,
            birthDate,
            contact,
            address
        )
        {
            this.Cpf = cpf;
            this.Cnh = cnh;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"{base.ToString()}\n" +
                $"CNH: {this.Cnh}\n" +
                $"CPF: {this.Cpf}";
        }
    }
}

using Resolucao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao.Abstract
{
    public abstract class Person
    {
        private string Name { get; set; }
        private DateOnly BirthDate { get; set; }
        private Contact Contact { get; set; }
        private Address Address { get; set; }

        public Person (string name, DateOnly birthDate, Contact contact, Address address)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.Contact = contact;
            this.Address = address;
        }

        public string GetName()
        {
            return this.Name;
        }

        public Contact GetContact()
        {
            return this.Contact;
        }

        public void SetContactPhone(string phone)
        {
            this.Contact.SetPhone(phone);
        }

        public override string ToString()
        {
            return $"Nome: {this.Name}\n" +
                $"Data de Nascimento: {this.BirthDate}\n" +
                $"{this.Contact}\n" +
                $"{this.Address}";
        }
    }
}

using Linq_Lambda_Expressions.Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq_Lambda_Expressions.Tests
{
    public class TestSelectMany : ITest
    {
        class Person
        {
            private int _Id;
            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }

            private string _Name;
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            private List<PersonPhone> _PersonPhones;
            public List<PersonPhone> PersonPhones
            {
                get { return _PersonPhones; }
                set { _PersonPhones = value; }
            }
        }

        class PersonPhone
        {
            private string _PhoneNumber;
            public string PhoneNumber
            {
                get { return _PhoneNumber; }
                set { _PhoneNumber = value; }
            }

        }

        public void Test()
        {
            var lstPerson = new List<Person>();

            lstPerson.Add(new Person { 
                Id = 1,
                Name = "John",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "123456"}, new PersonPhone { PhoneNumber = "654321" } }
            });

            lstPerson.Add(new Person
            {
                Id = 2,
                Name = "Mary",
                PersonPhones = new List<PersonPhone>() { new PersonPhone { PhoneNumber = "776688" }, new PersonPhone { PhoneNumber = "223344" } }
            });

            var lstPersonPhones = lstPerson.Select(phone => phone.PersonPhones);

            foreach (var objPersonPhone in lstPersonPhones)
            {
                foreach (var objPhone in objPersonPhone)
                {
                    Console.WriteLine("Telefone: " + objPhone.PhoneNumber);
                }                
            }

            var lstPhones = lstPerson.SelectMany(person => person.PersonPhones);

            foreach (var objPhone in lstPhones)
            {
                Console.WriteLine("Usinf Select Many: " + objPhone.PhoneNumber);
            }
        }
    }
}

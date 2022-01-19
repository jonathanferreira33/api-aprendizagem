using System;
using System.Collections.Generic;

namespace Itau.API
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Created { get; set; }

        public IEnumerable<Customer> GetAll()
        {
            return new List<Customer> {
                new Customer{ Id = 1, Name = "Homerplast Indústria e Comercio de Plastico", Created = new DateTime(2014, 10, 22) },
                new Customer{ Id = 2, Name = "Mecalor Indústria e Comercio de Refrigeração Ltda", Created = new DateTime(1976, 10, 04) },
            };
        }
    }
}

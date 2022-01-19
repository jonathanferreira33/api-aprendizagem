using System;
using System.Collections.Generic;

namespace Itau.API
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public IEnumerable<Employee> GetAll()
        {
            return new List<Employee> {
                new Employee{ Id = 1, FirstName = "Jonathan", LastName = "Ferreira", BirthDate = new System.DateTime(1993, 7, 22) },
                new Employee{ Id = 2, FirstName = "Roberto Carlos", LastName = "Queiroz Oliveira", BirthDate = new System.DateTime(1976, 10, 04) },
            };
        }
    }
}

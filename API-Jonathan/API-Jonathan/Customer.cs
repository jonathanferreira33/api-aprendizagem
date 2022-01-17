namespace API_Jonathan
{
    public class Customer
    {

        public int id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public int[] pedidos { get; set; }

        public IEnumerable<Customer> GetAll()
        {
            return new List<Customer> {
                new Customer{ id = 1, firstName = "Jonathan", lastName = "Ferreira" },
                new Customer{ id = 2, firstName = "Roberto Carlos", lastName = ""} 
            };
        }

    }
}

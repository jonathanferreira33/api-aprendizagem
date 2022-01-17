namespace API_Jonathan
{
    public class Request
    {

        public int id { get; set; }

        public Customer customer { get; set; }

        public Product[] product { get; set; }

        public float amount { get; set; }
    }
}

namespace API_Jonathan
{
    public class Product
    {
        public int id { get; set; }
        
        public string name { get; set; }

        public Boolean isAvailable {  get; set; }

        public float price { get; set; }

        public int quantity { get; set; }

        internal IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

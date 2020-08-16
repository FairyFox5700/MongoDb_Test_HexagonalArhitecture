namespace MonoDb.Models
{
    public class City:BaseEntity<int>
    {
        public string Name { get; set; }
        public  string PostalCode { get; set; }
    }
}
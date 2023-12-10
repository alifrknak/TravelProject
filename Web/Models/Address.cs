namespace Web.Models
{
	public class Address : IEntity
	{
        public int Id { get; set; }
        public string Header { get; set; }
        public string Explanation { get; set; }
        public string AddressDetail { get; set; }
        public string PhoneNumber { get; set; }

    }
}

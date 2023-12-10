namespace Web.Models
{
	public class Contact : IEntity
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string  Topic{ get; set; }
        public string Message{ get; set; }
    }
}

namespace Web.Models
{
	public class Admin : IEntity
	{
        public int Id { get; set; }
        public string UserName { get; set; }
        public  string PassWord { get; set; }
    }
}

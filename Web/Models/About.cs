namespace Web.Models
{
	public class About : IEntity
	{
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Explanation { get; set; }
    }
}

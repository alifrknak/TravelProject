namespace Web.Models
{
	public class Blog : IEntity
	{
        public int Id { get; set; }
        public int Header { get; set; }
        public DateTime CreateTime { get; set; }
        public string Explanation { get; set; }
        public string BlogImage { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}

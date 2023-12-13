namespace Web.Models
{
	public class Comment : IEntity
	{
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
       
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}

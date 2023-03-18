namespace Blog.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TagsId { get; set; }
        public Post Post { get; set; }

    }
}

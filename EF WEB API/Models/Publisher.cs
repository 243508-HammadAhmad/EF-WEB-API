namespace EF_WEB_API.Entity
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        public string Name { get; set; }

        public Author author { get; set; } 
        public int AuthorId { get; set; }
        public ICollection<BookPublisher> BookPublishers { get; set; }
    }
}

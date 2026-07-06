namespace EF_WEB_API.Entity
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        

        public Author author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<BookPublisher> BookPublishers { get; set; }
    }
}

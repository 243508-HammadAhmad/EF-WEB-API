namespace EF_WEB_API.Entity
{
    public class Author
    {
        public int AuthorId { get; set; }

        public string Name { get; set; }

      public Publisher publisher { get; set; }
        public int PublisherId { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}


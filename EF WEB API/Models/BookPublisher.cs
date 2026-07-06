namespace EF_WEB_API.Entity
{
    public class BookPublisher
    {
       public Book book { get; set; }
        public int BookId { get; set; }
        public Publisher publisher { get; set; }
        public int PublisherId { get; set; }

        
    }
}


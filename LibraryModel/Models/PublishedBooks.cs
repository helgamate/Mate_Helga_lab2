namespace Mate_Helga_lab2.Models
{
    public class PublishedBooks
    {
            public int PublisherID { get; set; }
            public int BookID { get; set; }
            public Publisher Publisher { get; set; }
            public Book Book { get; set; }
        

    }
}

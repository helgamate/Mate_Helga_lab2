using LibraryWebAPI_.Models;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mate_Helga_lab2.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public DateTime BirthDate { get; set; }
        public int? CityID { get; set; }
        public City? City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FIT5032_Portfolio.Models
{
    public class BookingModels : DbContext
    {
        public BookingModels()
            : base("name=BookingModel")
        {
        }
        static void Main(string[] args)
        {
        }
        public DbSet<Booking> Bookings { get; set; }
    }

    public class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public DateTime Time { get; set; }
    }
}
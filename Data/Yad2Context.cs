using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yad2.Models;

namespace Yad2.Data
{
    public class Yad2Context : IdentityDbContext<User>
    {
        public Yad2Context(DbContextOptions<Yad2Context> options) : base(options)
        {
        }

        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        
    }
}

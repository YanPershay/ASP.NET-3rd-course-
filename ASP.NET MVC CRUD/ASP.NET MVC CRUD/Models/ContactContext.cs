using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_CRUD.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Contact> Contacts { get; set; }
    }
}
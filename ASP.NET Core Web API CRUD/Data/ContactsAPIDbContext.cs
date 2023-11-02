using ASP.NET_Core_Web_API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Web_API_CRUD.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

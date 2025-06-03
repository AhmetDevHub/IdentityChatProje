using IdentityChatProje.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityChatProje.Context
{
    public class EmailContext : IdentityDbContext<AppUser>
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-1BMQTPK\\SQLEXPRESS;initial Catalog = EmailChatProjeDb ; integrated security = true;trust server certificate = true");
        }
        public DbSet<Message> Messages { get; set; }
    }
}

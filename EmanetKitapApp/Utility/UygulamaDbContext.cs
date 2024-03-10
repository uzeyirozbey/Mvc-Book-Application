using EmanetKitapApp.Models;
using Microsoft.EntityFrameworkCore;
namespace EmanetKitapApp.Utility
{
    public class UygulamaDbContext:DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options){}
        public DbSet<KitapTuru> KitapTurleri { get; set; }
    }
}

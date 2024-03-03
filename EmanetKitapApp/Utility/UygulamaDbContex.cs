using EmanetKitapApp.Models;
using Microsoft.EntityFrameworkCore;
namespace EmanetKitapApp.Utility
{
    public class UygulamaDbContex:DbContext
    {
        public UygulamaDbContex(DbContextOptions<UygulamaDbContex> options) : base(options){}
        public DbSet<KitapTuru> KitapTurleri { get; set; }
    }
}

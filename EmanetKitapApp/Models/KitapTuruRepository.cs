using EmanetKitapApp.Utility;
using System.Linq.Expressions;

namespace EmanetKitapApp.Models
{
    public class KitapTuruRepository : Repository<KitapTuru>, IKitapTuruRepository
    {
        private  UygulamaDbContext _uygulamaDbContext;

        public KitapTuruRepository(UygulamaDbContext uygulamaDbContext) : base(uygulamaDbContext)
        {
        }

        public void Guncelle(KitapTuru kitapTuru)
        {
            throw new NotImplementedException();
        }

        public void Kaydet()
        {
            throw new NotImplementedException();
        }
    }
}

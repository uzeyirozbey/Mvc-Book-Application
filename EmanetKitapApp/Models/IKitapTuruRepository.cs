using System.Linq.Expressions;

namespace EmanetKitapApp.Models
{
    public interface IKitapTuruRepository:IRepository<KitapTuru>
    {
        void Guncelle(KitapTuru kitapTuru);
        void Kaydet();
    }
}

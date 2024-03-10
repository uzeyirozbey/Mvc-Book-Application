using AspNetCoreHero.ToastNotification.Abstractions;
using EmanetKitapApp.Models;
using EmanetKitapApp.Utility;
using Microsoft.AspNetCore.Mvc;

namespace EmanetKitapApp.Controllers
{
    public class KitapTuruController : Controller
    {
        private readonly UygulamaDbContext _uygulamaDbContext;
        private readonly INotyfService _notyf;
        public KitapTuruController(UygulamaDbContext context,   INotyfService notyf)
        {
            _uygulamaDbContext = context;
            _notyf = notyf;
        }

        public IActionResult Index()
        {
            List<KitapTuru> objKitapTuruList = _uygulamaDbContext.KitapTurleri.ToList();
            return View(objKitapTuruList);
        }
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(KitapTuru model)
        {
            //Validationların backend tarafında kontrol etme  yöntemi.
            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Add(model);
                _uygulamaDbContext.SaveChanges();
                _notyf.Success("Kitap Türü Ekleme İşlemi Başarılı");
                TempData["basarili"] ="Kitap Türü Ekleme İşlemi Başarılı";
                return RedirectToAction("Index", "KitapTuru");
            }
            return View();
            
        }
        public IActionResult Guncelle(int? Id)
        {
            if(Id==null || Id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = _uygulamaDbContext.KitapTurleri.Find(Id);
            if(kitapTuruVt == null)
            {
                return NotFound();
            }
            return View(kitapTuruVt);
        }

        [HttpPost]
        public IActionResult Guncelle(KitapTuru model)
        {
            //Validationların backend tarafında kontrol etme  yöntemi.
            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Update(model);
                _uygulamaDbContext.SaveChanges();
                _notyf.Success("Kitap Türü Güncelleme İşlemi Başarılı");
                TempData["basarili"] ="Kitap Türü Güncelleme İşlemi Başarılı";
                return RedirectToAction("Index", "KitapTuru");
            }
            return View();

        }

        [HttpGet]
        public IActionResult Sil(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            KitapTuru? kitapTuruVt = _uygulamaDbContext.KitapTurleri.Find(Id);
            if (kitapTuruVt == null)
            {
                return NotFound();
            }
            return View(kitapTuruVt);
        }

        [HttpPost,ActionName("Sil")]
        public IActionResult SilPOST(int? Id)
        {
            KitapTuru? kitapTuru= _uygulamaDbContext.KitapTurleri.Find(Id);
           if(kitapTuru == null)
            {
                return NotFound();
            }
            _uygulamaDbContext.KitapTurleri.Remove(kitapTuru);
            _uygulamaDbContext.SaveChanges();
            _notyf.Success("Kitap Türü Silme İşlemi Başarılı");
            TempData["basarili"] ="Kitap Türü Silme İşlemi Başarılı";
            return RedirectToAction("Index", "KitapTuru");

        }

    }
}

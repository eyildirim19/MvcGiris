using Microsoft.AspNetCore.Mvc;

namespace MvcGiris.Controllers
{
    // Controller sınıflarımız IsimController olarak tanımlanmalıdır... Ve Controllers klasöründe olmalıdır..
    public class HomeController : Controller
    {
        // Request Controllerin metoduna yapılır...
        // Controller içerisindeki metotlara action metot deriz. Action metotlar dışarıya açık http reqeusti ile erişilebilen metotlardır...
        public IActionResult Index()
        {
            // Denetleyici (Controller) yapılan requeste view dönecekse Views klasörü altında kendi ismi ile oluşturulmuş klasör içinde view arar....

            // Default actionmetot isimleri ile viewname aranmaktadır. Bizde bu davranışı bozmayalım eğer view döneceksek view name ile metot name aynı olsun...
            return View();

         
        }

        public IActionResult Login()
        {
            return View();
        }

        public string MesajVer()
        {
            return "Merhaba";
        }
        public int IslemYap()
        {
            return 2 + 2;
        }
        public DateTime TarihGoster()
        {
            return DateTime.Now;
        }
    }
}
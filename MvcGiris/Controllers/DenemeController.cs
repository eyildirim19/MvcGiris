using Microsoft.AspNetCore.Mvc;

namespace MvcGiris.Controllers
{
    public class DenemeController : Controller
    {
        public IActionResult Index()
        {
            // asp.net ve asp.net core mvc'de request controller(action) yapılır. Url üzerinden fiziki sayfa çağrılamaz......
            return View();
            // View metodu cshtml uzantılı özel bir dosya dönmektedir. Yani mvc'de fiziki dosya çağrılamadığı için ve reqeusti Controller action metodu karşıladğı için kullanıcıya cshtml uzantlı dosya dönemktedir. Bu cshtml uzantılı dosya aspnet core mvc'ki viewengine sayesinde üretilir...Yani bu sayfa derlenme aşamasında fiziki olarak durrsada kullanıcı için çalışma zamanında üretilir...

            // csharphtml dosyasıdır..
            // cshtml dosyalarına html'e ek olarak c# komutlarıda yazılır... 
        }

        public IActionResult Sayfam()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            return View("demo"); // demo ismindeki view'i dön...
        }
    }
}
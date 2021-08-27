using Microsoft.AspNetCore.Mvc;
using MvcUsingRefitAPI.Services;
using Refit;

namespace MvcUsingRefitAPI.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILibraryService _library;
        private readonly string _apiUrl;
        
        public HomeController()
        {
            _apiUrl = "https://localhost:5001/api/library";
            _library = RestService.For<ILibraryService>(_apiUrl);
        }

        public JsonResult Listar()
        {
            return Json(_library.GetBooks().Result);
        }

        public JsonResult Headers()
        {
            return Json(_library.GetHeaders().Result);
        }

        public JsonResult Buscar(string author) 
        {
            return Json(_library.FindByAuthor(author).Result);
        }
   }
}

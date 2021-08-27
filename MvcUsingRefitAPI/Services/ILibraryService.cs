using System.Collections.Generic;
using System.Threading.Tasks;
using MvcUsingRefitAPI.Models;
using Refit;

namespace MvcUsingRefitAPI.Services
{
    [Headers("App: MVC Library")]
    public interface ILibraryService {
        [Get("/books")]
        Task<List<BookModel>> GetBooks();
        
        [Get("/headers")]
        Task<List<KeyValuePair<string, string>>> GetHeaders();

        [Post("/find")]
        Task<List<BookModel>> FindByAuthor(string author);
    }
    
}
using Stoica_Denisa_Lab2.Models;
namespace Stoica_Denisa_Lab2.Models.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Author> Authors{ get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}

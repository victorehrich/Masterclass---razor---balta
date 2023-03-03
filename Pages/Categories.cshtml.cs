using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet(int offset = 0, int limit = 25)
        {
            var temp = new List<Category>();
            for (int i = 0; i <= 1000; i++)
            {
                temp.Add(
                    new Category(
                        i,
                        $"Categoria {i}",
                        i * 18.95M
                        )
                    );
            }
            Categories = temp.Skip(offset* limit).Take(limit).ToList();

            return;
        }
    }
}
public record Category(
        int Id,
        string Title,
        decimal Price
    );
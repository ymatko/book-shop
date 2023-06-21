using BookShopRazor_Temp.Data;
using BookShopRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookShopRazor_Temp.Pages.Categories
{
    public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		[BindProperty]
		public Category Category { get; set; }
		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
        {
        }
		public IActionResult OnPost()
		{
			_db.Categories.Add(Category);
			_db.SaveChanges();
			return RedirectToPage("index");
		}
    }
}

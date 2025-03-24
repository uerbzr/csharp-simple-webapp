using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using workshop.wwwapp.Models;
using workshop.wwwapp.Repository;

namespace workshop.wwwapp.Pages.Cars
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Car> Cars = new List<Car>();
        public async void OnGet(IRepository<Car> repository)
        {
            Cars = await repository.Get();
        }
    }
}

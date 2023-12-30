using Microsoft.AspNetCore.Mvc;

namespace Last.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            var person = Models.Person.GetPersonById(id);
            return View(person);
        }
        /* public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var person = await Models.Person.GetPersonByIdAsync(id);
            return View(person);
        }*/
    }
}
// Path: Last/Views/Shared/Components/Person/Default.cshtml
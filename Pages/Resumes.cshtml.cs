using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetWebApp.Pages
{
    public class ResumesModel : PageModel
    {
        public List<Student> Students { get; set; } = new();

        public void OnGet()
        {
            // Берем данные из общего списка
            Students = IndexModel.StudentsList;
        }
    }
}
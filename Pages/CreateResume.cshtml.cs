using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetWebApp.Pages
{
    public class CreateResumeModel : PageModel
    {
        [BindProperty]
        public Student NewStudent { get; set; } = new Student();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Сохраняем данные в общий список
            IndexModel.StudentsList.Add(NewStudent);

            // Переходим в каталог, чтобы сразу увидеть результат
            return RedirectToPage("/Resumes");
        }
    }
}
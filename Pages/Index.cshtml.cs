using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetWebApp.Pages
{
    public class IndexModel : PageModel
    {
        // Общий список для сохранения резюме в памяти
        public static List<Student> StudentsList { get; set; } = new List<Student>();

        public void OnGet() { }
    }

    // Модель студента
    public class Student
    {
        public int Id { get; set; } = new Random().Next(1, 10000);
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Speciality { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string BirthDate { get; set; } = string.Empty;
        
        public List<string> Technologies { get; set; } = new List<string>();
        public string City { get; set; } = string.Empty;
        public string Lang { get; set; } = string.Empty;
        public string FormStudy { get; set; } = string.Empty;
        public string Info { get; set; } = string.Empty;
    }
}
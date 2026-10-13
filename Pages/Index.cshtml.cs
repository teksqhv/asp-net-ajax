using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aspnetWebApp.Models;

namespace aspnetWebApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Name { get; set; } = "";
    [BindProperty]
    public string Phone { get; set; } = "";
    [BindProperty]
    public string Email { get; set; } = "";
    [BindProperty]
    public string Speciality { get; set; } = "";
    [BindProperty]
    public string Course { get; set; } = "";
    [BindProperty]
    public string BirthDate { get; set; } = "";
    [BindProperty]
    public string[] Technologies { get; set; } = Array.Empty<string>();
    [BindProperty]
    public string City {get; set;} = "";
    [BindProperty]
    public string Lang {get; set;} = "";
    [BindProperty]
    public string FormStudy {get; set;} = "";
    [BindProperty]
    public string Info {get; set; } = "";
    public string Message { get; set; }
    public static List<Student> Students { get; set; } = new();
    public void OnGet()
    {
        // Message = "Привет! Сообщение от C#";
    }
    public IActionResult OnPost() {

        string technologies = Technologies.Length > 0
            ? string.Join(", ", Technologies)
            : "Не выбраны";

        var student = new Student {
            Id = Students.Any() ? Students.Max(x => x.Id) + 1 : 1,
            Name = Name,
            Phone = Phone,
            Email = Email,
            Speciality = Speciality,
            Course = Course,
            BirthDate = BirthDate,
            Technologies = Technologies,
            City = City,
            Lang = Lang,
            FormStudy = FormStudy,
            Info = Info
        };

        Students.Add(student);
        
        // return Content(JsonSerializer.Serialize(student),
        // "application/json");
        return new JsonResult(student);
    }

    public IActionResult OnPostDelete(int Id) {
        var student = Students.FirstOrDefault(x => x.Id == Id);
        if(student == null) {
            return new JsonResult(new{
                success = false,
                message = "Студент не найден"
            });
        }
        Students.Remove(student);
        return new JsonResult(new {
            success = true
        });
    }
}

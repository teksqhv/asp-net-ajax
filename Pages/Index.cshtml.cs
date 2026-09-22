using System;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetWebApp.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }
    [BindProperty]
    public string Phone { get; set; }
    [BindProperty]
    public string Email { get; set; }
    [BindProperty]
    public string Speciality { get; set; }
    [BindProperty]
    public string Course { get; set; }
    [BindProperty]
    public string BirthDate { get; set; }
    [BindProperty]
    public string[] Technologies { get; set; } = Array.Empty<string>();
    [BindProperty]
    public string City {get; set;}
    [BindProperty]
    public string Lang {get; set;}
    [BindProperty]
    public string FormStudy {get; set;}
    [BindProperty]
    public string Info {get; set; }
    public string Message { get; set; }
    public void OnGet()
    {
        // Message = "Привет! Сообщение от C#";
    }
    public IActionResult OnPost() {

        string technologies = Technologies.Length > 0
            ? string.Join(", ", Technologies)
            : "Не выбраны";

        // string message = $"Анкета студента\n\n" +
        //         $"Имя: {Name}\n" + 
        //         $"Телефон: {Phone}\n" +
        //         $"Email: {Email}\n" +
        //         $"Специальность: {Speciality}\n" +
        //         $"Курс: {Course}\n" +
        //         $"Дата рождения: {BirthDate}\n" +
        //         $"Технологии: {technologies}\n" +
        //         $"Город: {City}\n" +
        //         $"Основной язык программирования: {Lang}\n" +
        //         $"Форма обучения: {FormStudy}\n" +
        //         $"Информация о вас: {Info}\n";
        var student = new {
            Name,
            Phone,
            Email,
            Speciality,
            Course,
            BirthDate,
            Technologies,
            City,
            Lang,
            FormStudy,
            Info
        };
        
        return Content(JsonSerializer.Serialize(student),
        "application/json");
    }
}

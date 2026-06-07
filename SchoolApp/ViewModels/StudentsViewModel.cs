using System.Collections.ObjectModel;
using SchoolApp.Models;

namespace SchoolApp.ViewModels;

public class StudentsViewModel
{
    public ObservableCollection<Student> Students { get; } = new();

    public string NewName { get; set; } = "";

    public StudentsViewModel()
    {
        Students.Add(new Student { Name = "Adelia Umbetalieva", Gpa = 3.85 });
        Students.Add(new Student { Name = "Sharonova Karina", Gpa = 3.20 });
        Students.Add(new Student { Name = "Borzaya Alice", Gpa = 3.95 });
        Students.Add(new Student { Name = "Podguznikov Nikits", Gpa = 2.75 });
        Students.Add(new Student { Name = "Adina Marat", Gpa = 3.60 });
    }

    public void AddStudent()
    {
        if (string.IsNullOrWhiteSpace(NewName)) return;
        Students.Add(new Student { Name = NewName, Gpa = 3.0 });
        NewName = "";
    }
}
using Microsoft.AspNetCore.Mvc.RazorPages;

public class CoursesModel: PageModel
{    
    public required List<Course> Courses { get; set; }
    public async Task OnGet()
    {
        // CollegeDbContext db = new();
        // Courses = db.Courses.ToList();

        //Consuming Rest API with http client
        HttpClient http = new HttpClient();
        Courses = await http.GetFromJsonAsync<List<Course>>("http://localhost:5129/courses");
    }
}
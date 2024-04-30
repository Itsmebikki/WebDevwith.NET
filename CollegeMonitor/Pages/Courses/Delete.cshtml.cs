using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

public class DeleteCourseModel: PageModel
{
    private object courses;

    [BindProperty]
    public Course Course { get; set; }
    public void OnGet(int id)
    {
        CollegeDbContext db =new();
        Course = db.Courses.Find(id);
    }
    public IActionResult OnPost()
    {
        CollegeDbContext db = new();
        db.Courses.Remove(Course);
        db.SaveChanges();

        return RedirectToPage("Courses");
    }
}
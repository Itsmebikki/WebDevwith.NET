public class Session
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string? Details { get; set; }
    public DateTime Start { get; set; }
    public float Duration { get; set; }
    public int? CourseId { get; set; }
    public Course? Course { get; set; }

}
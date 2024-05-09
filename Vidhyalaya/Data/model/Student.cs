public class Student
{
    public int StudentId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Gender { get; set; }
    public DateTime Dob { get; set; }
    public string? Photo { get; set; }
    public Guardian? Guardian { get; set; }
    public int GradeId { get; set; }
    public Grade? Grade { get; set; }
    public int GuardianId { get; set; }
}
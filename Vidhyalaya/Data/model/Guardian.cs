public class Guardian
{
    public int GuardianId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public List<Student>? Students { get; set; }
}
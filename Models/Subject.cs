namespace practicalsAsProject.Models;

public class Subject
{
    public int SubjectId { get; set; }
    public string SubjectName { get; set; }
    public int SubjectCode { get; set; }
    public int CourseId { get; set; }
    public Course Course{ get;set; }
    public int Semester { get; set; }
    public bool IsPractical { get; set; }
    
}

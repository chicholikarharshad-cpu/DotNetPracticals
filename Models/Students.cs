namespace practicalsAsProject.Models;

public class Student
{
    public int StudentId{get;set;}
    public long Enrollment{get;set;}
    public string Name{get;set;}
    public string Email { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }
    public long Phone { get; set; }
    public string Address { get; set; }
    public string ParentName { get; set; }
    public long ParentPhone { get; set; }
    public int Semester { get; set; }
    public string Profile { get; set; }
    public string Hobbies { get; set; }
    public string Class { get; set; } 
        
    public int CourseId { get; set; }
    public Course Course {get;set;}
    public int DeparmentId { get; set; }
    public Department Department {get;set;}
    public DateTime CreateAt { get; set; } = DateTime.Now;

}

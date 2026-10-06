namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Course
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public string Deration { get; set; }
    public int TotalSem { get; set; }
    public int Fees { get; set; }
    public String Eligibility { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get;set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;

}

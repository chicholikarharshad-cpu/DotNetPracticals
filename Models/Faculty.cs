namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Faculty
{
    public int FacultyId { get; set; }
    public string FacultyName { get; set; }
    public string facultyEmail { get; set; }
    public long Phone { get; set; }
    public string Designation { get; set; }
    public string Qualification { get; set; }
    public string Gender { get; set; }
    public DateTime DOB { get; set; }
    public DateTime JoiningDate { get; set; }
    public string Profile { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
}

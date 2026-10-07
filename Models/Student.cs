namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Student
{
    public int StudentId { get; set; }

    [Required(ErrorMessage = "Enrollment number is required.")]
    public long Enrollment { get; set; }

    [Required(ErrorMessage = "Student name is required.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date)]
    public DateTime DOB { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    public long Phone { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Parent name is required.")]
    public string ParentName { get; set; }

    [Required(ErrorMessage = "Parent phone number is required.")]
    public long ParentPhone { get; set; }

    [Required(ErrorMessage = "Semester is required.")]
    public int Semester { get; set; }

    public string Profile { get; set; }

    public string Hobbies { get; set; }

    [Required(ErrorMessage = "Class is required.")]
    public string Class { get; set; }

    [Required(ErrorMessage = "Course is required.")]
    public int CourseId { get; set; }

    public Course Course { get; set; }

    [Required(ErrorMessage = "Department is required.")]
    public int DeparmentId { get; set; }

    public Department Department { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}
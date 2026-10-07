namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Faculty
{
    public int FacultyId { get; set; }

    [Required(ErrorMessage = "Faculty Name is required.")]
    public string FacultyName { get; set; }

    [Required(ErrorMessage = "Faculty Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string FacultyEmail { get; set; }

    [Required(ErrorMessage = "Phone number is required.")]
    public long Phone { get; set; }

    [Required(ErrorMessage = "Designation is required.")]
    public string Designation { get; set; }

    [Required(ErrorMessage = "Qualification is required.")]
    public string Qualification { get; set; }

    [Required(ErrorMessage = "Gender is required.")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date)]
    public DateTime DOB { get; set; }

    [Required(ErrorMessage = "Joining Date is required.")]
    [DataType(DataType.Date)]
    public DateTime JoiningDate { get; set; }

    public string? Profile { get; set; }

    [Required(ErrorMessage = "Department is required.")]
    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}
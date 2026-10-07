namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Course
{
    public int CourseId { get; set; }

    [Required(ErrorMessage = "Course Name is required.")]
    [StringLength(100)]
    public string CourseName { get; set; }

    [Required(ErrorMessage = "Course Code is required.")]
    [StringLength(20)]
    public string CourseCode { get; set; }

    [Required(ErrorMessage = "Duration is required.")]
    [StringLength(50)]
    public string Duration { get; set; }

    [Required(ErrorMessage = "Total Semesters is required.")]
    public int TotalSem { get; set; }

    [Required(ErrorMessage = "Fees is required.")]
    public int Fees { get; set; }

    [Required(ErrorMessage = "Eligibility criteria is required")]
    [StringLength(200)]
    public string Eligibility { get; set; }

    [Required(ErrorMessage = "Department select is required.")]
    public int DepartmentId { get; set; }

    public Department? Department { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}
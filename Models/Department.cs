namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Department
{   
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "Department Name is required.")]
    public string DepartmentName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Department Code is required.")]
    public string DepartmentCode { get; set; } = string.Empty;

    public string Description { get; set; }

    [Required(ErrorMessage = "HOD Name is required.")]
    public string HODName { get; set; } = string.Empty;

    [Required(ErrorMessage = "HOD Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid Email Address.")]
    public string HODEmail { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone number is required.")]
    public long Phone { get; set; }

    public string Facilities { get; set; }

    public string Location { get; set; }

    public DateTime CreateAt { get; set; } = DateTime.Now;
}
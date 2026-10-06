namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Department
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentCode { get; set; }
    public string Description { get; set; }
    public string HODName { get; set; }
    public string HODEmail { get; set; }
    public long Phone { get; set; }
    public string Facilities { get; set; }
    public string Location { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;
}

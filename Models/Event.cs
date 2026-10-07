namespace practicalsAsProject.Models;

using System;
using System.ComponentModel.DataAnnotations;

public class Event
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Event name is required.")]
    public string EventName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event description is required.")]
    public string EventDescription { get; set; } = string.Empty;

    [Required(ErrorMessage = "Event date is required.")]
    [DataType(DataType.Date)]
    public DateTime EventDate { get; set; }

    [Required(ErrorMessage = "Start time is required.")]
    [DataType(DataType.Time)]
    public DateTime StartTime { get; set; }

    [Required(ErrorMessage = "End time is required.")]
    [DataType(DataType.Time)]
    public DateTime EndTime { get; set; }

    [Required(ErrorMessage = "Location is required.")]
    public string Location { get; set; } = string.Empty;

    public string? Banner { get; set; }

    [Required(ErrorMessage = "Organized by is required.")]
    public string OrganizedBy { get; set; } = string.Empty;

    public DateTime CreateAt { get; set; } = DateTime.Now;
}
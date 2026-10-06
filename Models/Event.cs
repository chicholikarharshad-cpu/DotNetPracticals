namespace practicalsAsProject.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Event
{
    public int EventId { get; set; }
    public string EventName { get; set; }
    public string EventDescription { get; set; }
    public DateTime EventDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Location { get; set; }
    public string Banner { get; set; }
    public string OrganizedBy { get; set; }
    public DateTime CreateAt { get; set; } = DateTime.Now;

}

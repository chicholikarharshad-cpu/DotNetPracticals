using System;
using System.ComponentModel.DataAnnotations;
namespace practicalsAsProject.Models;

    public class Feedback
    {
        public int FeedbackId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        [StringLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Message is required")]
        [StringLength(1000)]
        public string Message { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        public DateTime SubmittedDate { get; set; }

        [StringLength(1000)]
        public string ReplyMessage { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(20)]
        public string Status { get; set; }

        public bool IsAnonymous { get; set; }
    }

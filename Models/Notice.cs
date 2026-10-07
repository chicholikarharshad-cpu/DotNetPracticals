
using System;
using System.ComponentModel.DataAnnotations;

namespace practicalsAsProject.Models;
    public class Notice
    {
        public int NoticeId { get; set; }   

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Notice type is required")]
        public string NoticeType { get; set; }

        [Required(ErrorMessage = "Published date is required")]
        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; }

        [Required(ErrorMessage = "Expiry date is required")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "Published by is required")]
        public int PublishedBy { get; set; }   // Foreign Key

        public bool IsPublished { get; set; }

        public DateTime CreatedAt { get; set; }
    }

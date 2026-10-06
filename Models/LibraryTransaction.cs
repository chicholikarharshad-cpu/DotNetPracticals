using System;
using System.ComponentModel.DataAnnotations;
namespace practicalsAsProject.Models;
    public class Transaction
    {
        public int TransactionId { get; set; }

        [Required(ErrorMessage = "Book is required")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Student is required")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Issue date is required")]
        [DataType(DataType.DateTime)]
        public DateTime IssueDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Due date is required")]
        [DataType(DataType.DateTime)]
        public DateTime DueDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ReturnDate { get; set; }

        [Range(0, 10000, ErrorMessage = "Enter valid fine amount")]
        public decimal FineAmount { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(20)]
        public string Status { get; set; }

        [Required(ErrorMessage = "Issued by is required")]
        public int IssuedBy { get; set; }

        public int LibraryId { get; set; }
        public Library Library { get; set; }
    }

using System.ComponentModel.DataAnnotations;

namespace practicalsAsProject.Models;
    public class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        [StringLength(30)]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(150)]
        public string Author { get; set; }

        [Required(ErrorMessage = "Publisher is required")]
        [StringLength(150)]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [StringLength(100)]
        public string Category { get; set; }

        public int CourseId { get; set; }

        [StringLength(50)]
        public string Edition { get; set; }

        [Range(1000, 9999, ErrorMessage = "Enter valid year")]
        public int PublicationYear { get; set; }

        [Range(0, 1000, ErrorMessage = "Invalid total copies")]
        public int TotalCopies { get; set; }

        [Range(0, 1000, ErrorMessage = "Invalid available copies")]
        public int AvailableCopies { get; set; }

        [StringLength(30)]
        public string ShelfNo { get; set; }

        public int LibraryId { get; set; }
        public Library Library { get; set; }

        public bool IsActive { get; set; }
    }

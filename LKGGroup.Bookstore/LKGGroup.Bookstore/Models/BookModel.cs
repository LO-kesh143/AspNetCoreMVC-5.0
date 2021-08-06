using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using LKGGroup.Bookstore.Enums;
using LKGGroup.Bookstore.Helpers;
using Microsoft.AspNetCore.Http;

namespace LKGGroup.Bookstore.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength =2)]
        [Required(ErrorMessage = "Please enter Title of book")]
        //[MyCustomValidation("abc")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter Author of book")]
        public string Author { get; set; }

        [StringLength(500)]
        public string Discription { get; set; }

        public string Category { get; set; }

        [Required(ErrorMessage = "Please choose your book language")]
        public int LanguageId { get; set; }

       // [Required(ErrorMessage = "Please choose your book language")]
        public string Language { get; set; }

        [Required(ErrorMessage = "Please enter Total Pages of book")]
        [Display(Name = "Total Pages of Book")]
        public int? TotalPages { get; set; }

        [Display(Name = "Choose the cover photo of yout book")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }

        [Display(Name = "Choose the Gallery photo of your book")]
        [Required]
        public IFormFileCollection GalleryFiles { get; set; }

        public List<GalleryModel> Gallery { get; set; }

        [Display(Name = "Upload your book in Pdf format")]
        [Required]
        public IFormFile BookPdf { get; set; }
        public string BookPdfUrl { get; set; }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Data
{
    public class Books
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Discription { get; set; }

        public string Category { get; set; }
        public int LanguageId { get; set; }
        public int TotalPages { get; set; }
        public string CoverImageUrl { get; set; }
        public string BookPdfUrl { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public Language Language { get; set; }
        public ICollection<BookGallery> bookGallery { get; set; }
    }
}

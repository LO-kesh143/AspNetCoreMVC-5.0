﻿using LKGGroup.Bookstore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LKGGroup.Bookstore.Reopsitory
{
    public interface IBookRepository
    {
        Task<int> AddNewBook(BookModel model);
        Task<List<BookModel>> GetAllBooks();
        Task<BookModel> GetBookById(int id);
        Task<List<BookModel>> GetTopBookAsync(int count);
        List<BookModel> SearchBook(string title, string authorName);

        string GetAppName();
    }
}
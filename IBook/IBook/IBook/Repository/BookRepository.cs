﻿using IBook.Models;
using IBook.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace IBook.Repository
{
    public class BookRepository
    {
        private Service service { get; set; }
        public BookRepository()
        {
            service = new Service();
        }

        public void Add()
        {

        }
        public List<Book> ListAll()
        {
            return service.ListAllBook();
        }
        public void Update()
        {

        }
        public void SelectById()
        {

        }
        public void Delete()
        {

        }
        public void DeleteAll()
        {

        }
        public void SearchName()
        {

        }
    }
}
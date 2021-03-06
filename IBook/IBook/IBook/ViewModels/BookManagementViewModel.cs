﻿using IBook.Models;
using IBook.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace IBook.ViewModels
{
    public class BookManagementViewModel : INotifyPropertyChanged
    {
        public BookManagementViewModel()
        {
            bookRepository = new BookRepository();
            if (App.listBook == null)
            {
                GetBookList();
            }
            else BookList = App.listBook;
        }
        public async void GetBookList()
        {
            BookList = new ObservableCollection<Book>(await bookRepository.ListAll());
            foreach (Book item in BookList){
                object str = item.Hinh;
                item.Hinh= Xamarin.Forms.ImageSource.FromStream(
                () => new MemoryStream(Convert.FromBase64String(str.ToString())));
            }
            App.listBook = BookList;
            RaisePropertyChanged("BookList");
        }
        private BookRepository bookRepository { get; set; }
        public ObservableCollection<Book> BookList { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}

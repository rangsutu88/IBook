﻿using IBook.Models;
using IBook.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IBook.ViewModels
{
    public class AccountManagementViewModel
    {
        public AccountManagementViewModel()
        {
            userRepository = new UserRepository();
            GetUserList();
        }
        public async void GetUserList()
        {
            UserList = new ObservableCollection<User>(await userRepository.ListAll());
        }
        private UserRepository userRepository { get; set; }
        public ObservableCollection<User> UserList { get; set; }
    }
}
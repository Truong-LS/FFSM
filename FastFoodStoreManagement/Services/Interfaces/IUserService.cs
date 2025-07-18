
using DocumentFormat.OpenXml.Spreadsheet;
using Models;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User? GetUserById(int id);
        User? GetUserByUsername(string username);
        User? Login(string username, string password);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);

    }
} 

        

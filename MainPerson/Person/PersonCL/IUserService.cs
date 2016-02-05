﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PService
{
    public interface IUserService
    {
        List<UserViewModel> ReadAll();
        UserViewModel GetById(string id);
        void Update(UserViewModel person);
        void Add(UserViewModel person);
        void Delete(UserViewModel person);
        void UpdateUserData(UserViewModel user);
        PersonViewModel GetPersonById(int id);
        void UpdatePerson(PersonViewModel person);
        void DeletePerson(PersonViewModel person);
    }
}

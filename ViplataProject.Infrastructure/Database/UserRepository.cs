﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ViplataProject.Infrastructure.Mappers;
using ViplataProject.Infrastructure.ViewModels;


namespace ViplataProject.Infrastructure.Database
{
    public class UserRepository
    {
        public List<UserViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.User.ToList();
                return UserMapper.Map(items);
            }
        }
        public UserViewModel Login (string login, string password)
        {
            using (var context = new Context())
            {
                var item = context.User.FirstOrDefault(x => x.Login == login && x.Password == password);
                return UserMapper.Map(item);
            }

        }
        public UserViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.User.FirstOrDefault(x => x.ID == id);
                return UserMapper.Map(item);
            }
        }
    }
}

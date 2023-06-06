using HocTiengAnh.Models;
using HocTiengAnh.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HocTiengAnh.Services
{
    public class UserServices
    {
        private DataContext DataContext { get; set; }
        public UserServices() { 
            DataContext = new DataContext();
        }

        public List<UserModel> GetUsers()
        {
            return DataContext.Users.ToList();
        }

        public UserModel GetUserById(int id)
        {
            return DataContext.Users.Find(id);
        }

        public Models.UserModel AddUser(UserModel user)
        {
            // DataContext.Users.Add(user);
            // DataContext.SaveChanges();

            // //refesh lại id của user vừa thêm
            // DataContext.Entry(user).GetDatabaseValues();

            // //trả về id của user vừa thêm
            // return user;

            string sqlCommand = "insert into Users (UserName) values (@userName)";
            DataContext.Database.ExecuteSqlRaw(sqlCommand, new Microsoft.Data.SqlClient.SqlParameter("@userName", user.UserName));
            DataContext.SaveChanges();
            //lấy user vừa thêm
            DataContext.Entry(user).GetDatabaseValues();
            return DataContext.Users.OrderByDescending(x => x.UserID).FirstOrDefault();
        }

        public void DeleteUser(int id)
        {
            var user = DataContext.Users.Find(id);
            DataContext.Users.Remove(user);
            DataContext.SaveChanges();
        }

        public void UpdateUser(UserModel user)
        {
            var userUpdate = DataContext.Users.Find(user.UserID);
            userUpdate.UserName = user.UserName;
            DataContext.SaveChanges();
        }
    }
}

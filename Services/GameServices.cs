using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocTiengAnh.Models;
using HocTiengAnh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace HocTiengAnh.Services
{
    public class GameServices
    {
        private Data.DataContext _context { get; set; }
        public GameServices() { 
        _context = new Data.DataContext();
        }

        // phương thức add Game vào cơ sở dữ liệu
        public Models.GameModel AddNewGame(Models.GameModel newGame)
        {
            string sqlCommand = "Insert into Games(IsNew,LastTime,Level) values(@IsNew,@LastTime,@Level)";
            _context.Database.ExecuteSqlRaw(sqlCommand,
                new Microsoft.Data.SqlClient.SqlParameter("@IsNew", newGame.IsNew),
                new Microsoft.Data.SqlClient.SqlParameter("@LastTime", newGame.LastTime),
                new Microsoft.Data.SqlClient.SqlParameter("@Level", newGame.Level)
                );
            _context.SaveChanges();
            //refesh lại dữ liệu vừa thêm 
            _context.Entry(newGame).GetDatabaseValues();
            //trả về phần từ cuối cùng trong cơ sở dữ liệu
            return _context.Games.OrderByDescending(x => x.GameID).FirstOrDefault(); //FirstOrDefault trả về phần tử đầu tiên hoặc mặc định nếu không có phần tử nào trong danh sách, OrderByDescending sắp xếp giảm dần theo GameID 

        }

    }
}

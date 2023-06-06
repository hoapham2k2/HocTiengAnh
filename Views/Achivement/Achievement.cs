using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh.Views.Achivement
{
    public partial class Achievement : Form
    {
        public delegate void OpenTrangChu();
        public event OpenTrangChu openTrangChuHandler;

        //các service cần thiết
        public Data.DataContext _context { get; set; } = new Data.DataContext();

        public Achievement(OpenTrangChu openTrangChu)
        {
            this.openTrangChuHandler = openTrangChu;
            InitializeComponent();
            InitGrid();
            FixUI();
            initSound();
        }

        private void InitGrid()
        {
            //tiến hành join 3 bảng Users, Games, GameDetails
            var linqCommand = (from user in _context.Users
                               join gameDetail in _context.GameDetails on user.UserID equals gameDetail.UserID
                               join game in _context.Games on gameDetail.GameID equals game.GameID
                               join category in _context.Categories on gameDetail.CategoryID equals category.CategoryID
                               orderby gameDetail.GameScore descending
                               select new Models.DTOs.AchievementsGridModel
                               {
                                   STT = 0,
                                   UserName = user.UserName,
                                   CategoryName = category.CategoryName,
                                   GameScore = gameDetail.GameScore,
                                   GameTime = game.LastTime
                               }).Take(10).ToList();
            //đánh số thứ tự
            int i = 1;
            foreach (var item in linqCommand)
            {
                item.STT = i++;
            }

            //đổ dữ liệu vào grid
            this.GridAchievements.DataSource = linqCommand.ToList();
        }

        //sửa lại giao diện của grid
        private void FixUI()
        {
            //ẩn dòng header của grid
            this.GridAchievements.ColumnHeadersVisible = false;
            //ẩn row cuối cùng của grid
            this.GridAchievements.AllowUserToAddRows = false;
            //ẩn column đâu tiên của grid
            this.GridAchievements.RowHeadersVisible = false;
            //fill toàn bộ grid
            this.GridAchievements.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            openTrangChuHandler.Invoke();
            this.Close();
        }

        private void CheckBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSound.Checked)
            {
                Main.soundPlayer.PlayLooping();
                Main.CheckSoundBool = true;
            }
            else
            {
                Main.soundPlayer.Stop();
                Main.CheckSoundBool = false;
            }
        }
        public void initSound()
        {
            if (Main.CheckSoundBool)
            {
                CheckBoxSound.Checked = true;
            }
            else
            {
                CheckBoxSound.Checked = false;
            }
        }
    }
}

using HocTiengAnh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HocTiengAnh.Views.NewGame
{
    public partial class InputInfo : Form
    {
        public delegate void OpenTrangChu();
        public delegate void OpenNewGame();
        public event OpenTrangChu openTrangChuHandler;
        public event OpenNewGame openNewGameHandler;

        //Khởi tạo các biến cần thiết
        public static UserModel myUser { get; set; } = new UserModel();


        public InputInfo(OpenNewGame openNewGame, OpenTrangChu openTrangChu)
        {
            InitializeComponent();
            this.openTrangChuHandler = openTrangChu;
            this.openNewGameHandler = openNewGame;

        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                myUser.UserName = this.textBox1.Text;
                this.openNewGameHandler.Invoke();
                this.Close();
            }
        }
    }
}

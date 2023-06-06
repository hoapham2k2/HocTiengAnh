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
using HocTiengAnh.Services;
using System.Media;

namespace HocTiengAnh.Views.NewGame
{
    public partial class NewGame : Form
    {
        // Init delegate and event handler
        public delegate void OpenTrangChu();
        public event OpenTrangChu openTrangChuHandler;
        public delegate void OpenGameDetail();
        public event OpenGameDetail openGameDetailMediumHardHandler;
        public delegate void OpenDetailEasy();
        public event OpenDetailEasy openDetailEasyHandler;
        //Các Service cần thiết
        private CategoryServices categoryServices = new CategoryServices();
        private DictionariesServices dictionariesServices = new DictionariesServices();
        //Các biến cần thiết
        public static Models.GameModel myGame { get; set; } = new Models.GameModel();
        public static int CategoryID { get; set; } = 0;
        public NewGame(OpenDetailEasy openDetailEasy, OpenGameDetail openGameDetail, OpenTrangChu openTrangChu)
        {
            this.openTrangChuHandler = openTrangChu;
            this.openGameDetailMediumHardHandler = openGameDetail;
            this.openDetailEasyHandler = openDetailEasy;
            InitializeComponent();
            InitData();
            initSound();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (this.trackBar1.Value.ToString())
            {
                case "0":
                    myGame.Level = GameLevel.Easy;
                    this.LevelValue.ForeColor = Color.SkyBlue;
                    break;
                case "1":
                    myGame.Level = GameLevel.Medium;
                    this.LevelValue.ForeColor = Color.Orange;
                    break;
                case "2":
                    myGame.Level = GameLevel.Hard;
                    this.LevelValue.ForeColor = Color.Red;
                    break;
                default:
                    myGame.Level = GameLevel.Easy;
                    this.LevelValue.ForeColor = Color.LightBlue;
                    break;
            }
            this.LevelValue.Text = myGame.Level.ToString();
        }

        //start add category button to flowlayoutpanel
        private void InitData()
        {
            List<CategoryModel> categories = categoryServices.GetCategories();
            List<CategoryModel> categoriesTemp = new List<CategoryModel>();

            //lọc danh sách categories khi sum data > 0
            foreach (var i in categories)
            {
                List<DictionaryModel> data = dictionariesServices.GetDictionariesByCategoryId(i.CategoryID);
                if (data.Count > 0)
                {
                    categoriesTemp.Add(i);
                }
            }
            if (categoriesTemp.Count == 0)
            {
                MessageBox.Show("Không có chủ đề nào có dữ liệu");
                return;
            }

            this.FlowLayoutPanelCategory.Controls.Clear();
            foreach (var i in categoriesTemp)
            {
                Button btn = new Button();
                //edit appearance
                btn.Size = new Size(166, 150);
                // mảgin trái, trên, phải, dưới
                btn.Margin = new Padding(3, 3, 3, 20);

                btn.Text = i.CategoryName;
                btn.Tag = i.CategoryID;
                btn.Click += new EventHandler(this.btnCategory_Click);
                this.FlowLayoutPanelCategory.Controls.Add(btn);
            }

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int categoryID = (int)btn.Tag;
            CategoryID = categoryID;
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            openTrangChuHandler.Invoke();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CategoryID == 0)
            {
                MessageBox.Show("Bạn chưa chọn chủ đề");
            }
            else
            {
                switch (myGame.Level)
                {
                    case GameLevel.Medium:
                    case GameLevel.Hard:
                        openGameDetailMediumHardHandler.Invoke();
                        this.Close();
                        break;
                    case GameLevel.Easy:
                        openDetailEasyHandler.Invoke();
                        break;
                    default:
                        break;

                }
            }
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

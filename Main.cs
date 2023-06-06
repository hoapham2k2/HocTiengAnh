using HocTiengAnh.Views;
using HocTiengAnh.Views.Achivement;
using HocTiengAnh.Views.Dictionary;
using HocTiengAnh.Views.NewGame;

namespace HocTiengAnh
{
    public partial class Main : Form
    {
        public static bool CheckSoundBool { get; set; } = false;
        public Main()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openTrangChu();
        }

        public static Form myChildForm = new Form();
        public void OpenChildForm(Form form)
        {

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.FormPanel_main.Controls.Clear();
            this.FormPanel_main.Controls.Add(form);
            this.FormPanel_main.Tag = form;
            form.BringToFront();
            form.Show();
        }

        //load form trang chủ
        public void openTrangChu()
        {
            TrangChu trangChu = new TrangChu(OpenInputInfo,OpenNewGame, OpenAchievement, OpenDictionary);
            myChildForm = trangChu;
            OpenChildForm(myChildForm);
        }

        //Su kien NewGame
        public void OpenNewGame()
        {
            NewGame newGame = new NewGame(OpenDetailEasy, OpenGameDetail, openTrangChu);
            myChildForm = newGame;
            OpenChildForm(myChildForm);
        }

        //Su kien Achivement
        public void OpenAchievement()
        {
            Achievement achievement = new Achievement(openTrangChu);
            myChildForm = achievement;
            OpenChildForm(myChildForm);
        }

        //Su kien Dictionary
        public void OpenDictionary()
        {
            Dictionary dictionary = new Dictionary(openTrangChu);
            myChildForm = dictionary;
            OpenChildForm(myChildForm);
        }


        // Su kiẹn GameDetail
        public void OpenGameDetail(){
            GameDetail_Medium gameDetail = new GameDetail_Medium(openTrangChu);
            myChildForm = gameDetail;
            OpenChildForm(myChildForm);
        }

        // Su kiẹn InputInfo
        public void OpenInputInfo()
        {
            InputInfo inputInfo = new InputInfo(OpenNewGame,openTrangChu);
            myChildForm = inputInfo;
            OpenChildForm(myChildForm);
        }

        //Su kien mo form game detail easy
        public void OpenDetailEasy()
        {
            GameDetail_Easy gameDetail_Easy = new GameDetail_Easy(openTrangChu);
            myChildForm = gameDetail_Easy;
            OpenChildForm(myChildForm);
        }





    }
}
using HocTiengAnh.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace HocTiengAnh.Views.NewGame
{
    public partial class GameDetail_Medium : Form
    {

        //Các delegate và event handler cần thiết
        public delegate void openTrangChu();
        public event openTrangChu openTrangChuHandler;
        //Các Service cần thiết
        public Services.DictionariesServices DictionariesServices { get; set; } = new Services.DictionariesServices();
        public Services.UserServices UserServices { get; set; } = new Services.UserServices();
        public Services.GameServices GameServices { get; set; } = new Services.GameServices();
        public Services.GameDetailServices GameDetailServices { get; set; } = new Services.GameDetailServices();
        //Các biến cần thiết
        public static Models.GameDetailModel myGameDetail { get; set; }
        public List<Models.DictionaryModel>? myListDictionary { get; set; }
        public Models.DictionaryModel? currentDictionary { get; set; }
        //kiểm tra tình trạng câu hỏi hiện tại
        public static bool gameStatus { get; set; } = true;//true = đúng, và false = sai
        public static int DictionaryIndex { get; set; } = 0;// vị trí của câu hỏi hiện tại
        public static int DictionaryCount { get; set; } = 0; // tổng số câu hỏi
        //Count time
        public static int timeCount { get; set; } = 10;
        public static System.Windows.Forms.Timer myTimer { get; set; } = new System.Windows.Forms.Timer();

        public GameDetail_Medium(openTrangChu openTrangChu)
        {
            
            openTrangChuHandler = openTrangChu;
            myListDictionary = new List<Models.DictionaryModel>();
            currentDictionary = new Models.DictionaryModel();
            myGameDetail = new GameDetailModel();
            int CategoryID = Views.NewGame.NewGame.CategoryID;
            myListDictionary = DictionariesServices.GetTop5RandomFromCategory(CategoryID);
            InitializeComponent();
            initSound();
            //Cập nhật danh sách ban đầu
            DictionaryCount = myListDictionary.Count;
            this.QuestionStatusTitle.Text = DictionaryIndex.ToString() + "/" + DictionaryCount.ToString();
            //Cập nhật điểm số ban đầu
            this.ScoreStatusTitle.Text = "Score: " + myGameDetail.GameScore.ToString();
            //cập nhật thời gian game
            switch (Views.NewGame.NewGame.myGame.Level)
            {
                case GameLevel.Hard:
                    timeCount = 10;
                    break;
                case GameLevel.Medium:
                    timeCount = 15;
                    break;
                default:
                    break;
            }
            this.Clock.Text = timeCount.ToString();
            LoadGame();
        }
        public void LoadGame()
        {
            if (myListDictionary.Count > 0)
            {
                //Acitve text box
                this.TextValue.Enabled = true;
                //load picturebox
                currentDictionary = myListDictionary.ElementAt(0);
                // Xóa từ vừa lấy khỏi danh sách
                myListDictionary.RemoveAt(0);
                //cập nhật lại danh sách
                DictionaryIndex++;
                this.QuestionStatusTitle.Text = DictionaryIndex.ToString() + "/" + DictionaryCount.ToString();
                // load picturebox
                byte[] imageBytes = currentDictionary.DictionaryImageURL;
                if (imageBytes != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                    this.PictureDictionary.Image = Image.FromStream(ms);
                }
                //load clock
                LoadTimer();
            }
            else
            {
                //Thông báo game kết thúc
                MessageBox.Show("Game over!");

                try
                {
                    NewGame.myGame.LastTime = DateTime.Now.ToString();
                    //Lưu người dùng vào database
                    Models.UserModel myUser = UserServices.AddUser(InputInfo.myUser);
                    //Lưu game vào database
                    Models.GameModel myGame = GameServices.AddNewGame(NewGame.myGame);
                    //Lưu chi tiết game vào database
                    myGameDetail.GameID = myGame.GameID;
                    myGameDetail.UserID = myUser.UserID;
                    myGameDetail.CategoryID = Views.NewGame.NewGame.CategoryID;
                    myGameDetail.GameScore = myGameDetail.GameScore;

                    GameDetailServices.AddGameDetail(myGameDetail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong: " + ex.Message);
                }
                //dừng timer
                myTimer.Stop();
                //reset mọi thứ
                myGameDetail = new GameDetailModel();
                DictionaryIndex = 0;

                //trở về trang chủ khi nhấn nút back
                this.openTrangChuHandler.Invoke();
                this.Dispose();

            }
        }

        private void LoadTimer()
        {
            //cập nhật thời gian game
            switch (Views.NewGame.NewGame.myGame.Level)
            {
                case GameLevel.Hard:
                    timeCount = 10;
                    break;
                case GameLevel.Medium:
                    timeCount = 15;
                    break;
                default:
                    break;
            }
            this.Clock.Text = timeCount.ToString();
            myTimer = new System.Windows.Forms.Timer();
            myTimer.Interval = 1000; // 1s
            myTimer.Tick += new EventHandler(Timer_Tick);
            myTimer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //giảm giá trị đếm ngược
            if (timeCount > 0)
            {
                timeCount--;
                this.Clock.Text = timeCount.ToString();
            }
            else
            {
                myTimer.Stop();
                this.TextValue.Enabled = false;//Inactive Text box
                MessageBox.Show("Time out!");
                //Kiểm tra đáp án
                if (string.Equals(this.TextValue.Text.ToLower(), currentDictionary.DictionaryWord.ToLower()))
                {
                    gameStatus = true;
                    myGameDetail.GameScore += 10;
                }
                else
                {
                    gameStatus = false;
                    myGameDetail.GameScore += 0;
                }
                //Cập nhật lại danh sách tình trạng
                UpdateCheck(gameStatus);
                // Cập nhật điểm
                this.ScoreStatusTitle.Text = "Score: " + myGameDetail.GameScore.ToString();
                //reset lai TextValue
                this.TextValue.Text = "";
                LoadGame();
            }
        }

        public void InitInformation()
        {
            myGameDetail.GameID = NewGame.myGame.GameID;
        }
        //cập nhật trạng thái câu hỏi
        public void UpdateCheck(bool gameStatus)
        {
            //tạo 1 button
            Button btn = new Button();
            btn.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            if (gameStatus)
            {
                btn.Image = Properties.Resources.correct;
            }
            else
            {
                btn.Image = Properties.Resources.close;
            }
            btn.ImageAlign = ContentAlignment.MiddleRight;
            btn.Name = "button" + DictionaryIndex.ToString();
            btn.Size = new Size(192, 51);
            btn.Text = "Question " + DictionaryIndex.ToString();
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            //add button vào panel
            this.LayoutPanelStatusCheckBox.Controls.Add(btn);
        }



        private void ButtonBackHome_Click(object sender, EventArgs e)
        {
            //Hỏi người dùng có muốn thoát không
            DialogResult dialogResult = MessageBox.Show("Do you want to save your result before out game?", "Message", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    NewGame.myGame.LastTime = DateTime.Now.ToString();

                    //Lưu người dùng vào database
                    Models.UserModel myUser = UserServices.AddUser(InputInfo.myUser);
                    //Lưu game vào database
                    Models.GameModel myGame = GameServices.AddNewGame(NewGame.myGame);
                    //Lưu chi tiết game vào database
                    myGameDetail.GameID = myGame.GameID;
                    myGameDetail.UserID = myUser.UserID;
                    myGameDetail.CategoryID = Views.NewGame.NewGame.CategoryID;
                    myGameDetail.GameScore = myGameDetail.GameScore;

                    GameDetailServices.AddGameDetail(myGameDetail);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something wrong: " + ex.Message);
                    //lưu vào file bug
                    using (StreamWriter sw = File.AppendText("bug.txt"))//lưu tại 
                    {
                        sw.WriteLine("Error at: " + DateTime.Now.ToString());
                        sw.WriteLine("Error Message: " + ex.Message);
                        sw.WriteLine("Error StackTrace: " + ex.StackTrace);
                        sw.WriteLine("Error Source: " + ex.Source);
                        sw.WriteLine("Error TargetSite: " + ex.TargetSite);
                        sw.WriteLine("Error Data: " + ex.Data);
                        sw.WriteLine("Error InnerException: " + ex.InnerException);
                        sw.WriteLine("Error HelpLink: " + ex.HelpLink);
                        sw.WriteLine("Error HResult: " + ex.HResult);
                        sw.WriteLine("Error ToString: " + ex.ToString());
                        sw.WriteLine("Error End");
                        sw.WriteLine("------------------------------------------");
                    }
                }

            }
            //dừng timer
            myTimer.Stop();
            //reset mọi thứ
            myGameDetail = new GameDetailModel();
            DictionaryIndex = 0;

            //trở về trang chủ khi nhấn nút back
            this.openTrangChuHandler.Invoke();
            this.Dispose();
        }

        private void TextValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Kiểm tra phím nhấn là phím enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                //xóa đồng hồ


                myTimer.Stop();
                myTimer = new System.Windows.Forms.Timer();




                //Kiểm tra đáp án
                if (string.Equals(this.TextValue.Text.ToLower(), currentDictionary.DictionaryWord.ToLower()))
                {
                    gameStatus = true;
                    myGameDetail.GameScore += 10;
                }
                else
                {
                    gameStatus = false;
                    myGameDetail.GameScore += 0;
                }
                //Cập nhật lại danh sách tình trạng
                UpdateCheck(gameStatus);
                // Cập nhật điểm
                this.ScoreStatusTitle.Text = "Score: " + myGameDetail.GameScore.ToString();
                //reset lai TextValue
                this.TextValue.Text = "";
                LoadGame();
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

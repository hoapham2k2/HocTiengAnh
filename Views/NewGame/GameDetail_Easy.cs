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
using Microsoft.EntityFrameworkCore; //thêm thư viện này để sử dụng FromSqlRaw


namespace HocTiengAnh.Views.NewGame
{
    public partial class GameDetail_Easy : Form
    {
        //Cac delegate and event handler
        public delegate void OpenTrangChu();
        public event OpenTrangChu OpenTrangChuHandler;
        //Các Service cần thiết
        public Services.DictionariesServices DictionariesServices { get; set; } = new Services.DictionariesServices();
        public Services.UserServices UserServices { get; set; } = new Services.UserServices();
        public Services.GameServices GameServices { get; set; } = new Services.GameServices();
        public Services.GameDetailServices GameDetailServices { get; set; } = new Services.GameDetailServices();
        //Các biến cần thiết
        public static Models.GameDetailModel myGameDetail { get; set; }
        public static bool gameStatus { get; set; } = true;//true = đúng, và false = sai
        public static int DictionaryIndex { get; set; } = 1;// vị trí của câu hỏi hiện tại
        public static int DictionaryCount { get; set; } = 5; // tổng số câu hỏi

        public static Models.DTOs.QuizEasy goodAnswer { get; set; } // câu trả lời đúng
        public static List<Models.DTOs.QuizEasy> listAnswer { get; set; } // danh sách câu trả lời sai
        // Data Context
        public Data.DataContext _context { get; set; }
        public GameDetail_Easy(OpenTrangChu openTrangChu)
        {
            this.OpenTrangChuHandler = openTrangChu;
            _context = new Data.DataContext();
            myGameDetail = new GameDetailModel();
            int CategoryID = Views.NewGame.NewGame.CategoryID;//lấy CategoryID

            InitializeComponent();
            //Thiết lập các Label
            this.QuestionStatusTitle.Text = "Question " + DictionaryIndex + "/" + DictionaryCount;
            this.ScoreStatusTitle.Text = myGameDetail.GameScore.ToString();
            initSound();
            LoadGame();
        }

        private void LoadGame()
        {
            //thực hiện đúng 5 lần
            if (DictionaryIndex <= 5)
            {

                var sqlCommand = @"SELECT TOP 4 
                        D.DictionaryID,D.DictionaryWord,D.DictionaryImageURL,
                       CASE WHEN ROW_NUMBER() OVER (ORDER BY NEWID()) = 1 THEN 'T' ELSE 'F' END AS Answer
                    FROM 
                        Dictionaries D
                    WHERE
	                    D.CategoryID =  " + Views.NewGame.NewGame.CategoryID + @"
                    ORDER BY 
                        NEWID()
                        ";
                var list = _context.Set<Models.DTOs.QuizEasy>().FromSqlRaw(sqlCommand).ToList();
                //lấy ra câu hỏi hiện tại
                goodAnswer = list.Where(x => x.Answer == "T").FirstOrDefault();
                //lấy ra 3 câu trả lời sai
                listAnswer = list.Where(x => x.Answer == "F").ToList();

                //sử lý bug
                if (listAnswer.Count == 4 || listAnswer.Count == 0)
                {
                    LoadGame();
                    return;
                }
                //thêm câu trả lời đúng vào trong pictureBox
                using (MemoryStream ms = new MemoryStream(goodAnswer.DictionaryImageURL))
                {
                    this.PictureDictionary.Image = Image.FromStream(ms);
                }

                //thêm câu trả lời sai và cả đúng vào trong danh sách button câu trả lời
                foreach (var i in list)
                {
                    Button btn = new Button();
                    btn.Text = i.DictionaryWord;
                    btn.Tag = i.Answer;
                    btn.Click += Btn_Click;
                    btn.Width = 280;
                    btn.Height = 100;
                    this.FlowLayoutListAnswer.Controls.Add(btn);
                }
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            //disable tất cả button
            foreach (Button button in FlowLayoutListAnswer.Controls.OfType<Button>())
            {
                button.Enabled = false;
            }

            //lấy ra button được click
            Button btn = sender as Button;
            //lấy ra câu trả lời
            string answer = btn.Tag.ToString();
            //kiểm tra câu trả lời
            if (answer == "T")
            {
                gameStatus = true; //câu hỏi chính xác
                //cộng điểm
                myGameDetail.GameScore += 10;
            }
            else
            {
                gameStatus = false;
                //trừ điểm
                myGameDetail.GameScore += 0;
            }
            //cập nhật điểm sau khi tính
            this.ScoreStatusTitle.Text = myGameDetail.GameScore.ToString();
            //cập nhật trạng thái câu hỏi
            UpdateCheck(gameStatus);
            DictionaryIndex++;

        }
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
            int index = DictionaryIndex;
            btn.Name = "button" + index.ToString();
            btn.Size = new Size(192, 51);
            btn.Text = "Question " + index.ToString();
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.UseVisualStyleBackColor = true;
            //add button vào panel
            this.LayoutPanelStatusCheckBox.Controls.Add(btn);
        }

        private void BtnBackHome_Click(object sender, EventArgs e)
        {//Hỏi người dùng có muốn thoát không
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
                }

                //reset mọi thứ
                myGameDetail = new GameDetailModel();
                DictionaryIndex = 1;
                OpenTrangChuHandler.Invoke();
                this.Close();
            }
        }

        private void BtnNextQuestion_Click(object sender, EventArgs e)
        {
            if (DictionaryIndex <= DictionaryCount)
            {
                //cập nhật index 
                this.QuestionStatusTitle.Text = "Question " + DictionaryIndex + "/" + DictionaryCount;
                this.ScoreStatusTitle.Text = myGameDetail.GameScore.ToString();
                //clear nội dụng trong flow layout
                this.FlowLayoutListAnswer.Controls.Clear();
                LoadGame();
            }
            else
            {
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
                //reset mọi thứ
                myGameDetail = new GameDetailModel();
                DictionaryIndex = 1;
                OpenTrangChuHandler.Invoke();
                this.Close();
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

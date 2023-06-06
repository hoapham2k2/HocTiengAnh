namespace HocTiengAnh.Views.NewGame
{
    partial class GameDetail_Easy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelDetailEasy = new Panel();
            BtnNextQuestion = new Button();
            FlowLayoutListAnswer = new FlowLayoutPanel();
            LayoutPanelStatusCheckBox = new FlowLayoutPanel();
            PictureDictionary = new PictureBox();
            ScoreStatusTitle = new Label();
            QuestionStatusTitle = new Label();
            BtnBackHome = new Button();
            CheckBoxSound = new CheckBox();
            PanelDetailEasy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureDictionary).BeginInit();
            SuspendLayout();
            // 
            // PanelDetailEasy
            // 
            PanelDetailEasy.Controls.Add(CheckBoxSound);
            PanelDetailEasy.Controls.Add(BtnNextQuestion);
            PanelDetailEasy.Controls.Add(FlowLayoutListAnswer);
            PanelDetailEasy.Controls.Add(LayoutPanelStatusCheckBox);
            PanelDetailEasy.Controls.Add(PictureDictionary);
            PanelDetailEasy.Controls.Add(ScoreStatusTitle);
            PanelDetailEasy.Controls.Add(QuestionStatusTitle);
            PanelDetailEasy.Controls.Add(BtnBackHome);
            PanelDetailEasy.Dock = DockStyle.Fill;
            PanelDetailEasy.Location = new Point(0, 0);
            PanelDetailEasy.Margin = new Padding(3, 4, 3, 4);
            PanelDetailEasy.Name = "PanelDetailEasy";
            PanelDetailEasy.Size = new Size(896, 748);
            PanelDetailEasy.TabIndex = 0;
            // 
            // BtnNextQuestion
            // 
            BtnNextQuestion.Location = new Point(675, 671);
            BtnNextQuestion.Margin = new Padding(3, 4, 3, 4);
            BtnNextQuestion.Name = "BtnNextQuestion";
            BtnNextQuestion.Size = new Size(186, 61);
            BtnNextQuestion.TabIndex = 11;
            BtnNextQuestion.Text = "Next Question";
            BtnNextQuestion.UseVisualStyleBackColor = true;
            BtnNextQuestion.Click += BtnNextQuestion_Click;
            // 
            // FlowLayoutListAnswer
            // 
            FlowLayoutListAnswer.Location = new Point(48, 385);
            FlowLayoutListAnswer.Margin = new Padding(3, 4, 3, 4);
            FlowLayoutListAnswer.Name = "FlowLayoutListAnswer";
            FlowLayoutListAnswer.Size = new Size(814, 259);
            FlowLayoutListAnswer.TabIndex = 10;
            // 
            // LayoutPanelStatusCheckBox
            // 
            LayoutPanelStatusCheckBox.FlowDirection = FlowDirection.TopDown;
            LayoutPanelStatusCheckBox.Location = new Point(639, 32);
            LayoutPanelStatusCheckBox.Margin = new Padding(3, 4, 3, 4);
            LayoutPanelStatusCheckBox.Name = "LayoutPanelStatusCheckBox";
            LayoutPanelStatusCheckBox.Size = new Size(223, 325);
            LayoutPanelStatusCheckBox.TabIndex = 9;
            // 
            // PictureDictionary
            // 
            PictureDictionary.ImageLocation = "";
            PictureDictionary.InitialImage = null;
            PictureDictionary.Location = new Point(250, 32);
            PictureDictionary.Margin = new Padding(3, 4, 3, 4);
            PictureDictionary.Name = "PictureDictionary";
            PictureDictionary.Size = new Size(367, 325);
            PictureDictionary.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureDictionary.TabIndex = 8;
            PictureDictionary.TabStop = false;
            // 
            // ScoreStatusTitle
            // 
            ScoreStatusTitle.AutoSize = true;
            ScoreStatusTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreStatusTitle.Location = new Point(10, 95);
            ScoreStatusTitle.Name = "ScoreStatusTitle";
            ScoreStatusTitle.Size = new Size(156, 46);
            ScoreStatusTitle.TabIndex = 7;
            ScoreStatusTitle.Text = "Score: 30";
            // 
            // QuestionStatusTitle
            // 
            QuestionStatusTitle.AutoSize = true;
            QuestionStatusTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionStatusTitle.Location = new Point(10, 32);
            QuestionStatusTitle.Name = "QuestionStatusTitle";
            QuestionStatusTitle.Size = new Size(214, 46);
            QuestionStatusTitle.TabIndex = 6;
            QuestionStatusTitle.Text = "Question 3/5";
            // 
            // BtnBackHome
            // 
            BtnBackHome.Location = new Point(48, 672);
            BtnBackHome.Margin = new Padding(3, 4, 3, 4);
            BtnBackHome.Name = "BtnBackHome";
            BtnBackHome.Size = new Size(200, 60);
            BtnBackHome.TabIndex = 0;
            BtnBackHome.Text = "Back To Home";
            BtnBackHome.UseVisualStyleBackColor = true;
            BtnBackHome.Click += BtnBackHome_Click;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(47, 296);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 12;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            // 
            // GameDetail_Easy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(PanelDetailEasy);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameDetail_Easy";
            Text = "GameDetail_Easy";
            PanelDetailEasy.ResumeLayout(false);
            PanelDetailEasy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureDictionary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDetailEasy;
        private Button BtnBackHome;
        private Button BtnNextQuestion;
        private FlowLayoutPanel FlowLayoutListAnswer;
        private FlowLayoutPanel LayoutPanelStatusCheckBox;
        private PictureBox PictureDictionary;
        private Label ScoreStatusTitle;
        private Label QuestionStatusTitle;
        private CheckBox CheckBoxSound;
    }
}
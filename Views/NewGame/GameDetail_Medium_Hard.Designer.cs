namespace HocTiengAnh.Views.NewGame
{
    partial class GameDetail_Medium
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
            QuestionStatusTitle = new Label();
            ScoreStatusTitle = new Label();
            Clock = new Label();
            PictureDictionary = new PictureBox();
            TextValue = new TextBox();
            GamePanel = new Panel();
            ButtonBackHome = new Button();
            LayoutPanelStatusCheckBox = new FlowLayoutPanel();
            CheckBoxSound = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)PictureDictionary).BeginInit();
            GamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // QuestionStatusTitle
            // 
            QuestionStatusTitle.AutoSize = true;
            QuestionStatusTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionStatusTitle.Location = new Point(14, 152);
            QuestionStatusTitle.Name = "QuestionStatusTitle";
            QuestionStatusTitle.Size = new Size(214, 46);
            QuestionStatusTitle.TabIndex = 0;
            QuestionStatusTitle.Text = "Question 3/5";
            // 
            // ScoreStatusTitle
            // 
            ScoreStatusTitle.AutoSize = true;
            ScoreStatusTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ScoreStatusTitle.Location = new Point(14, 215);
            ScoreStatusTitle.Name = "ScoreStatusTitle";
            ScoreStatusTitle.Size = new Size(156, 46);
            ScoreStatusTitle.TabIndex = 1;
            ScoreStatusTitle.Text = "Score: 30";
            // 
            // Clock
            // 
            Clock.AutoSize = true;
            Clock.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Clock.Location = new Point(14, 12);
            Clock.Name = "Clock";
            Clock.Size = new Size(56, 46);
            Clock.TabIndex = 2;
            Clock.Text = "10";
            // 
            // PictureDictionary
            // 
            PictureDictionary.ImageLocation = "";
            PictureDictionary.InitialImage = null;
            PictureDictionary.Location = new Point(254, 152);
            PictureDictionary.Margin = new Padding(3, 4, 3, 4);
            PictureDictionary.Name = "PictureDictionary";
            PictureDictionary.Size = new Size(367, 325);
            PictureDictionary.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureDictionary.TabIndex = 3;
            PictureDictionary.TabStop = false;
            // 
            // TextValue
            // 
            TextValue.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextValue.Location = new Point(254, 515);
            TextValue.Margin = new Padding(3, 4, 3, 4);
            TextValue.Name = "TextValue";
            TextValue.Size = new Size(366, 52);
            TextValue.TabIndex = 4;
            TextValue.TextAlign = HorizontalAlignment.Center;
            TextValue.KeyPress += TextValue_KeyPress;
            // 
            // GamePanel
            // 
            GamePanel.Controls.Add(CheckBoxSound);
            GamePanel.Controls.Add(ButtonBackHome);
            GamePanel.Controls.Add(LayoutPanelStatusCheckBox);
            GamePanel.Controls.Add(TextValue);
            GamePanel.Controls.Add(PictureDictionary);
            GamePanel.Controls.Add(Clock);
            GamePanel.Controls.Add(ScoreStatusTitle);
            GamePanel.Controls.Add(QuestionStatusTitle);
            GamePanel.Dock = DockStyle.Fill;
            GamePanel.Location = new Point(0, 0);
            GamePanel.Margin = new Padding(3, 4, 3, 4);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(896, 748);
            GamePanel.TabIndex = 0;
            // 
            // ButtonBackHome
            // 
            ButtonBackHome.Location = new Point(14, 663);
            ButtonBackHome.Margin = new Padding(3, 4, 3, 4);
            ButtonBackHome.Name = "ButtonBackHome";
            ButtonBackHome.Size = new Size(197, 69);
            ButtonBackHome.TabIndex = 7;
            ButtonBackHome.Text = "Back To Home";
            ButtonBackHome.UseVisualStyleBackColor = true;
            ButtonBackHome.Click += ButtonBackHome_Click;
            // 
            // LayoutPanelStatusCheckBox
            // 
            LayoutPanelStatusCheckBox.FlowDirection = FlowDirection.TopDown;
            LayoutPanelStatusCheckBox.Location = new Point(642, 152);
            LayoutPanelStatusCheckBox.Margin = new Padding(3, 4, 3, 4);
            LayoutPanelStatusCheckBox.Name = "LayoutPanelStatusCheckBox";
            LayoutPanelStatusCheckBox.Size = new Size(223, 325);
            LayoutPanelStatusCheckBox.TabIndex = 5;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(12, 453);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 10;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            // 
            // GameDetail_Medium
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(GamePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GameDetail_Medium";
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)PictureDictionary).EndInit();
            GamePanel.ResumeLayout(false);
            GamePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label QuestionStatusTitle;
        private Label ScoreStatusTitle;
        private Label Clock;
        private PictureBox PictureDictionary;
        private TextBox TextValue;
        private Panel GamePanel;
        private FlowLayoutPanel LayoutPanelStatusCheckBox;
        private Button ButtonBackHome;
        private CheckBox CheckBoxSound;
    }
}
namespace HocTiengAnh.Views.NewGame
{
    partial class NewGame
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
            NewGamePanel = new Panel();
            btnNext = new Button();
            trackBar1 = new TrackBar();
            LevelTitle = new Label();
            LevelValue = new Label();
            FlowLayoutPanelCategory = new FlowLayoutPanel();
            btnBackHome = new Button();
            label1 = new Label();
            CheckBoxSound = new CheckBox();
            NewGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // NewGamePanel
            // 
            NewGamePanel.Controls.Add(CheckBoxSound);
            NewGamePanel.Controls.Add(btnNext);
            NewGamePanel.Controls.Add(trackBar1);
            NewGamePanel.Controls.Add(LevelTitle);
            NewGamePanel.Controls.Add(LevelValue);
            NewGamePanel.Controls.Add(FlowLayoutPanelCategory);
            NewGamePanel.Controls.Add(btnBackHome);
            NewGamePanel.Controls.Add(label1);
            NewGamePanel.Dock = DockStyle.Fill;
            NewGamePanel.Location = new Point(0, 0);
            NewGamePanel.Margin = new Padding(3, 4, 3, 4);
            NewGamePanel.Name = "NewGamePanel";
            NewGamePanel.Size = new Size(896, 748);
            NewGamePanel.TabIndex = 0;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.Location = new Point(543, 627);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(339, 105);
            btnNext.TabIndex = 8;
            btnNext.Text = "GO GO";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(408, 539);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(474, 56);
            trackBar1.TabIndex = 7;
            trackBar1.TickStyle = TickStyle.Both;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // LevelTitle
            // 
            LevelTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LevelTitle.Location = new Point(17, 528);
            LevelTitle.Name = "LevelTitle";
            LevelTitle.Size = new Size(222, 77);
            LevelTitle.TabIndex = 5;
            LevelTitle.Text = "Choose your level: ";
            LevelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LevelValue
            // 
            LevelValue.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LevelValue.ForeColor = Color.SkyBlue;
            LevelValue.Location = new Point(261, 528);
            LevelValue.Name = "LevelValue";
            LevelValue.Size = new Size(111, 77);
            LevelValue.TabIndex = 6;
            LevelValue.Text = "Easy";
            LevelValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanelCategory
            // 
            FlowLayoutPanelCategory.Location = new Point(14, 141);
            FlowLayoutPanelCategory.Margin = new Padding(3, 4, 3, 4);
            FlowLayoutPanelCategory.Name = "FlowLayoutPanelCategory";
            FlowLayoutPanelCategory.Size = new Size(869, 368);
            FlowLayoutPanelCategory.TabIndex = 4;
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(12, 674);
            btnBackHome.Margin = new Padding(3, 4, 3, 4);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(126, 61);
            btnBackHome.TabIndex = 3;
            btnBackHome.Text = "Back To Home";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(893, 116);
            label1.TabIndex = 2;
            label1.Text = "New Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(14, 627);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 9;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(NewGamePanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewGame";
            Text = "NewGame";
            NewGamePanel.ResumeLayout(false);
            NewGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel NewGamePanel;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel FlowLayoutPanelCategory;
        private Button btnBackHome;
        private Label label1;
        private TrackBar trackBar1;
        private Label LevelTitle;
        private Label LevelValue;
        private Button btnNext;
        private CheckBox CheckBoxSound;
    }
}
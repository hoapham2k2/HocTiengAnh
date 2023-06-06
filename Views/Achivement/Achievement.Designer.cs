namespace HocTiengAnh.Views.Achivement
{
    partial class Achievement
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
            btnBackHome = new Button();
            PanelAchievements = new Panel();
            BtnBack = new Button();
            GridAchievements = new DataGridView();
            AchievemenTitle = new Label();
            CheckBoxSound = new CheckBox();
            PanelAchievements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridAchievements).BeginInit();
            SuspendLayout();
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(0, 0);
            btnBackHome.Margin = new Padding(3, 4, 3, 4);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(86, 31);
            btnBackHome.TabIndex = 4;
            // 
            // PanelAchievements
            // 
            PanelAchievements.Controls.Add(CheckBoxSound);
            PanelAchievements.Controls.Add(BtnBack);
            PanelAchievements.Controls.Add(GridAchievements);
            PanelAchievements.Controls.Add(AchievemenTitle);
            PanelAchievements.Dock = DockStyle.Fill;
            PanelAchievements.Location = new Point(0, 0);
            PanelAchievements.Name = "PanelAchievements";
            PanelAchievements.Size = new Size(896, 748);
            PanelAchievements.TabIndex = 3;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(57, 663);
            BtnBack.Margin = new Padding(3, 4, 3, 4);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(193, 56);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "OK";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // GridAchievements
            // 
            GridAchievements.AllowUserToAddRows = false;
            GridAchievements.AllowUserToDeleteRows = false;
            GridAchievements.BackgroundColor = SystemColors.ActiveCaption;
            GridAchievements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridAchievements.Location = new Point(57, 95);
            GridAchievements.Name = "GridAchievements";
            GridAchievements.ReadOnly = true;
            GridAchievements.RowHeadersWidth = 51;
            GridAchievements.RowTemplate.Height = 29;
            GridAchievements.Size = new Size(781, 532);
            GridAchievements.TabIndex = 3;
            // 
            // AchievemenTitle
            // 
            AchievemenTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AchievemenTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            AchievemenTitle.Location = new Point(0, 0);
            AchievemenTitle.Name = "AchievemenTitle";
            AchievemenTitle.Size = new Size(893, 92);
            AchievemenTitle.TabIndex = 2;
            AchievemenTitle.Text = "Achivement";
            AchievemenTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(719, 663);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 12;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            // 
            // Achievement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(PanelAchievements);
            Controls.Add(btnBackHome);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Achievement";
            Text = "Achievement";
            PanelAchievements.ResumeLayout(false);
            PanelAchievements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridAchievements).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnBackHome;
        private Panel PanelAchievements;
        private DataGridView GridAchievements;
        private Label AchievemenTitle;
        private Button BtnBack;
        private CheckBox CheckBoxSound;
    }
}
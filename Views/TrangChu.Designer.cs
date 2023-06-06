namespace HocTiengAnh.Views
{
    partial class TrangChu
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
            TrangChuPanel = new Panel();
            CheckBoxSound = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            BatDau = new Button();
            DiemSo = new Button();
            TuDien = new Button();
            TrangChuTitle = new Label();
            TrangChuPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TrangChuPanel
            // 
            TrangChuPanel.Controls.Add(CheckBoxSound);
            TrangChuPanel.Controls.Add(tableLayoutPanel1);
            TrangChuPanel.Controls.Add(TrangChuTitle);
            TrangChuPanel.Dock = DockStyle.Fill;
            TrangChuPanel.Location = new Point(0, 0);
            TrangChuPanel.Margin = new Padding(3, 4, 3, 4);
            TrangChuPanel.Name = "TrangChuPanel";
            TrangChuPanel.Size = new Size(896, 748);
            TrangChuPanel.TabIndex = 0;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(774, 170);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 2;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(BatDau, 0, 0);
            tableLayoutPanel1.Controls.Add(DiemSo, 0, 1);
            tableLayoutPanel1.Controls.Add(TuDien, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 359);
            tableLayoutPanel1.Margin = new Padding(11, 13, 11, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(896, 265);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // BatDau
            // 
            BatDau.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            BatDau.BackColor = Color.Transparent;
            BatDau.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BatDau.Location = new Point(171, 10);
            BatDau.Margin = new Padding(171, 0, 171, 0);
            BatDau.Name = "BatDau";
            BatDau.Size = new Size(554, 67);
            BatDau.TabIndex = 0;
            BatDau.Text = "Start Game";
            BatDau.UseVisualStyleBackColor = false;
            BatDau.Click += BatDau_Click;
            // 
            // DiemSo
            // 
            DiemSo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DiemSo.BackColor = Color.Transparent;
            DiemSo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DiemSo.Location = new Point(171, 98);
            DiemSo.Margin = new Padding(171, 0, 171, 0);
            DiemSo.Name = "DiemSo";
            DiemSo.Size = new Size(554, 67);
            DiemSo.TabIndex = 1;
            DiemSo.Text = "Achievement";
            DiemSo.UseVisualStyleBackColor = false;
            DiemSo.Click += DiemSo_Click;
            // 
            // TuDien
            // 
            TuDien.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TuDien.BackColor = Color.Transparent;
            TuDien.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TuDien.Location = new Point(171, 187);
            TuDien.Margin = new Padding(171, 0, 171, 0);
            TuDien.Name = "TuDien";
            TuDien.Size = new Size(554, 67);
            TuDien.TabIndex = 2;
            TuDien.Text = "Dictionary";
            TuDien.UseVisualStyleBackColor = false;
            TuDien.Click += TuDien_Click;
            // 
            // TrangChuTitle
            // 
            TrangChuTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            TrangChuTitle.Location = new Point(0, 217);
            TrangChuTitle.Name = "TrangChuTitle";
            TrangChuTitle.Size = new Size(896, 132);
            TrangChuTitle.TabIndex = 0;
            TrangChuTitle.Text = "KID LEARNING GAMES";
            TrangChuTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(TrangChuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrangChu";
            Text = "TrangChu";
            TrangChuPanel.ResumeLayout(false);
            TrangChuPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TrangChuPanel;
        private Label TrangChuTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BatDau;
        private Button DiemSo;
        private Button TuDien;
        private CheckBox CheckBoxSound;
    }
}
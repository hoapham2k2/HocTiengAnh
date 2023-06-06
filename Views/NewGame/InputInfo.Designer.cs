namespace HocTiengAnh.Views.NewGame
{
    partial class InputInfo
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
            InputInfoTitle = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // InputInfoTitle
            // 
            InputInfoTitle.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            InputInfoTitle.Location = new Point(1, 111);
            InputInfoTitle.Name = "InputInfoTitle";
            InputInfoTitle.Size = new Size(784, 99);
            InputInfoTitle.TabIndex = 1;
            InputInfoTitle.Text = "Input your name";
            InputInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(104, 268);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(578, 43);
            textBox1.TabIndex = 2;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // InputInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(textBox1);
            Controls.Add(InputInfoTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InputInfo";
            Text = "InputInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InputInfoTitle;
        private TextBox textBox1;
    }
}
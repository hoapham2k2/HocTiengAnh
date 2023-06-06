using System.Media;

namespace HocTiengAnh
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FormPanel_main = new Panel();
            SuspendLayout();
            // 
            // FormPanel_main
            // 
            FormPanel_main.Dock = DockStyle.Fill;
            FormPanel_main.Location = new Point(0, 0);
            FormPanel_main.Name = "FormPanel_main";
            FormPanel_main.Size = new Size(784, 561);
            FormPanel_main.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(FormPanel_main);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form1_Load;
            ResumeLayout(false);

            //soundplayer
            soundPlayer = new SoundPlayer(Properties.Resources.nhacgame01);
        }

        #endregion

        private Panel FormPanel_main;
        public static  SoundPlayer soundPlayer;
    }
}
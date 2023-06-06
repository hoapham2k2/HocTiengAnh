namespace HocTiengAnh.Views.Dictionary
{
    partial class AddDictionary
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
            labelInputDictionary = new Label();
            labelSelectCategory = new Label();
            TextBoxInputWord = new TextBox();
            ComboBoxCategory = new ComboBox();
            pictureBox1 = new PictureBox();
            ButtonUpload = new Button();
            ButtonSubmit = new Button();
            label1 = new Label();
            TextBoxImageURL = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelInputDictionary
            // 
            labelInputDictionary.AutoSize = true;
            labelInputDictionary.Location = new Point(14, 12);
            labelInputDictionary.Name = "labelInputDictionary";
            labelInputDictionary.Size = new Size(112, 20);
            labelInputDictionary.TabIndex = 0;
            labelInputDictionary.Text = "Input new word";
            // 
            // labelSelectCategory
            // 
            labelSelectCategory.AutoSize = true;
            labelSelectCategory.Location = new Point(14, 52);
            labelSelectCategory.Name = "labelSelectCategory";
            labelSelectCategory.Size = new Size(120, 20);
            labelSelectCategory.TabIndex = 1;
            labelSelectCategory.Text = "Choose category";
            // 
            // TextBoxInputWord
            // 
            TextBoxInputWord.Location = new Point(144, 8);
            TextBoxInputWord.Margin = new Padding(3, 4, 3, 4);
            TextBoxInputWord.Name = "TextBoxInputWord";
            TextBoxInputWord.Size = new Size(138, 27);
            TextBoxInputWord.TabIndex = 3;
            // 
            // ComboBoxCategory
            // 
            ComboBoxCategory.FormattingEnabled = true;
            ComboBoxCategory.Location = new Point(144, 52);
            ComboBoxCategory.Margin = new Padding(3, 4, 3, 4);
            ComboBoxCategory.Name = "ComboBoxCategory";
            ComboBoxCategory.Size = new Size(138, 28);
            ComboBoxCategory.TabIndex = 4;
            ComboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(326, 8);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ButtonUpload
            // 
            ButtonUpload.Location = new Point(326, 192);
            ButtonUpload.Margin = new Padding(3, 4, 3, 4);
            ButtonUpload.Name = "ButtonUpload";
            ButtonUpload.Size = new Size(192, 48);
            ButtonUpload.TabIndex = 6;
            ButtonUpload.Text = "Choose image";
            ButtonUpload.UseVisualStyleBackColor = true;
            ButtonUpload.Click += ButtonUpload_Click;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(17, 159);
            ButtonSubmit.Margin = new Padding(3, 4, 3, 4);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(265, 81);
            ButtonSubmit.TabIndex = 7;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += ButtonSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 89);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 8;
            label1.Text = "Image URL";
            // 
            // TextBoxImageURL
            // 
            TextBoxImageURL.Location = new Point(144, 87);
            TextBoxImageURL.Name = "TextBoxImageURL";
            TextBoxImageURL.Size = new Size(138, 27);
            TextBoxImageURL.TabIndex = 9;
            TextBoxImageURL.TextChanged += TextBoxImageURL_TextChanged;
            // 
            // AddDictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 256);
            Controls.Add(TextBoxImageURL);
            Controls.Add(label1);
            Controls.Add(ButtonSubmit);
            Controls.Add(ButtonUpload);
            Controls.Add(pictureBox1);
            Controls.Add(ComboBoxCategory);
            Controls.Add(TextBoxInputWord);
            Controls.Add(labelSelectCategory);
            Controls.Add(labelInputDictionary);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddDictionary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add new dictionary";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInputDictionary;
        private Label labelSelectCategory;
        private TextBox TextBoxInputWord;
        private ComboBox ComboBoxCategory;
        private PictureBox pictureBox1;
        private Button ButtonUpload;
        private Button ButtonSubmit;
        private Label label1;
        private TextBox TextBoxImageURL;
    }
}
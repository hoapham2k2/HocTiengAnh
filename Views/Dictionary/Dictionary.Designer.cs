namespace HocTiengAnh.Views.Dictionary
{
    partial class Dictionary
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
            DictionaryTitle = new Label();
            FLowLayoutCategory = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            GridDictionary = new DataGridView();
            ButtonAdd = new Button();
            TextBoxFind = new TextBox();
            CheckBoxSound = new CheckBox();
            FLowLayoutCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDictionary).BeginInit();
            SuspendLayout();
            // 
            // btnBackHome
            // 
            btnBackHome.Location = new Point(755, 664);
            btnBackHome.Margin = new Padding(3, 4, 3, 4);
            btnBackHome.Name = "btnBackHome";
            btnBackHome.Size = new Size(126, 61);
            btnBackHome.TabIndex = 3;
            btnBackHome.Text = "Back To Home";
            btnBackHome.UseVisualStyleBackColor = true;
            btnBackHome.Click += btnBackHome_Click;
            // 
            // DictionaryTitle
            // 
            DictionaryTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DictionaryTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            DictionaryTitle.Location = new Point(2, -3);
            DictionaryTitle.Name = "DictionaryTitle";
            DictionaryTitle.Size = new Size(893, 115);
            DictionaryTitle.TabIndex = 2;
            DictionaryTitle.Text = "Dictionary";
            DictionaryTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FLowLayoutCategory
            // 
            FLowLayoutCategory.AutoScroll = true;
            FLowLayoutCategory.Controls.Add(button1);
            FLowLayoutCategory.Controls.Add(button2);
            FLowLayoutCategory.FlowDirection = FlowDirection.TopDown;
            FLowLayoutCategory.Location = new Point(27, 176);
            FLowLayoutCategory.Margin = new Padding(3, 4, 3, 4);
            FLowLayoutCategory.Name = "FLowLayoutCategory";
            FLowLayoutCategory.Size = new Size(207, 476);
            FLowLayoutCategory.TabIndex = 4;
            FLowLayoutCategory.WrapContents = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 4);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(190, 65);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 77);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(190, 63);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // GridDictionary
            // 
            GridDictionary.AllowUserToAddRows = false;
            GridDictionary.AllowUserToDeleteRows = false;
            GridDictionary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDictionary.Location = new Point(267, 176);
            GridDictionary.Margin = new Padding(3, 4, 3, 4);
            GridDictionary.Name = "GridDictionary";
            GridDictionary.RowHeadersWidth = 51;
            GridDictionary.RowTemplate.Height = 25;
            GridDictionary.Size = new Size(602, 476);
            GridDictionary.TabIndex = 5;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(27, 116);
            ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(203, 52);
            ButtonAdd.TabIndex = 6;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // TextBoxFind
            // 
            TextBoxFind.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxFind.Location = new Point(267, 124);
            TextBoxFind.Margin = new Padding(3, 4, 3, 4);
            TextBoxFind.Name = "TextBoxFind";
            TextBoxFind.Size = new Size(602, 39);
            TextBoxFind.TabIndex = 7;
            TextBoxFind.TextChanged += TextBoxFind_TextChanged;
            // 
            // CheckBoxSound
            // 
            CheckBoxSound.AutoSize = true;
            CheckBoxSound.Location = new Point(30, 673);
            CheckBoxSound.Name = "CheckBoxSound";
            CheckBoxSound.Size = new Size(119, 24);
            CheckBoxSound.TabIndex = 11;
            CheckBoxSound.Text = "On/off sound";
            CheckBoxSound.UseVisualStyleBackColor = true;
            CheckBoxSound.CheckedChanged += CheckBoxSound_CheckedChanged;
            CheckBoxSound.CursorChanged += CheckBoxSound_CursorChanged;
            // 
            // Dictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(CheckBoxSound);
            Controls.Add(TextBoxFind);
            Controls.Add(ButtonAdd);
            Controls.Add(GridDictionary);
            Controls.Add(FLowLayoutCategory);
            Controls.Add(btnBackHome);
            Controls.Add(DictionaryTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dictionary";
            Text = "Dictionary";
            FLowLayoutCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridDictionary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBackHome;
        private Label DictionaryTitle;
        private FlowLayoutPanel FLowLayoutCategory;
        private DataGridView GridDictionary;
        private Button button1;
        private Button button2;
        private Button ButtonAdd;
        private TextBox TextBoxFind;
        private DataGridViewImageColumn Column1;
        private CheckBox CheckBoxSound;
    }
}
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

namespace HocTiengAnh.Views.Dictionary
{
    public partial class AddDictionary : Form
    {

        //delegate
        public delegate void AddDictionaryDelegate(Models.DictionaryModel dictionary);
        public AddDictionaryDelegate addDictionaryHandler { get; set; }

        //Các Service cần thiết
        Services.CategoryServices categoryServices = new Services.CategoryServices();
        Services.DictionariesServices dictionariesServices = new Services.DictionariesServices();

        //Các biến cục bộ cần thiết
        public static List<Models.CategoryModel> currentListCategory { get; set; } = new List<Models.CategoryModel>();
        public static Models.DictionaryModel currentDictionary { get; set; } = new Models.DictionaryModel();
        public static string filePath { get; set; } = "";
        public static byte[] imageBytes { get; set; } = null;
        public AddDictionary(AddDictionaryDelegate addDictionaryHandler)
        {
            InitializeComponent();
            currentListCategory = categoryServices.GetCategories();
            InitComboBox();
            this.addDictionaryHandler = addDictionaryHandler;
        }

        private void InitComboBox()
        {
            // Tạm thời tắt sự kiện SelectedIndexChanged
            this.ComboBoxCategory.SelectedIndexChanged -= ComboBoxCategory_SelectedIndexChanged;

            this.ComboBoxCategory.DataSource = currentListCategory;
            this.ComboBoxCategory.DisplayMember = "CategoryName";
            this.ComboBoxCategory.ValueMember = "CategoryID";

            this.ComboBoxCategory.SelectedIndex = 0;

            //bật lại sự kiện SelectedIndexChanged
            this.ComboBoxCategory.SelectedIndexChanged += ComboBoxCategory_SelectedIndexChanged;
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            //Khởi tạo 1 OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Đặt các thuộc tính cho OpenFileDialog
            openFileDialog.Title = "Chọn file";
            //Đặt các định dạng cho OpenFileDialog là các file hình ảnh
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của file
                filePath = openFileDialog.FileName;
                //Hiển thị ảnh lên pictureBox
                this.pictureBox1.Image = Image.FromFile(filePath);
            }

        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {

            //kiểm tra xem đã chọn ảnh chưa
            if (string.IsNullOrEmpty(filePath) && pictureBox1.Image == null)
            {
                MessageBox.Show("Please choose image");
                return;
            }
            //kiểm tra xem đã nhập từ chưa
            if (this.TextBoxInputWord.Text == "")
            {
                MessageBox.Show("Please input word");
                return;
            }
            //kiểm tra xem đã chọn category chưa
            if (this.ComboBoxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose category");
                return;
            }
            //chuyển đổi ảnh về dạng byte[]
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                currentDictionary.DictionaryImageURL = ms.ToArray();
            }

            //lấy categoryID từ ComboBox
            //string value = this.ComboBoxCategory.SelectedValue.ToString();
            //currentDictionary.CategoryID = Int32.Parse(value);
            //lấy từ từ TextBox
            currentDictionary.DictionaryWord = this.TextBoxInputWord.Text;

            //thêm dictionary vào cơ sở dữ liệu
            bool addStatus = dictionariesServices.AddDictionary(currentDictionary);
            if (addStatus)
            {
                //cập nhật dictionary vừa tạo vào form Dictionary
                this.addDictionaryHandler.Invoke(currentDictionary);
                //thông báo thêm thành công
                MessageBox.Show("Add successful");
                //clear data
                this.TextBoxInputWord.Controls.Clear();
                this.TextBoxInputWord.Text = "";
                this.pictureBox1.Image = null;
                this.ComboBoxCategory.SelectedIndex = 0;
                this.TextBoxImageURL.Text = "";
            }
            else
            {
                //thông báo thêm thất bại
            }
            //thoát khỏi form



        }

        private void TextBoxImageURL_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = this.TextBoxImageURL.Text;
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ComboBoxCategory.SelectedIndex == -1)
            {
                return;
            }
            string value = this.ComboBoxCategory.SelectedValue.ToString();
            currentDictionary.CategoryID = Int32.Parse(value);
        }
    }
}

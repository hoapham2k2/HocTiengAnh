using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace HocTiengAnh.Views.Dictionary
{
    public partial class Dictionary : Form
    {
        //Delegate để mở form Trang chủ
        public delegate void OpenTrangChu();
        public event OpenTrangChu openTrangChuHandler;

        //Các Service cần thiết
        Services.CategoryServices categoryService = new Services.CategoryServices();
        Services.DictionariesServices dictionariesServices = new Services.DictionariesServices();

        //Các biến cần thiết
        Models.DictionaryModel currentDictionary { get; set; } = new Models.DictionaryModel();
        List<Models.DictionaryModel> currentListDictionary { get; set; } = new List<Models.DictionaryModel>();
        BindingList<Models.DictionaryModel> currentBindingList { get; set; } = new BindingList<Models.DictionaryModel>();


        public Dictionary(OpenTrangChu openTrangChu)
        {
            this.openTrangChuHandler = openTrangChu;
            this.currentListDictionary = dictionariesServices.GetDictionaries();
            InitializeComponent();
            InitCategoryList();
            InitGridView();
            initSound();

        }

        //Khởi tạo datagridview
        private void InitGridView()
        {
            foreach (var item in this.currentListDictionary)
            {
                this.currentBindingList.Add(item);
            }
            this.GridDictionary.DataSource = this.currentBindingList;
            FixUIGrid();
        }

        //Sửa UI cho datagridview
        private void FixUIGrid()
        {

            //sửa UI cho datagridview
            //ẩn cột DictionaryId
            GridDictionary.Columns["DictionaryID"].Visible = false;
            //hiện cột DictionaryWord
            GridDictionary.Columns["DictionaryWord"].Visible = true;
            //ẩn cột DictionaryImageURL
            GridDictionary.Columns["DictionaryImageURL"].Visible = false;
            //ẩn cột CategoryId
            GridDictionary.Columns["CategoryID"].Visible = false;
            //ẩn cột Category
            GridDictionary.Columns["Category"].Visible = false;
            //ẩn cột rowheader
            GridDictionary.RowHeadersVisible = false;

            //đưa độ dài cột đều với độ dài của datagridview
            GridDictionary.Columns["DictionaryWord"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            // ẩn dòng allow user to add row
            GridDictionary.AllowUserToAddRows = false;
            //đồ cao row bằng 100
            GridDictionary.RowTemplate.Height = 150;




            //thêm 1 cột 'image' để chứa hình ảnh
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image.DataPropertyName = "DictionaryImageURL";
            image.Name = "image";
            image.HeaderText = "Image";
            image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            GridDictionary.Columns.Add(image);

            //thêm sự kiện sửa ô của cột [1] để lưu lại dữ liệu
            //GridDictionary.CellValueChanged += UpdateDictionary;
            //Khởi tạo 1 cột 'optional' để chứa các button tùy chọn
            DataGridViewButtonColumn optional = new DataGridViewButtonColumn();
            optional.Name = "optional";
            optional.HeaderText = "Optional";
            optional.Text = "Xóa";
            optional.UseColumnTextForButtonValue = true;
            GridDictionary.Columns.Add(optional);

            //thêm sự kiện click vào button 'optional'
            //GridDictionary.CellClick += DeleteDictionary;

            //sửa UI cho cột 'optional' và 'image'
            GridDictionary.Columns["optional"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GridDictionary.Columns["image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Chỉ cho phép sửa ở cột DictionaryWord
            GridDictionary.Columns["DictionaryWord"].ReadOnly = false;
            GridDictionary.Columns["image"].ReadOnly = true;
            GridDictionary.Columns["optional"].ReadOnly = true;

            //thêm sự kiện sửa vào cột DictionaryWord
            GridDictionary.CellEndEdit += UpdateDictionary;
            //thêm sự kiện click vào button 'optional'
            GridDictionary.CellClick += DeleteDictionary;

        }
        //Sự kiện click vào button 'Back Home'
        private void btnBackHome_Click(object sender, EventArgs e)
        {
            openTrangChuHandler.Invoke();
            this.Close();
        }
        //Load thông tin từ các category hiện có trong database
        private void InitCategoryList()
        {
            //clear mọi thứ thiết kế sẵn trong flowlayout
            FLowLayoutCategory.Controls.Clear();
            //Lấy danh sách category từ database
            List<Models.CategoryModel> categories = new List<Models.CategoryModel>();
            categories = categoryService.GetCategories();
            //Tạo các button tương ứng với các category và thêm vào flowlayout
            foreach (var item in categories)
            {
                Button button = new Button();
                button.Tag = item.CategoryID;
                button.Text = item.CategoryName;

                //thiết kế UI của button
                button.Size = new Size(167, 49);
                button.Font = new Font("Sugoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                button.Click += InitDictionary;
                FLowLayoutCategory.Controls.Add(button);
            }
        }
        //Load thông tin Dictionary từ Category được chọn trong flowlayout
        private void InitDictionary(object? sender, EventArgs e)
        {
            int categoryID = (int)((Button)sender).Tag;
            currentListDictionary = dictionariesServices.GetDictionariesByCategoryId(categoryID);
            currentBindingList = new BindingList<Models.DictionaryModel>(currentListDictionary);
            GridDictionary.DataSource = currentBindingList;
        }
        //Sự kiện click vào button 'optional'
        private void DeleteDictionary(object? sender, DataGridViewCellEventArgs e)
        {

            //lấy index của cột DictionaryId
            int columnId = GridDictionary.Columns["optional"].Index;
            //Kiểm tra xem ô này thuộc ô DictionaryWord hay không
            if (e.ColumnIndex == columnId && e.RowIndex >= 0)
            {

                //lấy dữ liệu từ ô cột [0] của dòng vừa sửa
                int dictionaryID = Int32.Parse(GridDictionary.Rows[e.RowIndex].Cells["DictionaryID"].Value.ToString());
                //tìm Dictionary tương ứng với dictionaryID
                currentDictionary = dictionariesServices.GetDictionaryById(dictionaryID);

                if (currentDictionary == null)
                {
                    MessageBox.Show("Không tìm thấy từ vựng");
                }
                else
                {
                    //xóa Dictionary khỏi database
                    dictionariesServices.DeleteDictionary(currentDictionary);
                    //xóa Dictionary khỏi danh sách hiện tại
                    currentListDictionary.Remove(currentDictionary);
                    currentBindingList = new BindingList<Models.DictionaryModel>(currentListDictionary);
                    GridDictionary.DataSource = currentBindingList;

                }

            }
        }
        //Sự kiện sửa ô của cột [1] để lưu lại dữ liệu
        private void UpdateDictionary(object? sender, DataGridViewCellEventArgs e)
        {
            //lấy index của cột DictionaryWord
            int columnIndex = GridDictionary.Columns["DictionaryWord"].Index;
            //lấy index của cột DictionaryId
            int columnId = GridDictionary.Columns["DictionaryID"].Index;
            //Kiểm tra xem ô này thuộc ô DictionaryWord hay không
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                //lấy dữ liệu từ ô vừa sửa
                string? newWord = GridDictionary.Rows[e.RowIndex].Cells[columnIndex].Value?.ToString();
                //lấy dữ liệu từ ô cột [0] của dòng vừa sửa
                int dictionaryID = (int)GridDictionary.Rows[e.RowIndex].Cells[columnId].Value;
                //tìm Dictionary tương ứng với dictionaryID
                currentDictionary = dictionariesServices.GetDictionaryById(dictionaryID);
                currentDictionary.DictionaryWord = newWord;

                //update lại dữ liệu trong database
                dictionariesServices.UpdateDictionary(currentDictionary);

            }

        }
        //sự kiện lọc các dictionary theo từ khóa
        private void TextBoxFind_TextChanged(object sender, EventArgs e)
        {
            // lấy từ khóa từ textbox
            string keyword = TextBoxFind.Text;
            //lấy danh sách dictionary từ database
            List<Models.DictionaryModel> dictionaries = dictionariesServices.SearchDictionariesByName(keyword);

            if (dictionaries != null)
            {
                //tạo binding list từ danh sách dictionary
                BindingList<Models.DictionaryModel> bindingList = new BindingList<Models.DictionaryModel>(dictionaries);
                GridDictionary.DataSource = bindingList;
            }
        }

        public void GridAddDictionary(Models.DictionaryModel dictionary)
        {
            currentListDictionary.Add(dictionary);
            currentBindingList = new BindingList<Models.DictionaryModel>(currentListDictionary);
            GridDictionary.DataSource = currentBindingList;
        }
        //sự kiện add dictionary mới
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddDictionary addDictionary = new AddDictionary(GridAddDictionary);
            addDictionary.ShowDialog();

        }

        private void CheckBoxSound_CursorChanged(object sender, EventArgs e)
        {

        }

        private void CheckBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxSound.Checked)
            {
                Main.soundPlayer.PlayLooping();
                Main.CheckSoundBool = true;
            }
            else
            {
                Main.soundPlayer.Stop();
                Main.CheckSoundBool = false;
            }
        }
        public void initSound()
        {
            if (Main.CheckSoundBool)
            {
                CheckBoxSound.Checked = true;
            }
            else
            {
                CheckBoxSound.Checked = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocTiengAnh.Models;
using HocTiengAnh.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace HocTiengAnh.Services
{
    public class DictionariesServices
    {
        private DataContext _context { get; set; }

        public DictionariesServices()
        {
            _context = new DataContext();
        }

        public List<DictionaryModel> GetDictionaries()
        {
            return _context.Dictionaries.ToList();
        }

        public DictionaryModel? GetDictionaryById(int id)
        {
            // return _context.Dictionaries.FirstOrDefault(x => x.DictionaryID == id);
            Models.DictionaryModel? dictionary = _context.Dictionaries.FirstOrDefault(x => x.DictionaryID == id);
            if (dictionary == null)
            {
                MessageBox.Show("Can't find dictionary with id = " + id + "!");
                return null;
            }
            return dictionary;
        }

        public List<DictionaryModel>? GetDictionariesByCategoryId(int id)
        {
            List<Models.DictionaryModel> list = _context.Dictionaries.Where(x => x.CategoryID == id).ToList();
            if (list == null)
            {
                MessageBox.Show("Can't find dictionary with category id = " + id + "!");
                return null;
            }
            return list;
        }

        public bool AddDictionary(DictionaryModel dictionary)
        {
            if (dictionary == null)
            {
                MessageBox.Show("Can't add null dictionary!");
                return false;
            }
            //nếu từ điển đã tồn tại thì không thêm
            else if (_context.Dictionaries.FirstOrDefault(x => x.DictionaryWord.Equals(dictionary.DictionaryWord)) != null)
            {
                MessageBox.Show("Dictionary with word = " + dictionary.DictionaryWord + " already exists!");
                return false;
            }
            
            else
            {
                try
                {
                    var sqlCommand = "INSERT INTO Dictionaries (DictionaryWord, DictionaryImageURL, CategoryID) VALUES ('" + dictionary.DictionaryWord + "', CONVERT(varbinary(max), @Image), " + dictionary.CategoryID + ")";
                    _context.Database.ExecuteSqlRaw(sqlCommand, new SqlParameter("@Image", dictionary.DictionaryImageURL));
                    //lưu thay đổi vào cơ sở dữ liệu
                    _context.SaveChanges();
                    return true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Some thing wrong: " +  ex.Message);
                    return false;
                }
                return true;
            }
        }

        public void UpdateDictionary(DictionaryModel dictionary)
        {
            _context.Dictionaries.Update(dictionary);
            _context.SaveChanges();
        }

        public void DeleteDictionary(DictionaryModel dictionary)
        {
            _context.Dictionaries.Remove(dictionary);
            _context.SaveChanges();
        }

        public void DeleteDictionaryById(int id)
        {
            Models.DictionaryModel? dictionary = _context.Dictionaries.FirstOrDefault(x => x.DictionaryID == id);
            if(dictionary == null)
            {
                MessageBox.Show("Can't find dictionary with id = " + id + "!");
                return;
            }
            _context.Dictionaries.Remove(dictionary);
            _context.SaveChanges();
        }

        public void DeleteDictionariesByCategoryId(int id)
        {
            var dictionaries = _context.Dictionaries.Where(x => x.CategoryID == id).ToList();
            _context.Dictionaries.RemoveRange(dictionaries);
            _context.SaveChanges();
        }


        //phương thực dùng để tìm kiến từ điển theo tên từ
        public List<DictionaryModel>? SearchDictionariesByName(string name)
        {
            return _context.Dictionaries.Where(x => x.DictionaryWord.Contains(name)).ToList();
        }


        public List<DictionaryModel>? GetTop5RandomFromCategory(int categoryID)
        {
           string sqlCommand = "select top 5 * from Dictionaries where Dictionaries.CategoryID = " + categoryID + " order by NEWID()";  
        return _context.Dictionaries.FromSqlRaw(sqlCommand).ToList(); 
        }

    }
}
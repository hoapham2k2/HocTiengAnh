using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HocTiengAnh.Models
{
    public class DictionaryModel
    {
        public int DictionaryID { get; set; }
        public string? DictionaryWord { get; set; }
        public byte[]? DictionaryImageURL { get; set; }
        public int CategoryID { get; set; }
        public Models.CategoryModel Category { get; set; }

        public DictionaryModel()
        {
        }

        public DictionaryModel( string dictionaryWord, int categoryId, byte[] dictinaryImageURL)
        {
            this.DictionaryWord = dictionaryWord;
            this.CategoryID = categoryId;
            this.DictionaryImageURL = dictinaryImageURL;

        }
    }
}
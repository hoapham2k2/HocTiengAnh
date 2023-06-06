using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Models.DTOs
{
    public class QuizEasy
    {
        public int DictionaryID { get; set; }
        public string DictionaryWord { get; set; }
        public byte[] DictionaryImageURL { get; set; }
        public string Answer { get; set; }
    }
}

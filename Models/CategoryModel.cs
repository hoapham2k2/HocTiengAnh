﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Models
{
    public class CategoryModel
    {
        public int CategoryID { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryImagePath { get; set; }    

        public CategoryModel() { }

       
    }
}

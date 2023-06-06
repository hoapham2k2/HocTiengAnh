using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Models.DTOs
{
    public class AchievementsGridModel
    {
        public int STT { get; set; }
        public string? UserName { get; set; }
        public string? CategoryName { get; set; }
        public int? GameScore { get; set; }
        public string GameTime { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Models
{
    public class GameDetailModel
    {
        public int GameID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int? GameScore { get; set; } = 0;
        public UserModel? User { get; set; }
        public GameModel? Game { get; set; }
        public CategoryModel? Category { get; set; }

        public GameDetailModel()
        {
            this.GameScore = 0;
        }

        ~GameDetailModel()
        {
            this.GameScore = 0;
        }

    }
}

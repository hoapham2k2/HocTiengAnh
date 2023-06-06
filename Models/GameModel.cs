using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Models
{

    public enum GameLevel
    {
        Easy,
        Medium,
        Hard
    }
    public class GameModel
    {
        public int GameID { get; set; }
        public GameLevel Level { get; set; } = GameLevel.Easy;

        public bool IsNew { get; set; } = true;
        public string? LastTime { get; set; } = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


        public GameModel()
        {
        }
        


    }
}

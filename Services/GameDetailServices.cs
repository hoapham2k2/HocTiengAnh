using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HocTiengAnh.Data;
using HocTiengAnh.Models;

namespace HocTiengAnh.Services
{
    public class GameDetailServices
    {
        private DataContext DataContext { get; set; }
        public GameDetailServices()
        {
            DataContext = new DataContext();
        }
        public List<GameDetailModel> GetGameDetails()
        {
            return DataContext.GameDetails.ToList();
        }
        public void AddGameDetail(GameDetailModel gameDetail)
        {
            DataContext.GameDetails.Add(gameDetail);
            DataContext.SaveChanges();
        }
        public void DeleteGameDetail(int id)
        {
            var gameDetail = DataContext.GameDetails.Find(id);
            DataContext.GameDetails.Remove(gameDetail);
            DataContext.SaveChanges();
        }
        public void UpdateGameDetail(GameDetailModel gameDetail)
        {
            var gameDetailUpdate = DataContext.GameDetails.Find(gameDetail.GameID);
            gameDetailUpdate.GameScore = gameDetail.GameScore;
            DataContext.SaveChanges();
        }   
    }
}

using HocTiengAnh.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocTiengAnh.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<GameDetailModel> GameDetails { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<DictionaryModel> Dictionaries { get; set; } 
        public DbSet<Models.DTOs.QuizEasy> QuizEasies { get; set; } 
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameDetailModel>()
                .HasKey(c => new { c.GameID, c.UserID });
            modelBuilder.Entity<CategoryModel>()
                .HasKey(c=> new { c.CategoryID });
            modelBuilder.Entity<GameModel>()
                .HasKey(c => new { c.GameID });
            modelBuilder.Entity<UserModel>()
                .HasKey(c => new { c.UserID });
            modelBuilder.Entity<DictionaryModel>()
                .HasKey(c => new { c.DictionaryID });
            modelBuilder.Entity<Models.DTOs.QuizEasy>()
                .HasNoKey();


        }
    }
}

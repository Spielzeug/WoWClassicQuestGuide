using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using WoWClassicQuestGuide.IModel;
using Xamarin.Forms;

namespace WoWClassicQuestGuide.Context
{
    public class GuideDatabaseContext : DbContext
    {
        public DbSet<IChapterModel> Chapters { get; set; }
        public DbSet<IChapterMapModel> ChapterMaps { get; set; }
        public DbSet<IStepModel> Steps { get; set; }

        private const string databaseName = "databaase.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string databasePath = "";
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    SQLitePCL.Batteries_V2.Init();
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "..", "Library", databaseName); ;
                    break;
                case Device.Android:
                    databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), databaseName);
                    break;
                default:
                    throw new NotImplementedException("Platform not supported");
            }
            // Specify that we will use sqlite and the path of the database here
            optionsBuilder.UseSqlite($"Filename={databasePath}");
        }
    }
}

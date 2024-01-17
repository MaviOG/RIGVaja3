using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace RIGProjeck.Class
{
	public class NepremicninaDB:DbContext
	{
		string path = "C:\\Users\\aljaz\\Desktop\\RGIS\\RIGVaja3\\RIGProjeck\\RIGProjeck\\NepremicninaDB.db";

        public DbSet<User> Users { get; set; }
		public DbSet<Nepremičnina> Nepremicninas { get; set; }
		public string DbPath { get;}
		public  NepremicninaDB()
		{
			SQLitePCL.Batteries.Init();
			string startupPath =System.IO.Directory.GetCurrentDirectory();

			DbPath = System.IO.Path.Join(startupPath, "NepremicninaDB.db");
		}
		protected override void OnConfiguring(DbContextOptionsBuilder options)
		=> options.UseSqlite($"Data Source={path}");	
	}
}

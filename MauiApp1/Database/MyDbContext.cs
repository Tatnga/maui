using MauiApp1.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Database
{
    public class MyDbContext : SQLiteConnection
    {
        public MyDbContext(string databasePath) : base(databasePath)
        {
            CreateTable<Person>();
           // CreateTable<Inventory>();
        }
        public TableQuery<Person> MyData => Table<Person>();
      //  public TableQuery<Inventory> MyData1 => Table<Inventory>();
    }
}

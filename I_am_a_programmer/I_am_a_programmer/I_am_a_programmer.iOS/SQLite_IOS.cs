using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using System.IO;
using SQLite;
using I_am_a_programmer.iOS;
using Xamarin.Forms;
using I_am_a_programmer.Views;

[assembly: Dependency(typeof(SQLite_IOS))]
namespace I_am_a_programmer.iOS
{
    class SQLite_IOS : ISQLite
    {
        public SQLite_IOS() { }
        public string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // папка библиотеки
            var path = Path.Combine(libraryPath, sqliteFilename);

            return path;
        }
    }
}
using System.IO;
using App1.Droid;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(IDroidSQLite))] //diretiva de compilação

namespace App1.Droid
{
    public class IDroidSQLite : ISQLite
    {
        public SQLiteAsyncConnection AcessarDB()
        {
            var pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var banco = Path.Combine(pasta, "App1.db3");

            return new SQLiteAsyncConnection(banco);
        }
    }
}
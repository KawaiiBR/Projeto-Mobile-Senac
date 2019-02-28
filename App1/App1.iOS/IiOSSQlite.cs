using System.IO;
using App1.iOS;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(IiOSSQlite))] //diretiva de compilação

namespace App1.iOS
{
    public class IiOSSQlite : ISQLite
    {
        public SQLiteAsyncConnection AcessarDB()
        {
            var pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var banco = Path.Combine(pasta, "..", "Library", "App1.db3");

            return new SQLiteAsyncConnection(banco);
        }
    }
}
using SQLite;

namespace App1
{
    public interface ISQLite
    {
        SQLiteAsyncConnection AcessarDB();
    }
}

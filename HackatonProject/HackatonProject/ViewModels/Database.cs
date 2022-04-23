using HackatonProject.Models;
using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

public class Database
{
    private readonly SQLiteAsyncConnection _database;

    public Database(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<User>().Wait();
    }

    public Task<List<User>> GetUsersAsync()
    {
        return _database.Table<User>().ToListAsync();
    }

    public AsyncTableQuery<User> FindUser(User person)
    {
        return _database.Table<User>().Where(user => user.Email == person.Email);
    }

    public Task<int> SaveUserAsync(User person)
    {
        return _database.InsertAsync(person);
    }
}

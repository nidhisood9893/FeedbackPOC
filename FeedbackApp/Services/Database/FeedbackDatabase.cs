using System;
using System.Threading.Tasks;
using SQLite;
using System.Collections.Generic;

namespace FeedbackApp
{
    public class FeedbackDatabase
    {
        readonly SQLiteAsyncConnection database;

        public FeedbackDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Feedback>().Wait();
        }

        public Task<int> AddFeedback(Feedback feedback)
        {
            return database?.InsertAsync(feedback);
        }

        public Task<List<Feedback>> GetFeedbacks()
        {
            return database?.Table<Feedback>().ToListAsync();
        }
    }
}

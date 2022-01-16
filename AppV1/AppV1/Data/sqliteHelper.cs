using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using AppV1.Models;
using System.Threading.Tasks;

namespace AppV1.Data
{
   public class sqliteHelper
    {
        SQLiteAsyncConnection db;
        public sqliteHelper(string Path)
        {
            db = new SQLiteAsyncConnection(Path);
            db.CreateTableAsync<User>().Wait();
          



        }
        public Task<int>  SaveUser(User user)
        {
            if(user.id==0)
            { return db.InsertAsync(user);
            }
            else
            {
                return null;
            }


        }
        public Task<User> GetUser(string mail)
        {
            return db.Table<User>().Where(i => i.email == mail).FirstOrDefaultAsync();

        }
        public async Task<int> UpdateUserAsync(string username, string pwd)
        {

            var user = await GetUser(username).ConfigureAwait(false);
            user.Password = pwd;
            return await db.UpdateAsync(user);




        }
    }
}

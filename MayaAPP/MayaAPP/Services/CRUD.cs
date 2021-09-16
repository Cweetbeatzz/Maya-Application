using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace MayaAPP.Services
{
    public static class CRUD
    {
        static SQLiteConnection db;

        public static async Task DB_location()
        {
            
            if (db != null)
            {
                return;
            }
            //..............GETTING DATABASE PATH ON PC
            string database_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyData.db");
            db = new SQLiteAsyncConnection(database_path);
            await db.CreateTableAsync<customers>();
        }

        public static async Task Create_users()
        {
            await DB_location();
            var customers = new customers
            {

                Firstname = firstname,
                Lastname = lastname,
                Email = email,
                Address = address,
                Phoneno = phoneno,
                Password = password,

            };

             var id = await db.InsertAsync(customers);
        }

        public static async Task<IEnumerable<customers>> Update_users()
        {
            await DB_location();
            var customers = await db.Table<customers>.ToList();
            return customers;
        }

        public static async Task Delete_users()
        {
            await DB_location();
             await db.DeleteAsync<customers>(id);
            
        }
    }
}

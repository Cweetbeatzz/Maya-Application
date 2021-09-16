using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MayaAPP.Database
{
   public interface IDatabase
    {
        MySqlConnection GetConnection();
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MayaAPP.Models
{
    public class UsersModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int Phoneno { get; set; }

    }
}

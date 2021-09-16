using MayaAPP.Models;
using MayaAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MayaAPP.Services
{
    public class APIservices
    {
        public APIservices()
        {

        }
        public async Task APIservices RegisterAsync(string surname, string lastname, string email, string address, string password, int phoneno)
        {
            var client = new HttpClient();

            var Register_model = new UsersModel
            {
                Surname = surname,
                Lastname = lastname,
                Email = email,
                Address = address,
                Password = password,
                Phoneno = phoneno
            };


            //var json JsonConvert.SerializeObject(Register_model);

            
        }
    }
}

using MayaAPP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MayaAPP.ViewModels 
{
    public class RegisterViewModels : INotifyPropertyChanged
    {
        APIservices aPIservices = new APIservices();
        public int id { get; set; }
        public string surname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string password { get; set; }
        public int phoneno { get; set; }




        public ICommand Register_command
        {
            
            get { return new Command(() => {

                aPIservices = RegisterAsync(surname, lastname, email, address, password, phoneno);
            
            
            }); }

        }

        

        //.............................................................................
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        //................................................................................

        private bool _isbusy;                                                              //IS BUSY CALL........
                                                                                           //IS BUSY CALL........
        public bool Isbusy                                                                 //IS BUSY CALL........
        {                                                                                  //IS BUSY CALL........
            get { return _isbusy; }                                                        //IS BUSY CALL........
            set { _isbusy = value; OnPropertyChanged(); }                                  //IS BUSY CALL........
        }                                                                                  //IS BUSY CALL........
        //...................................................................................
    }
}

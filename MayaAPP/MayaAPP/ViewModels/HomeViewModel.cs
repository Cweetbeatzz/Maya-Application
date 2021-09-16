using MayaAPP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MayaAPP.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        //........................................................................................
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string property_name )
        {
            if(property_name == null)
            {
                return;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventHandler(property_name));
        }
        //......................................................................................


        ObservableCollection<foodtypes> food_type;
        public ObservableCollection<foodtypes> f_type
        {
            get { return food_type; }
            set {
                food_type = value;
                OnPropertyChanged("f_type");
            }
           
        }
        //...................................................................................CONSTRUCTOR
        public HomeViewModel()
        {
            f_type = new ObservableCollection<foodtypes>();
            foodtypes();
        }
        //.......................................................................................ADD FOOD TYPES

       
        private void foodtypes()
        {

            f_type.Add(new foodtypes
            {

                id = 0,
                type_of_meals = "AFRICAN MEALS"

            }) ;

            f_type.Add(new foodtypes
            {

                id = 1,
                type_of_meals = "CHINESE MEALS"

            });

            f_type.Add(new foodtypes
            {

                id = 1,
                type_of_meals = "ITALIAN MEALS"

            });

            f_type.Add(new foodtypes
            {

                id = 3,
                type_of_meals = "AMERICAN MEALS"

            });

        }
    }

    
}

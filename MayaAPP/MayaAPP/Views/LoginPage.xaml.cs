using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MayaAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        //LOGIN BUTTON
        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Entry_email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Entry_password_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
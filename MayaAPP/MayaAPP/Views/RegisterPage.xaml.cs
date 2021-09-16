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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();


        }
        //REGISTER BUTTON
       

        //............................................................//
       
        private async void TapGestureRecognizer_Tapped_twitter(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());//CHANGE THE REGISTER PAGE TO TWITTER PAGE
        }
        //...................................................................................
        private async void TapGestureRecognizer_Tapped_google(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());//CHANGE THE REGISTER TO GOOGLE PAGE
        }
        //.........................................................................................
        private async void TapGestureRecognizer_Tapped_facebook(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());//CHANGE THE REGISTER TO GOOGLE PAGE
        }
    }
}
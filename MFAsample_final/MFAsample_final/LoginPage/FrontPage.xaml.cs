using MFAsample_final.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFAsample_final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrontPage : ContentPage
    {
        public FrontPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MFAsample_final
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            CurrentPage = Children[2];
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Test1", "test2", "test3");
        }

        private void shareCarKey(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CarSharingPage());
        }
    }
}

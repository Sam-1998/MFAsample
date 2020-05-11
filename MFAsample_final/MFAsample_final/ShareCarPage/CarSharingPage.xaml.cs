using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MFAsample_final.ShareCarPage;

namespace MFAsample_final
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarSharingPage : ContentPage
    {
        public CarSharingPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.MyListPageViewModel();
            MessagingCenter.Subscribe<ContentPage>(this, "RefreshMainPage", (sender) => {
                BindingContext = new ViewModel.MyListPageViewModel();
            });
        }

        private void ToolbarAddItemButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddKeyPage());
        }
    }
}
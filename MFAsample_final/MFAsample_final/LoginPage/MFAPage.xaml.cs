using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SQLite;
using MFAsample_final.Tables;
using System.IO;

// This is made for FaceID
/*
using LocalAuthentication;
using Foundation;
using Xamarin.Essentials;
using UIKit;
*/

namespace MFAsample_final.LoginPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MFAPage : ContentPage
    {
        public MFAPage()
        {
            InitializeComponent();

            try
            {
                // Adding picker account information from the save account database.
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                var myQuery = db.Table<SavedUserTable>();
                int i = 0;
                foreach (SavedUserTable user in myQuery)
                {
                    accountPicker.Items.Add(user.Email);

                    if(i == 0)
                    {
                        accountPicker.SelectedItem = user.Email; // Adding first value to the picker
                    }
                    i++;
                }
            }
            catch (SQLiteException errormsg)
            { 
                // Do nothing, shouldn't be here in the first place, should be in frontPage.
            }
            }

        private async void TouchIDButtonClickedAsync(object sender, EventArgs e)
        {
            var result = await CrossFingerprint.Current.IsAvailableAsync(true);
            if(result == true)
            {
                var request = new AuthenticationRequestConfiguration("Login", "");
                var auth = await CrossFingerprint.Current.AuthenticateAsync(request);
                if (auth.Authenticated)
                {
                    await Navigation.PushAsync(new MainPage());
                }
            }
            else
            {
                await DisplayAlert("Unavailable", "This feature is unavailable on your device", "Continue");
            }
        }

        private void FaceIDButtonClicked(object sender, EventArgs e)
        {
            // Face ID is under construction, did not come with the plugin that i added.
            DisplayAlert("Under development", "This feature is primarly intended for IOS devices and is therefore still under development.", "Continue");
            /*
            NSError error;
            var context = new LAContext();
            if (context.CanEvaluatePolicy(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, out error))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    try
                    {
                        var result = await context.EvaluatePolicyAsync(LAPolicy.DeviceOwnerAuthenticationWithBiometrics, "Login");

                        if (result.Item1)
                        {
                            hasLoggedin = true;
                            PerformSegue("loginSegue", this);
                        }
                        else
                        {
                            TraditionalLogin();
                        }
                    }
                    catch (Exception ex)
                    {
                        var alert = UIAlertController.Create("Failure", ex.Message, UIAlertControllerStyle.Alert);
                        alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
                        PresentViewController(alert, true, null);
                    }
                });
            }
            else {
                // insert code
            }*/
        }

        private void ManualLoginButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FrontPage());
        }
    }
}
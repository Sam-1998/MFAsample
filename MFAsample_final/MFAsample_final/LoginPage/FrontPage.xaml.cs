using MFAsample_final.LoginPage;
using MFAsample_final.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            try {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.Email.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
            if (myquery != null)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    Boolean saveUser = await this.DisplayAlert("Save password", "Would you like to save your password?", "Yes", "No");
                    if (saveUser == true)
                    {
                        var dbpath2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                        var db2 = new SQLiteConnection(dbpath2);
                        db2.CreateTable<SavedUserTable>();

                        var item2 = new SavedUserTable()
                        {
                            Email = EntryUser.Text,
                            Password = EntryPassword.Text
                        };
                        db2.Insert(item2);
                    }
                });
                Navigation.PushAsync(new MainPage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Failed Username and Password", "Continue");
                });
            }
        }
            catch(SQLiteException errormsg)
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await this.DisplayAlert("Error", "Failed Username and Password", "Continue");
                });
            }

        }
    }
}
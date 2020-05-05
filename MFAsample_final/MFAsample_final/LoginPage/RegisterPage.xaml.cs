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

namespace MFAsample_final.LoginPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (EntryPassword.Text.Equals(EntryConfirmPassword.Text)) {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                db.CreateTable<RegUserTable>();

                var item = new RegUserTable()
                {
                    Email = EntryEmail.Text,
                    Password = EntryPassword.Text
                };
                db.Insert(item);
                this.DisplayAlert("Congratulations", "Your registration was sucessfull!","Continue");
                Navigation.PopAsync();
            }
            else
            {
                this.DisplayAlert("Registration unsucessfull", "The two passwords provided didn't match", "Continue");
            }
        }
    }
}
/* Video: www.youtube.com/watch?v=8JQSd9sF3XI */
using MFAsample_final.LoginPage;
using MFAsample_final.ShareCarPage;
using MFAsample_final.Tables;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFAsample_final
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            //var myquery = db.Table<SavedUserTable>().Where(u => u.Email.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
            try {
            if(db.Table<SavedUserTable>().Count() <= 0) { 
                MainPage = new NavigationPage(new FrontPage());
            }
            else {
                MainPage = new NavigationPage(new MFAPage());
            }
            }
            catch (SQLiteException e)
            {
                MainPage = new NavigationPage(new FrontPage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

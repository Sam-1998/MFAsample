using System;
using System.Collections.Generic;
using System.Text;
using MFAsample_final.Models;
using System.Collections.ObjectModel;

// For database connection
using System.IO;
using SQLite;
using MFAsample_final.Tables;
using Xamarin.Essentials;

namespace MFAsample_final.ViewModel
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> KeyList { get; set; }

        public MyListPageViewModel()
        {
            KeyList = new ObservableCollection<MyListModel>();

            try
            {
                var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
                var db = new SQLiteConnection(dbpath);
                var myQuery = db.Table<SharedCarKeyTable>();
                foreach (SharedCarKeyTable sharedKey in myQuery)
                {
                    MyListModel newList = new MyListModel
                    {
                        Name = sharedKey.Email,
                        DateBooked = "StartDate: " + sharedKey.DateBooked.ToShortDateString(),
                        EndDate = "EndDate: " + sharedKey.EndDate.ToShortDateString(),
                        BagageDoor = sharedKey.BagageDoor,
                        CarStart = sharedKey.CarStart,
                        LowerLeftDoor = sharedKey.LowerLeftDoor,
                        LowerRightDoor = sharedKey.LowerLeftDoor,
                        UpperLeftDoor = sharedKey.UpperLeftDoor,
                        UpperRightDoor = sharedKey.UpperRightDoor,
                        PictureSource = "https://i.pinimg.com/originals/0d/36/e7/0d36e7a476b06333d9fe9960572b66b9.jpg"
                    };
                    
                    if(DateTime.Now.Date >= sharedKey.DateBooked.Date)
                    {
                        newList.DaysLeft = "Days Left: " + (sharedKey.EndDate.Date - DateTime.Now.Date).TotalDays + "d";
                    }
                    else
                    {
                        newList.DaysLeft = "Days before activating: " + (sharedKey.DateBooked.Date - DateTime.Now.Date).TotalDays + "d";
                    }
                    KeyList.Add(newList);
                }
            }
            catch (SQLiteException errormsg)
            {
                // Do nothing
            }
            }
    }
}

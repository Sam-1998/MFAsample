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
                    KeyList.Add(new MyListModel
                    {
                        Name = sharedKey.Email,
                        DateBooked = sharedKey.DateBooked,
                        EndDate = sharedKey.EndDate,
                        BagageDoor = sharedKey.BagageDoor,
                        CarStart = sharedKey.CarStart,
                        LowerLeftDoor = sharedKey.LowerLeftDoor,
                        LowerRightDoor = sharedKey.LowerLeftDoor,
                        UpperLeftDoor = sharedKey.UpperLeftDoor,
                        UpperRightDoor = sharedKey.UpperRightDoor
                    });
                }
            }
            catch (SQLiteException errormsg)
            {
                // Do nothing
            }

            KeyList.Add(new MyListModel { Name = "Aleksander Pantic", PictureSource = "https://media-exp1.licdn.com/dms/image/C4D03AQFMAFBfTIrnBg/profile-displayphoto-shrink_200_200/0?e=1593043200&v=beta&t=9UA9M2XOFVvv3dk_YSgdYMe4VVHWzmL9Qqw6ltKD7b0"});
            }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using MFAsample_final.Models;
using System.Collections.ObjectModel;

namespace MFAsample_final.ViewModel
{
    public class MyListPageViewModel
    {
        public ObservableCollection<MyListModel> KeyList { get; set; }

        public MyListPageViewModel()
        {
            KeyList = new ObservableCollection<MyListModel>();
            KeyList.Add(new MyListModel { Name = "Aleksander Pantic", Permissions = "Full access", PictureSource = "https://media-exp1.licdn.com/dms/image/C4D03AQFMAFBfTIrnBg/profile-displayphoto-shrink_200_200/0?e=1593043200&v=beta&t=9UA9M2XOFVvv3dk_YSgdYMe4VVHWzmL9Qqw6ltKD7b0" });
            }
    }
}

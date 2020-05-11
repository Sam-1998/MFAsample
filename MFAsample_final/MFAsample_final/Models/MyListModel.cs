using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MFAsample_final.Models
{
    public class MyListModel
    {
        public string Name { get; set;}
        public string PictureSource { get; set; }
        public String DateBooked { get; set; }
        public String EndDate { get; set; }

        public String DaysLeft { get; set; }
        public Boolean UpperLeftDoor { get; set; }
        public Boolean LowerLeftDoor { get; set; }
        public Boolean UpperRightDoor { get; set; }
        public Boolean LowerRightDoor { get; set; }
        public Boolean BagageDoor { get; set; }
        public Boolean CarStart { get; set; }
    }
}

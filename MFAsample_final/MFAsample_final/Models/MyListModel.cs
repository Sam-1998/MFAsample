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
        public DateTime DateBooked { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean UpperLeftDoor;
        public Boolean LowerLeftDoor;
        public Boolean UpperRightDoor;
        public Boolean LowerRightDoor;
        public Boolean BagageDoor;
        public Boolean CarStart;
    }
}

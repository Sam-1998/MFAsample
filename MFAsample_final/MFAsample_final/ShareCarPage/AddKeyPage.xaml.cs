using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MFAsample_final.ShareCarPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddKeyPage : ContentPage
    {
        public Boolean UpperLeftDoor;
        public Boolean LowerLeftDoor;
        public Boolean UpperRightDoor;
        public Boolean LowerRightDoor;
        public Boolean BagageDoor;
        public Boolean CarStart;

        public AddKeyPage()
        {
            InitializeComponent();
            UpperLeftDoor = true;
            LowerLeftDoor = true;
            UpperRightDoor = true;
            LowerRightDoor = true;
            BagageDoor = true;
            CarStart = true;
        }

        private void UpperLeftDoorButton_Clicked(object sender, EventArgs e)
        {
            if (UpperLeftDoor) {
                UpperLeftDoorButton.Source = "Button_Red.png";
                UpperLeftDoor = false;
            }
            else
            {
                UpperLeftDoorButton.Source = "Button_Green.png";
                UpperLeftDoor = true;
            }
        }

        private void LowerLeftDoorButton_Clicked(object sender, EventArgs e)
        {
            if (LowerLeftDoor)
            {
                LowerLeftDoorButton.Source = "Button_Red.png";
                LowerLeftDoor = false;
            }
            else
            {
                LowerLeftDoorButton.Source = "Button_Green.png";
                LowerLeftDoor = true;
            }

        }

        private void UpperRightDoorButton_Clicked(object sender, EventArgs e)
        {
            if (UpperRightDoor)
            {
                UpperRightDoorButton.Source = "Button_Red.png";
                UpperRightDoor = false;
            }
            else
            {
                UpperRightDoorButton.Source = "Button_Green.png";
                UpperRightDoor = true;
            }

        }

        private void LowerRightDoorButton_Clicked(object sender, EventArgs e)
        {
            if (LowerRightDoor)
            {
                LowerRightDoorButton.Source = "Button_Red.png";
                LowerRightDoor = false;
            }
            else
            {
                LowerRightDoorButton.Source = "Button_Green.png";
                LowerRightDoor = true;
            }

        }

        private void BagageDoorButton_Clicked(object sender, EventArgs e)
        {
            if (BagageDoor)
            {
                BagageDoorButton.Source = "Button_Red.png";
                BagageDoor = false;
            }
            else
            {
                BagageDoorButton.Source = "Button_Green.png";
                BagageDoor = true;
            }

        }

        private void CarStartButton_Clicked(object sender, EventArgs e)
        {
            if (CarStart)
            {
                CarStartButton.Source = "Button_Red.png";
                CarStart = false;
            }
            else
            {
                CarStartButton.Source = "Button_Green.png";
                CarStart = true;
            }

        }
    }
}
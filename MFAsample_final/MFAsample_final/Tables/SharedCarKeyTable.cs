using System;
using System.Collections.Generic;
using System.Text;

namespace MFAsample_final.Tables
{
    class SharedCarKeyTable
    {
        public Guid UserId { get; set; }
        public String Email { get; set; }
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

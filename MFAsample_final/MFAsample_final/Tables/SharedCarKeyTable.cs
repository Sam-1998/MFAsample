using System;
using System.Collections.Generic;
using System.Text;

namespace MFAsample_final.Tables
{
    class SharedCarKeyTable
    {
        public Guid UserId { get; set; }
        public String Email { get; set; }
        public String DateBooked { get; set; }
        public String EndDate { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform
{
    class Record: Member
    {
        public int RecordId { get; set; }
        public DateTime RecordDate { get; set; }
        public bool VerificationStatus { get; set; }
    }
}

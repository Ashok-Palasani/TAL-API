﻿using System;
using System.Collections.Generic;

namespace DAS.DBModels
{
    public partial class PcbdaqinTblNew
    {
        public int Daqinid { get; set; }
        public string Pcbipaddress { get; set; }
        public int ParamPin { get; set; }
        public int? ParamValue { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
    }
}

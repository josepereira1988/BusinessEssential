﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BETools.Entitys
{
    public class CPBanco
    {
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        public bool IS_NULLABLE { get; set; }
        public string DATA_TYPE { get; set; }
        public int CHARACTER_MAXIMUM_LENGTH { get; set; }
        public string COLUMN_KEY { get; set; }
        public string EXTRA { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
     public class NumericFieldException : Exception
        {
            public override string Message
            {
                get
                {
                    return string.Format("Lutfen sayısal değer giriniz");
                }
            }
        }
    
}

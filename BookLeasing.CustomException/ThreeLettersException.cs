using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class ThreeLettersException : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifre en az 3 harf içermelidir.";
            }
        }
    }
}

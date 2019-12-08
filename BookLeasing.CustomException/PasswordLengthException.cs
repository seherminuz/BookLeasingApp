using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class PasswordLengthException : Exception
    {
        int _charCount = 0;
        int _charMaxCount = 0;
        public PasswordLengthException(int charCount, int charMaxCount)
        {
            _charCount = charCount;
            _charMaxCount = charMaxCount;
        }
        public override string Message
        {
            get
            {
                return string.Format("Şifre en az {0}, en çok {1} karakter olmalıdır.", _charCount, _charMaxCount);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class SequentialLetterException : Exception
    {
        int _charCount = 0;
        public SequentialLetterException(int charCount)
        {
            _charCount = charCount;
        }
        public override string Message
        {
            get
            {
                return string.Format("Şifre  {0} veya daha fazla ardışık harf içeremez.", _charCount);
            }
        }
    }
}

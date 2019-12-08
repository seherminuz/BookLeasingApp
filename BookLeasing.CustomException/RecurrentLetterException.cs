using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
   public class RecurrentLetterException : Exception
    {
        int _charCount =0;
        public RecurrentLetterException(int charCount)
        {
            _charCount = charCount;
        }
        public override string Message
        {
            get
            {
                return string.Format("Lutfen şifrenizde {0} veya daha fazla kez tekrarlayan ifadeler kullanmayınız.",_charCount);
            }
        }
    }
}

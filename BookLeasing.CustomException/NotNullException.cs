using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLeasing.CustomException
{
    public class NotNullException : Exception
    {
        string _data;
        public NotNullException(string data)
        {
            _data = data;
        }
        public override string Message
        {
            get
            {
                return $"Alan Boş geçilemez.Alan : {_data }";
            }
        }
    }
}

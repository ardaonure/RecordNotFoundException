using System;
using System.Collections.Generic;
using System.Text;

namespace RecordNotFoundException
{
  public  class RecordNotFound:Exception
    {
        public RecordNotFound(string message):base(message)
        {
            
        }
    }
}

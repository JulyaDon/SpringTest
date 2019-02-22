using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringTest
{
    class SimpleMessage : ISimpleMessage
    {
        private string _message;

        public SimpleMessage()
        {

        }

        public SimpleMessage(string message)
        {
            _message = message;
        }

        public String Message
        {
            get
            {
                return _message;
            }

            set
            {
                _message = value;
            }
        }
    }
}
